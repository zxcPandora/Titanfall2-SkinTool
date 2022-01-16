using System;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Resources;
using System.Threading;
using System.Windows.Forms;
using BCnEncoder.Encoder;
using ImageMagick;
using ImageMagick.Formats;

namespace Titanfall2_SkinTool
{
    public partial class SkinPackMakerWindow : Form
    {
        string SelectedGame = null;
        string SelectedWeapon = null;
        ResourceManager rm = new ResourceManager("Titanfall2_SkinTool.Language", Assembly.GetExecutingAssembly());

        public SkinPackMakerWindow(String SelectedGame)
        {
            InitializeComponent();
            this.SelectedGame = SelectedGame;
            LanguageSet();
            LoadWeaponName();
            DisableAllTextures();
        }

        private void openSkinPackPathSelectButton_Click(object sender, EventArgs e)
        {
            DialogResult result = skinPackPathDialogue.ShowDialog();
            skinPackPathTextBox.Text = skinPackPathDialogue.SelectedPath;
        }

        private void texturePictureBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Link;
        }

        private void texturePictureBox_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            PictureBoxDragEvent(box, e);
        }

        private void PictureBoxDragEvent(PictureBox box, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files) Console.WriteLine(file);

            string filepath = files[0];
            LoadImageIntoPictureBox(box, filepath);
        }

        private void LoadImageIntoPictureBox(PictureBox box, string filepath)
        {
            if (filepath.Length > 0)
            {
                try
                {
                    box.Image = Image.FromFile(filepath);
                }
                catch (OutOfMemoryException ex)
                {

                    MessageBox.Show(rm.GetString("ImageReadOutOfMem") + "\r\r" + ex.Message, rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void generateSkinPackButton_Click(object sender, EventArgs e)
        {
            ProgressForm progressForm = null;

            if (skinNameTextBox.Text == null)
            {
                MessageBox.Show(rm.GetString("SkinNameNotSet"), rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (SelectedWeapon == null || assetTypeComboBox.Text == null || assetTypeComboBox.SelectedItem == null)
            {
                MessageBox.Show(rm.GetString("WeaponNotSet"), rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (skinPackPathDialogue.SelectedPath.Length == 0 && skinPackPathTextBox.Text == null)
            {
                MessageBox.Show(rm.GetString("SkinPackPathNotSelected"), rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (File.Exists(GetSkinPackRootPath()))
            {
                try
                {
                    File.Delete(GetSkinPackRootPath());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(rm.GetString("CannotDeleteArchive") + ex.Message, rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            Thread progressThread = new Thread(() =>
            {
                progressForm = new ProgressForm(7); // 7 texture slots 
                progressForm.ShowDialog();
            }
            ); // 7 texture slots
            progressThread.Start();

            ZipArchive zipArchive = ZipFile.Open(GetSkinPackRootPath(), ZipArchiveMode.Create);

            try
            {
                if (colorPictureBox.Enabled && colorPictureBox.Image != null)
                {
                    MagickImage colorImage = new MagickImage(ImageToByteArray(colorPictureBox.Image));
                    if (SelectedWeapon == "Archer" || SelectedWeapon == "SMR" || SelectedWeapon == "DoubleTake" || (SelectedGame == "Titanfall2" && SelectedWeapon == "Volt") || SelectedWeapon == "BroadSword" || SelectedWeapon == "ThermiteLauncher")
                    {
                        SaveTexture(SelectedWeapon + "_Default_col.dds", colorImage, zipArchive, BCnEncoder.Shared.CompressionFormat.Bc7);
                    }
                    else
                    {
                        colorImage.SetCompression(CompressionMethod.DXT1);
                        SaveTexture(SelectedWeapon + "_Default_col.dds", colorImage, zipArchive, BCnEncoder.Shared.CompressionFormat.Rgba);
                    }
                }

                progressForm?.AdvanceEntry();

                if (specularPictureBox.Enabled && specularPictureBox.Image != null)
                {
                    MagickImage specularImage = new MagickImage(ImageToByteArray(specularPictureBox.Image));
                    if (SelectedWeapon == "DoubleTake" || (SelectedGame == "Titanfall2" && SelectedWeapon == "Volt") || SelectedWeapon == "BroadSword" || SelectedWeapon == "ThermiteLauncher")
                    {
                        SaveTexture(SelectedWeapon + "_Default_spc.dds", specularImage, zipArchive, BCnEncoder.Shared.CompressionFormat.Bc7);
                    }
                    else
                    {
                        specularImage.SetCompression(CompressionMethod.DXT1);
                        SaveTexture(SelectedWeapon + "_Default_spc.dds", specularImage, zipArchive);
                    }
                }

                progressForm?.AdvanceEntry();

                if (normalPictureBox.Enabled && normalPictureBox.Image != null)
                {
                    MagickImage normalImage = new MagickImage(ImageToByteArray(normalPictureBox.Image));
                    //normalImage.Level(new Percentage(100), new Percentage(0), Channels.RGB);
                    SaveTexture(SelectedWeapon + "_Default_nml.dds", normalImage, zipArchive, BCnEncoder.Shared.CompressionFormat.Bc5);
                }

                progressForm?.AdvanceEntry();

                if (glossinessPictureBox.Enabled && glossinessPictureBox.Image != null)
                {
                    MagickImage glossinessImage = new MagickImage(ImageToByteArray(glossinessPictureBox.Image));
                    SaveTexture(SelectedWeapon + "_Default_gls.dds", glossinessImage, zipArchive, BCnEncoder.Shared.CompressionFormat.Bc4);
                }

                progressForm?.AdvanceEntry();

                if (aoPictureBox.Enabled && aoPictureBox.Image != null)
                {
                    MagickImage aoImage = new MagickImage(ImageToByteArray(aoPictureBox.Image));
                    if (SelectedGame == "Titanfall2")
                    {
                        aoImage.SetCompression(CompressionMethod.DXT1);
                        SaveTexture(SelectedWeapon + "_Default_ao.dds", aoImage, zipArchive);
                    }
                    else
                    {
                        SaveTexture(SelectedWeapon + "_Default_ao.dds", aoImage, zipArchive, BCnEncoder.Shared.CompressionFormat.Bc4);
                    }
                }

                progressForm?.AdvanceEntry();

                if (cavityPictureBox.Enabled && cavityPictureBox.Image != null)
                {
                    MagickImage cavityImage = new MagickImage(ImageToByteArray(cavityPictureBox.Image));
                    if (SelectedGame == "Titanfall2")
                    {
                        cavityImage.SetCompression(CompressionMethod.DXT1);
                        SaveTexture(SelectedWeapon + "_Default_cav.dds", cavityImage, zipArchive);
                    }
                    else
                    {
                        SaveTexture(SelectedWeapon + "_Default_cav.dds", cavityImage, zipArchive, BCnEncoder.Shared.CompressionFormat.Bc4);
                    }
                }

                progressForm?.AdvanceEntry();

                if (illuminationPictureBox.Enabled && illuminationPictureBox.Image != null)
                {
                    MagickImage illuminationImage = new MagickImage(ImageToByteArray(illuminationPictureBox.Image));
                    illuminationImage.SetCompression(CompressionMethod.DXT1);
                    SaveTexture(SelectedWeapon + "_Default_ilm.dds", illuminationImage, zipArchive);
                }
                progressForm?.AdvanceEntry();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n" + ex.Source, rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            progressForm?.ForceClose();

            zipArchive.Dispose();
        }


        private string GetSkinPackRootPath()
        {
            return skinPackPathTextBox.Text + "\\" + SelectedWeapon + "_" + skinNameTextBox.Text + ".zip";
        }
        private byte[] ImageToByteArray(System.Drawing.Image image)
        {
            using (var _memorystream = new MemoryStream())
            {
                image.Save(_memorystream, image.RawFormat);
                return _memorystream.ToArray();
            }
        }

        private void SaveTexture(string filename, MagickImage image, ZipArchive archive, BCnEncoder.Shared.CompressionFormat compression = BCnEncoder.Shared.CompressionFormat.Rgba)
        {
            int[] WidthSize = new int[] {
                4096,
                2048,
                1024,
                512
            };
            int[] HeightSize = new int[] {
                4096,
                2048,
                1024,
                512,
                256
            };
            var Info = new MagickImageInfo(image.ToByteArray());
            //All set to 1 for Titanfall2
            //I forget about the APEX,but I still remember APEX have that 4096
            //May be will fix it in the future:D
            //I found that pilot texture can use it:(
            int WidthCheck = 1;
            int HightCheck = 1;
            if (Info.Width != Info.Height)
            {
                HightCheck++;
            }
            
            for (int i= WidthCheck, j= HightCheck; i<=3;i++,j++)
            {
                ZipArchiveEntry entry = archive.CreateEntry("contents/" + WidthSize[i].ToString() + "/" + filename);
                using (Stream s = entry.Open())
                {
                    image.Scale(WidthSize[i], HeightSize[j]);
                    if (compression != BCnEncoder.Shared.CompressionFormat.Rgba)
                    {
                        image.Format = MagickFormat.Png32;
                        image.SetCompression(CompressionMethod.NoCompression);
                        BcEncoder encoder = new BcEncoder();
                        encoder.OutputOptions.GenerateMipMaps = false;
                        encoder.OutputOptions.Format = compression;
                        encoder.OutputOptions.FileFormat = BCnEncoder.Shared.OutputFileFormat.Dds;
                        encoder.EncodeToStream(image.ToByteArray(MagickFormat.Rgba), WidthSize[i], HeightSize[j], BCnEncoder.Encoder.PixelFormat.Rgba32, s);
                    }
                    else
                    {
                        DdsWriteDefines ddsDefines = new DdsWriteDefines();
                        ddsDefines.Compression = DdsCompression.Dxt1;
                        ddsDefines.Mipmaps = 0;

                        image.Format = MagickFormat.Dds;
                        image.Settings.SetDefines(ddsDefines);

                        image.Write(s);
                    }

                    s.Flush();
                    s.Close();
                }
            }
        }

        private void texturePictureBox_NClick(object sender, EventArgs e)
        {
            MouseEventArgs m = (MouseEventArgs)e;
            PictureBox box = (PictureBox)sender;

            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.Add(rm.GetString("ContextChoose"), null, (object menuSender, EventArgs menuE) =>
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Multiselect = false;
                dialog.Filter = "PNG (*.png) | *.png";

                DialogResult res = dialog.ShowDialog();
                if (res == DialogResult.OK)
                {
                    LoadImageIntoPictureBox(box, dialog.FileName);
                }
            });
            menu.Items.Add(rm.GetString("ContextRemove"), null, (object menuSender, EventArgs menuE) =>
            {
                box.Image = null;
            });

            menu.Show(box, m.Location);
        }

        private void texturePictureBox_MouseEnter(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            if (box.Enabled == false)
            {
            }
        }

        private void assetTypeComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SelectedItemChanged();
            DisableAllTextures();
            if (SelectedGame == "APEX")
            {
                switch (SelectedWeapon)
                {
                    case "RE45":
                        {
                            EnableTexture(colorPictureBox);
                            EnableTexture(normalPictureBox);
                            EnableTexture(glossinessPictureBox);
                            EnableTexture(specularPictureBox);
                            EnableTexture(illuminationPictureBox);
                            break;
                        }
                    case "R301":
                    case "Hemlok":
                    case "VK47Flatline":
                    case "LSTAR":
                    case "Spitfire":
                    case "P2020":
                    case "Wingman":
                    case "EVA8":
                    case "Mastiff":
                    case "Mozambique":
                    case "Kraber":
                    case "Longbow":
                    case "Alternator":
                    case "PDW":
                        {
                            EnableTexture(colorPictureBox);
                            EnableTexture(normalPictureBox);
                            EnableTexture(glossinessPictureBox);
                            EnableTexture(specularPictureBox);
                            EnableTexture(aoPictureBox);
                            EnableTexture(cavityPictureBox);
                            break;
                        }
                    case "Havoc":
                    case "Devotion":
                    case "Peacekeeper":
                    case "G2A7":
                    case "TripleTake":
                    case "R99":
                        {
                            EnableTexture(colorPictureBox);
                            EnableTexture(normalPictureBox);
                            EnableTexture(glossinessPictureBox);
                            EnableTexture(specularPictureBox);
                            EnableTexture(illuminationPictureBox);
                            EnableTexture(aoPictureBox);
                            EnableTexture(cavityPictureBox);
                            break;
                        }
                    default:
                        MessageBox.Show(rm.GetString("BUG"), rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                }
            }
            else if (SelectedGame == "Titanfall2")
            {
                switch (SelectedWeapon)
                {
                    case "Devotion":
                        {
                            EnableTexture(colorPictureBox);
                            EnableTexture(normalPictureBox);
                            EnableTexture(glossinessPictureBox);
                            EnableTexture(specularPictureBox);
                            EnableTexture(illuminationPictureBox);
                            EnableTexture(aoPictureBox);
                            break;
                        }
                    case "PredatorCannon":
                        {
                            EnableTexture(colorPictureBox);
                            EnableTexture(normalPictureBox);
                            EnableTexture(glossinessPictureBox);
                            EnableTexture(specularPictureBox);
                            EnableTexture(aoPictureBox);
                            break;
                        }
                    case "Alternator":
                    case "DoubleTake":
                    case "LongbowDMR":
                    case "Mozambique":
                    case "SMR":
                    case "Softball":
                    case "MGL":
                    case "BroadSword":
                    case "LeadWall":
                    case "SplitterRifle":
                    case "ThermiteLauncher":
                        {
                            EnableTexture(colorPictureBox);
                            EnableTexture(normalPictureBox);
                            EnableTexture(glossinessPictureBox);
                            EnableTexture(specularPictureBox);
                            EnableTexture(aoPictureBox);
                            EnableTexture(cavityPictureBox);
                            break;
                        }
                    case "CAR":
                    case "R97":
                    case "Volt":
                    case "Kraber":
                    case "EVA8":
                    case "Mastiff":
                    case "P2016":
                    case "RE45":
                    case "SmartPistol":
                    case "Wingman":
                    case "WingmanElite":
                    case "LSTAR":
                    case "Spitfire":
                    case "ColdWar":
                    case "EPG":
                    case "G2A5":
                    case "HemlokBFR":
                    case "R101":
                    case "R201":
                    case "V47Flatline":
                    case "Archer":
                    case "ChargeRifle":
                    case "Thunderbolt":
                    case "Devotion_clip":
                    case "PlasmaRailgun":
                    case "TrackerCannon":
                    case "XO16":
                    case "XO16_clip":
                        {
                            EnableTexture(colorPictureBox);
                            EnableTexture(normalPictureBox);
                            EnableTexture(glossinessPictureBox);
                            EnableTexture(specularPictureBox);
                            EnableTexture(illuminationPictureBox);
                            EnableTexture(aoPictureBox);
                            EnableTexture(cavityPictureBox);
                            break;
                        }
                    case "NULL":
                        {
                            MessageBox.Show(rm.GetString("SelectNULL"), rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    default:
                        MessageBox.Show(rm.GetString("BUG"), rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }

        private void DisableAllTextures()
        {
            foreach (PictureBox box in new PictureBox[]
                {
                    colorPictureBox,
                    specularPictureBox,
                    glossinessPictureBox,
                    normalPictureBox,
                    aoPictureBox,
                    cavityPictureBox,
                    illuminationPictureBox
                })
            {
                DisableTexture(box);
            }
        }

        private void DisableTexture(PictureBox box)
        {
            box.Enabled = false;
            box.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("texture_not_available");
        }

        private void EnableTexture(PictureBox box)
        {
            box.Enabled = true;
            box.Image = null;
        }

        private void LanguageSet()
        {
            // LOCALIZATION

            // General Info Group
            this.Text = rm.GetString("SkinPackMaker");
            generalInfoGroup.Text = rm.GetString("GeneralInfoGroup");
            skinNameLabel.Text = rm.GetString("SkinName");
            assetTypeLabel.Text = rm.GetString("AssetType");
            savePathLabel.Text = rm.GetString("SavePath");

            // Textures Set Group

            texturesSetGroup.Text = rm.GetString("TexturesSetGroup");
            colorLabel.Text = rm.GetString("Color");
            specularLabel.Text = rm.GetString("Specular");
            glossinessLabel.Text = rm.GetString("Glossinesss");
            normalLabel.Text = rm.GetString("Normal");
            aoLabel.Text = rm.GetString("AO");
            cavityLabel.Text = rm.GetString("Cavity");
            illuminationLabel.Text = rm.GetString("Illumination");

            // Generate Button
            generateSkinPackButton.Text = rm.GetString("Generate");

            // Default Path
            skinPackPathTextBox.Text = Environment.CurrentDirectory;
        }

        private void LoadWeaponName()
        {
            switch (SelectedGame)
            {
                case "APEX":
                    this.assetTypeComboBox.Items.AddRange(new object[] {
                        rm.GetString("Items"),
                        rm.GetString("Items1"),
                        rm.GetString("Items2"),
                        rm.GetString("Items3"),
                        rm.GetString("Items4"),
                        rm.GetString("Items5"),
                        rm.GetString("Items6"),
                        rm.GetString("Items7"),
                        rm.GetString("Items8"),
                        rm.GetString("Items9"),
                        rm.GetString("Items10"),
                        rm.GetString("Items11"),
                        rm.GetString("Items12"),
                        rm.GetString("Items13"),
                        rm.GetString("Items14"),
                        rm.GetString("Items15"),
                        rm.GetString("Items16"),
                        rm.GetString("Items17"),
                        rm.GetString("Items18"),
                        rm.GetString("Items19"),
                        rm.GetString("Items20"),
                        rm.GetString("Items21"),
                        rm.GetString("Items22")
                    });
                    break;
                case "Titanfall2":
                    this.assetTypeComboBox.Items.AddRange(new object[] {
                        //突击步枪
                        rm.GetString("tip1"),
                        rm.GetString("Items23"),
                        rm.GetString("Items24"),
                        rm.GetString("Items25"),
                        rm.GetString("Items26"),
                        rm.GetString("Items27"),
                        //冲锋枪
                        rm.GetString("tip2"),
                        rm.GetString("Items28"),
                        rm.GetString("Items5"),
                        rm.GetString("Items8"),
                        rm.GetString("Items29"),
                        //散弹枪
                        rm.GetString("tip3"),
                        rm.GetString("Items16"),
                        rm.GetString("Items17"),
                        //狙击步枪
                        rm.GetString("tip4"),
                        rm.GetString("Items13"),
                        rm.GetString("Items30"),
                        rm.GetString("Items31"),
                        //轻机枪
                        rm.GetString("tip5"),
                        rm.GetString("Items11"),
                        rm.GetString("Items10"),
                        rm.GetString("Items9"),
                        rm.GetString("Items42"),
                        //榴弹枪
                        rm.GetString("tip6"),
                        rm.GetString("Items34"),
                        rm.GetString("Items33"),
                        rm.GetString("Items35"),
                        rm.GetString("Items32"),
                        //主武器手枪
                        rm.GetString("tip7"),
                        rm.GetString("Items38"),
                        rm.GetString("Items19"),
                        //反泰坦武器
                        rm.GetString("tip8"),
                        rm.GetString("Items4"),
                        rm.GetString("Items40"),
                        rm.GetString("Items41"),
                        rm.GetString("Items39"),
                        //副武器手枪
                        rm.GetString("tip9"),
                        rm.GetString("Items36"),
                        rm.GetString("Items21"),
                        rm.GetString("Items22"),
                        //强化卡
                        rm.GetString("tip11"),
                        rm.GetString("Items37"),
                        //泰坦武器
                        rm.GetString("tip10"),
                        rm.GetString("Items48"),
                        rm.GetString("Items49"),
                        rm.GetString("Items43"),
                        rm.GetString("Items44"),
                        rm.GetString("Items45"),
                        rm.GetString("Items46"),
                        rm.GetString("Items47"),
                        rm.GetString("Items50"),
                        rm.GetString("Items51"),
                    });
                    break;
                default:
                    MessageBox.Show(rm.GetString("SetGamePath"), rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void SelectedItemChanged()
        {
            switch (assetTypeComboBox.Text)
            {
                //start APEX part
                case "R301":
                case "R-301卡宾枪":
                    SelectedWeapon = "R301";
                    break;
                case "Havoc":
                case "哈沃克步枪":
                    SelectedWeapon = "Havoc";
                    break;
                case "Hemlok":
                case "赫姆洛克突击步枪":
                    SelectedWeapon = "Hemlok";
                    break;
                case "VK47Flatline":
                case "VK-47平行步枪":
                    SelectedWeapon = "VK47Flatline";
                    break;
                case "ChargeRifle":
                case "电能步枪":
                    SelectedWeapon = "ChargeRifle";
                    break;
                case "Alternator":
                case "转换者冲锋枪":
                    SelectedWeapon = "Alternator";
                    break;
                case "PDW":
                case "猎兽冲锋枪":
                    SelectedWeapon = "PDW";
                    break;
                case "R99":
                case "R-99冲锋枪":
                    SelectedWeapon = "R99";
                    break;
                case "Volt":
                case "电能冲锋枪":
                    SelectedWeapon = "Volt";
                    break;
                case "Devotion":
                case "专注轻机枪":
                    SelectedWeapon = "Devotion";
                    break;
                case "LSTAR":
                case "L-star轻机枪":
                    SelectedWeapon = "LSTAR";
                    break;
                case "Spitfire":
                case "喷火轻机枪":
                    SelectedWeapon = "Spitfire";
                    break;
                case "TripleTake":
                case "三重式狙击枪":
                    SelectedWeapon = "TripleTake";
                    break;
                case "Kraber":
                case "克莱伯":
                    SelectedWeapon = "Kraber";
                    break;
                case "Longbow":
                case "长弓":
                    SelectedWeapon = "Longbow";
                    break;
                case "G2A7":
                case "G7侦查枪":
                    SelectedWeapon = "G2A7";
                    break;
                case "EVA8":
                    SelectedWeapon = "EVA8";
                    break;
                case "Mastiff":
                case "獒犬":
                    SelectedWeapon = "Mastiff";
                    break;
                case "Peacekeeper":
                case "和平捍卫者":
                    SelectedWeapon = "Peacekeeper";
                    break;
                case "Mozambique":
                case "莫桑比克":
                    SelectedWeapon = "Mozambique";
                    break;
                case "P2020":
                    SelectedWeapon = "P2020";
                    break;
                case "RE45":
                    SelectedWeapon = "RE45";
                    break;
                case "Wingman":
                case "小帮手":
                    SelectedWeapon = "Wingman";
                    break;
                //Titanfall2 part
                case "R201":
                case "R-201卡宾枪":
                    SelectedWeapon = "R201";
                    break;
                case "R101":
                case "R-101卡宾枪":
                    SelectedWeapon = "R101";
                    break;
                case "HemlokBFR":
                case "汗洛BF-R":
                    SelectedWeapon = "HemlokBFR";
                    break;
                case "V47Flatline":
                case "V-47平行步枪":
                    SelectedWeapon = "V47Flatline";
                    break;
                case "G2A5":
                    SelectedWeapon = "G2A5";
                    break;
                case "CAR":
                    SelectedWeapon = "CAR";
                    break;
                case "R97":
                case "R-97":
                    SelectedWeapon = "R97";
                    break;
                case "DoubleTake":
                case "D-2双发狙击步枪":
                    SelectedWeapon = "DoubleTake";
                    break;
                case "LongbowDMR":
                case "长弓DMR":
                    SelectedWeapon = "LongbowDMR";
                    break;
                case "ColdWar":
                case "EM-4冷战榴弹枪":
                    SelectedWeapon = "ColdWar";
                    break;
                case "EPG":
                case "能源炮-1":
                    SelectedWeapon = "EPG";
                    break;
                case "SMR":
                case "响尾蛇飞弹":
                    SelectedWeapon = "SMR";
                    break;
                case "Softball":
                case "R-6P垒球榴弹枪":
                    SelectedWeapon = "Softball";
                    break;
                case "P2016":
                    SelectedWeapon = "P2016";
                    break;
                case "SmartPistol":
                case "智慧手枪":
                    SelectedWeapon = "SmartPistol";
                    break;
                case "WingmanElite":
                case "小帮手精英":
                    SelectedWeapon = "WingmanElite";
                    break;
                case "Archer":
                case "射手飞弹":
                    SelectedWeapon = "Archer";
                    break;
                case "MGL":
                case "磁能榴弹发射器":
                    SelectedWeapon = "MGL";
                    break;
                case "Thunderbolt":
                case "LG-97雷电炮":
                    SelectedWeapon = "Thunderbolt";
                    break;
                case "Devotion clip":
                case "专注轻机枪弹夹":
                    SelectedWeapon = "Devotion_clip";
                    break;
                case "Plasma Railgun":
                case "电浆磁轨炮":
                    SelectedWeapon = "PlasmaRailgun";
                    break;
                case "Predator Cannon":
                case "猎杀者机炮":
                    SelectedWeapon = "PredatorCannon";
                    break;
                case "T-203 Thermite Launcher":
                case "T-203 铝热剂发射器":
                    SelectedWeapon = "ThermiteLauncher";
                    break;
                case "40mm Tracker Cannon":
                case "追踪机炮":
                    SelectedWeapon = "TrackerCannon";
                    break;
                case "Splitter Rifle":
                case "分裂枪":
                    SelectedWeapon = "SplitterRifle";
                    break;
                case "Broad Sword":
                case "大剑":
                    SelectedWeapon = "BroadSword";
                    break;
                case "Leadwall":
                case "天女散花":
                    SelectedWeapon = "LeadWall";
                    break;
                case "XO16":
                    SelectedWeapon = "XO16";
                    break;
                case "XO16 clip":
                case "XO16弹夹":
                    SelectedWeapon = "XO16_clip";
                    break;
                default:
                    SelectedWeapon = "NULL";
                    break;
            }
        }
    }
}

