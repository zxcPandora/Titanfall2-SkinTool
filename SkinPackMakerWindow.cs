using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCnEncoder.Encoder;
using ImageMagick;
using ImageMagick.Formats;

namespace Titanfall2_SkinTool
{
    public partial class SkinPackMakerWindow : Form
    {
        System.Resources.ResourceManager rm = new ResourceManager("Titanfall2_SkinTool.Language", Assembly.GetExecutingAssembly());

        public SkinPackMakerWindow()
        {
            InitializeComponent();
            DisableAllTextures();
            

            // LOCALIZATION

            // General Info Group
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
            if(filepath.Length > 0)
            {
                try
                {
                    box.Image = Image.FromFile(filepath);
                }
                catch (OutOfMemoryException exception)
                {

                    MessageBox.Show(rm.GetString("ImageReadOutOfMem"), rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void generateSkinPackButton_Click(object sender, EventArgs e)
        {
            if(skinPackPathDialogue.SelectedPath.Length == 0)
            {
                MessageBox.Show(rm.GetString("SkinPackPathNotSelected"), rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(File.Exists(GetSkinPackRootPath()))
            {
                try
                {
                    File.Delete(GetSkinPackRootPath());
                } catch(Exception ex)
                {
                    MessageBox.Show(rm.GetString("CannotDeleteArchive") + ex.Message, rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            ZipArchive zipArchive = ZipFile.Open(GetSkinPackRootPath(), ZipArchiveMode.Create);

            if(colorPictureBox.Enabled && colorPictureBox.Image != null)
            {
                MagickImage colorImage = new MagickImage(ImageToByteArray(colorPictureBox.Image));
                colorImage.SetCompression(CompressionMethod.DXT1);
                SaveTexture(assetTypeComboBox.Text + "_Default_col.dds", colorImage, zipArchive, BCnEncoder.Shared.CompressionFormat.Rgba);
            }
            
            if(specularPictureBox.Enabled && specularPictureBox.Image != null)
            {
                MagickImage specularImage = new MagickImage(ImageToByteArray(specularPictureBox.Image));
                specularImage.SetCompression(CompressionMethod.DXT1);
                SaveTexture(assetTypeComboBox.Text + "_Default_spc.dds", specularImage, zipArchive);
            }
            
            if(normalPictureBox.Enabled && normalPictureBox.Image != null)
            {
                MagickImage normalImage = new MagickImage(ImageToByteArray(normalPictureBox.Image));
                //normalImage.Level(new Percentage(100), new Percentage(0), Channels.RGB);
                SaveTexture(assetTypeComboBox.Text + "_Default_nml.dds", normalImage, zipArchive, BCnEncoder.Shared.CompressionFormat.Bc5);
            }

            if(glossinessPictureBox.Enabled && glossinessPictureBox.Image != null)
            {
                MagickImage glossinessImage = new MagickImage(ImageToByteArray(glossinessPictureBox.Image));
                SaveTexture(assetTypeComboBox.Text + "_Default_gls.dds", glossinessImage, zipArchive, BCnEncoder.Shared.CompressionFormat.Bc4);
            }
            if(aoPictureBox.Enabled && aoPictureBox.Image != null)
            {
                MagickImage aoImage = new MagickImage(ImageToByteArray(aoPictureBox.Image));
                SaveTexture(assetTypeComboBox.Text + "_Default_ao.dds", aoImage, zipArchive, BCnEncoder.Shared.CompressionFormat.Bc4);
            }

            if (cavityPictureBox.Enabled && cavityPictureBox.Image != null)
            {
                MagickImage cavityImage = new MagickImage(ImageToByteArray(cavityPictureBox.Image));
                SaveTexture(assetTypeComboBox.Text + "_Default_cav.dds", cavityImage, zipArchive, BCnEncoder.Shared.CompressionFormat.Bc4);
            }

            if (illuminationPictureBox.Enabled && illuminationPictureBox.Image != null)
            {
                MagickImage illuminationImage = new MagickImage(ImageToByteArray(illuminationPictureBox.Image));
                illuminationImage.SetCompression(CompressionMethod.DXT1);
                SaveTexture(assetTypeComboBox.Text + "_Default_ilm.dds", illuminationImage, zipArchive);
            }

            zipArchive.Dispose();
        }

        private string GetSkinPackRootPath()
        {
            return skinPackPathDialogue.SelectedPath + "\\" + assetTypeComboBox.Text + "_" + skinNameTextBox.Text + ".zip";
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
            int[] sizes = new int[] {
                2048,
                1024,
                512
            };

            foreach(int size in sizes)
            {
                ZipArchiveEntry entry = archive.CreateEntry("contents/" + size.ToString() + "/" + filename);
                using (Stream s = entry.Open())
                {
                    image.Scale(size, size);
                    if(compression != BCnEncoder.Shared.CompressionFormat.Rgba)
                    {
                        image.Format = MagickFormat.Png32;
                        image.SetCompression(CompressionMethod.NoCompression);
                        BcEncoder encoder = new BcEncoder();
                        encoder.OutputOptions.GenerateMipMaps = false;
                        encoder.OutputOptions.Format = compression;
                        encoder.OutputOptions.FileFormat = BCnEncoder.Shared.OutputFileFormat.Dds;
                        encoder.EncodeToStream(image.ToByteArray(MagickFormat.Rgba), size, size, BCnEncoder.Encoder.PixelFormat.Rgba32, s);
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
                dialog.Filter = "PNG (*.png) | *.*";

                DialogResult res = dialog.ShowDialog();
                if(res == DialogResult.OK)
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
            if(box.Enabled == false)
            {
            }
        }

        private void assetTypeComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DisableAllTextures();
           switch(assetTypeComboBox.SelectedItem)
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
    }
}

