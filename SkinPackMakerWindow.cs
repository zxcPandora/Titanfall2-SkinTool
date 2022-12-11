using System;
using System.ComponentModel;
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
        int ImageNumber = 0;
        ResourceManager rm = new ResourceManager("Titanfall2_SkinTool.Language", Assembly.GetExecutingAssembly());

        public SkinPackMakerWindow(String SelectedGame)
        {
            InitializeComponent();
            this.SelectedGame = SelectedGame;
            LanguageSet();
            LoadWeaponName();
            DisableAllTextures();
        }

        /// <summary>
        /// Test feature
        /// </summary>
        /// 

        /*
         * The code is becoming garbage;
         * I should Dynamically generate tabs and use SQLite. Q_Q
         * If finished these features,program will beccome v1.0? LOL
        
        class SqLiteHelper
        private SQLiteConnection dbConnection;
        private SQLiteCommand dbCommand;
        private SQLiteDataReader dataReader;

        Label l = new Label();
        l.Location = new Point(493, 72);
        l.Text = "测试aaaaaaaaaaaaaaaaaaaaaaaaaa";
            l.Name = "L1";
            l.AutoSize = true;
            l.Parent = this;
            this.Controls.Add(l);

        private void button1_Click(object sender, EventArgs e)
        {
            TabPage tab;
            for (int i = 0; i <= 10; i++)
            {
                tab = new TabPage();
                //((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
                int tabcount = this.tabControl1.TabCount + 1;
                tab.Name =
                tab.Text = "TestTabPage" + tabcount;
                tab.Padding = new Padding(3);
                tab.UseVisualStyleBackColor = true;
                if (i != 0)
                {
                    AddPictureToTabPage(tab, "Color");
                    AddPictureToTabPage(tab, "Test");
                }
                this.tabControl1.Controls.Add(tab);
                //((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            }

            TabControl tt = new TabControl();
            tt.SuspendLayout();
            //((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            tt.Name = "ATestTabPage";
            tt.SelectedIndex = 0;
            tt.Dock = DockStyle.Fill;
            tt.ResumeLayout(false);
            tab = new TabPage();
            //((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            tab.Text = "CCTestTabPage";
            tab.Padding = new Padding(3);
            tab.UseVisualStyleBackColor = true;
            tt.Controls.Add(tab);
            tabControl1.Controls[2].Controls.Add(tt);
            for (int k = 0; k < this.Controls.Count; k++)
            {
                MessageBox.Show("[控件 " + k + " ]名称：" + this.Controls[k].Text + ",内容：" + this.Controls[k].Name);
                if (this.Controls[k].Name.Equals("control"))
                    MessageBox.Show(this.Controls[k].Text);
            }
            MessageBox.Show(this.Controls.Count.ToString());
            for (int j = 0; j < tabControl1.Controls[2].Controls.Count; j++)
            {
                //MessageBox.Show(tabControl1.Controls[2].Controls[j].Name+ ","+(((PictureBox)tabControl1.Controls[2].Controls[j]).Image==null?"空":"非空"+"\n"));
            }
            MessageBox.Show(tabControl1.Controls[2].Controls[0].Name);
        }

        private void AddPictureToTabPage(TabPage tabPage, String Name)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Location = new System.Drawing.Point(73, 39);
            pictureBox.Name = Name;
            pictureBox.Size = new System.Drawing.Size(125, 62);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            pictureBox.AllowDrop = true;
            pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBox.Name = "testPictureBox";
            pictureBox.TabStop = false;
            pictureBox.Click += new System.EventHandler(this.texturePictureBox_NClick);
            pictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.texturePictureBox_DragDrop);
            pictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.texturePictureBox_DragEnter);
            pictureBox.DoubleClick += new System.EventHandler(this.texturePictureBox_NClick);
            pictureBox.MouseEnter += new System.EventHandler(this.texturePictureBox_MouseEnter);
            tabPage.Controls.Add(pictureBox);
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
            //ImageNumber += 3;
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

                    MessageBox.Show("Error" + "\r\r" + ex.Message, "No way", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void texturePictureBox_NClick(object sender, EventArgs e)
        {
            MouseEventArgs m = (MouseEventArgs)e;
            PictureBox box = (PictureBox)sender;

            ContextMenuStrip menu = new ContextMenuStrip();
            menu.Items.Add("Error2", null, (object menuSender, EventArgs menuE) =>
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Multiselect = false;
                dialog.Filter = "PNG (*.png) | *.png";

                DialogResult res = dialog.ShowDialog();
                if (res == DialogResult.OK)
                {
                    LoadImageIntoPictureBox(box, dialog.FileName);
                    //ImageNumber += 3;
                }
            });
            menu.Items.Add("Error3", null, (object menuSender, EventArgs menuE) =>
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
        */




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
            ImageNumber += 3;
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

            if (colorPictureBox.Image == null && specularPictureBox.Image == null && normalPictureBox.Image == null &&
                glossinessPictureBox.Image == null && aoPictureBox.Image == null && cavityPictureBox.Image == null &&
                illuminationPictureBox.Image == null)
            {
                MessageBox.Show(rm.GetString("ImageReadOutOfMem"), rm.GetString("Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                progressForm = new ProgressForm(ImageNumber, "SkinPack");

                progressForm.ShowDialog();

            }
            );

            progressThread.Start();

            ZipArchive zipArchive = ZipFile.Open(GetSkinPackRootPath(), ZipArchiveMode.Create);

            try
            {
                int i = 0;
                if (colorPictureBox.Enabled && colorPictureBox.Image != null)
                {
                    MagickImage colorImage = new MagickImage(ImageToByteArray(colorPictureBox.Image));
                    if (SelectedWeapon == "Archer" || SelectedWeapon == "SMR" || SelectedWeapon == "DoubleTake" || (SelectedGame == "Titanfall2" && SelectedWeapon == "Volt")  || SelectedWeapon == "Jack_gauntlet"|| SelectedWeapon == "BroadSword" || SelectedWeapon == "ThermiteLauncher")
                    {
                        //program not responding
                        SaveTexture(SelectedWeapon + "_Default_col.dds", colorImage, zipArchive, BCnEncoder.Shared.CompressionFormat.Bc7);
                    }
                    else if (SelectedWeapon == "PhaseShift_fbody" || SelectedWeapon == "PhaseShift_gear" || SelectedWeapon == "PhaseShift_helmet" || SelectedWeapon == "PhaseShift_jumpkit" || SelectedWeapon == "PhaseShift_hair" || SelectedWeapon == "PhaseShift_viewhand" || SelectedWeapon == "PhaseShift_mbody" || SelectedWeapon == "Grapple_fbody" || SelectedWeapon == "Grapple_gear" || SelectedWeapon == "Grapple_helmet" || SelectedWeapon == "Grapple_jumpkit" || SelectedWeapon == "Grapple_gauntlet" || SelectedWeapon == "Grapple_mbody" || SelectedWeapon == "PulseBlade_fbody" || SelectedWeapon == "PulseBlade_gear" || SelectedWeapon == "PulseBlade_helmet" || SelectedWeapon == "PulseBlade_jumpkit" || SelectedWeapon == "PulseBlade_gauntlet" || SelectedWeapon == "PulseBlade_mbody" || SelectedWeapon == "HoloPilot_fbody" || SelectedWeapon == "HoloPilot_gear" || SelectedWeapon == "HoloPilot_helmet" || SelectedWeapon == "HoloPilot_jumpkit" || SelectedWeapon == "HoloPilot_viewhands" || SelectedWeapon == "HoloPilot_mbody" || SelectedWeapon == "Cloak_fbody" || SelectedWeapon == "Cloak_gear" || SelectedWeapon == "Cloak_helmet" || SelectedWeapon == "Cloak_jumpkit" || SelectedWeapon == "Cloak_gauntlet" || SelectedWeapon == "Cloak_mbody" || SelectedWeapon == "Cloak_ghillie" || SelectedWeapon == "AWall_fbody" || SelectedWeapon == "AWall_gear" || SelectedWeapon == "AWall_helmet" || SelectedWeapon == "AWall_jumpkit" || SelectedWeapon == "AWall_gauntlet" || SelectedWeapon == "AWall_mbody" || SelectedWeapon == "Stim_fbody" || SelectedWeapon == "Stim_gear" || SelectedWeapon == "Stim_fgear" || SelectedWeapon == "Stim_head" || SelectedWeapon == "Stim_jumpkit" || SelectedWeapon == "Stim_fjumpkit" || SelectedWeapon == "Stim_gauntlet" || SelectedWeapon == "Stim_mbody"  || SelectedWeapon == "Jack_gauntlet")
                    {
                        colorImage.SetCompression(CompressionMethod.DXT1);
                        SaveTexture(SelectedWeapon + "_col.dds", colorImage, zipArchive);
                    }
                    else
                    {
                        colorImage.SetCompression(CompressionMethod.DXT1);
                        SaveTexture(SelectedWeapon + "_Default_col.dds", colorImage, zipArchive, BCnEncoder.Shared.CompressionFormat.Rgba);
                    }
                    i += 3;
                    progressForm?.AdvanceEntry(i);
                }

                if (specularPictureBox.Enabled && specularPictureBox.Image != null)
                {
                    MagickImage specularImage = new MagickImage(ImageToByteArray(specularPictureBox.Image));
                    if (SelectedWeapon == "DoubleTake" || (SelectedGame == "Titanfall2" && SelectedWeapon == "Volt") || SelectedWeapon == "BroadSword" || SelectedWeapon == "ThermiteLauncher")
                    {
                        //program not responding
                        SaveTexture(SelectedWeapon + "_Default_spc.dds", specularImage, zipArchive, BCnEncoder.Shared.CompressionFormat.Bc7);
                    }
                    else if (SelectedWeapon == "PhaseShift_fbody" || SelectedWeapon == "PhaseShift_gear" || SelectedWeapon == "PhaseShift_helmet" || SelectedWeapon == "PhaseShift_jumpkit" || SelectedWeapon == "PhaseShift_hair" || SelectedWeapon == "PhaseShift_viewhand" || SelectedWeapon == "PhaseShift_mbody" || SelectedWeapon == "Grapple_fbody" || SelectedWeapon == "Grapple_gear" || SelectedWeapon == "Grapple_helmet" || SelectedWeapon == "Grapple_jumpkit" || SelectedWeapon == "Grapple_gauntlet" || SelectedWeapon == "Grapple_mbody" || SelectedWeapon == "PulseBlade_fbody" || SelectedWeapon == "PulseBlade_gear" || SelectedWeapon == "PulseBlade_helmet" || SelectedWeapon == "PulseBlade_jumpkit" || SelectedWeapon == "PulseBlade_gauntlet" || SelectedWeapon == "PulseBlade_mbody" || SelectedWeapon == "HoloPilot_fbody" || SelectedWeapon == "HoloPilot_gear" || SelectedWeapon == "HoloPilot_helmet" || SelectedWeapon == "HoloPilot_jumpkit" || SelectedWeapon == "HoloPilot_viewhands" || SelectedWeapon == "HoloPilot_mbody" || SelectedWeapon == "Cloak_fbody" || SelectedWeapon == "Cloak_gear" || SelectedWeapon == "Cloak_helmet" || SelectedWeapon == "Cloak_jumpkit" || SelectedWeapon == "Cloak_gauntlet" || SelectedWeapon == "Cloak_mbody" || SelectedWeapon == "Cloak_ghillie" || SelectedWeapon == "AWall_fbody" || SelectedWeapon == "AWall_gear" || SelectedWeapon == "AWall_helmet" || SelectedWeapon == "AWall_jumpkit" || SelectedWeapon == "AWall_gauntlet" || SelectedWeapon == "AWall_mbody" || SelectedWeapon == "Stim_fbody" || SelectedWeapon == "Stim_gear" || SelectedWeapon == "Stim_fgear" || SelectedWeapon == "Stim_head" || SelectedWeapon == "Stim_jumpkit" || SelectedWeapon == "Stim_fjumpkit" || SelectedWeapon == "Stim_gauntlet" || SelectedWeapon == "Stim_mbody"  || SelectedWeapon == "Jack_gauntlet")
                    {
                        specularImage.SetCompression(CompressionMethod.DXT1);
                        SaveTexture(SelectedWeapon + "_spc.dds", specularImage, zipArchive);
                    }
                    else
                    {
                        specularImage.SetCompression(CompressionMethod.DXT1);
                        SaveTexture(SelectedWeapon + "_Default_spc.dds", specularImage, zipArchive);
                    }
                    i += 3;
                    progressForm?.AdvanceEntry(i);
                }

                if (normalPictureBox.Enabled && normalPictureBox.Image != null)
                {
                    MagickImage normalImage = new MagickImage(ImageToByteArray(normalPictureBox.Image));
                    //normalImage.Level(new Percentage(100), new Percentage(0), Channels.RGB);
                    if (SelectedWeapon == "PhaseShift_fbody" || SelectedWeapon == "PhaseShift_gear" || SelectedWeapon == "PhaseShift_helmet" || SelectedWeapon == "PhaseShift_jumpkit" || SelectedWeapon == "PhaseShift_hair" || SelectedWeapon == "PhaseShift_viewhand" || SelectedWeapon == "PhaseShift_mbody" || SelectedWeapon == "Grapple_fbody" || SelectedWeapon == "Grapple_gear" || SelectedWeapon == "Grapple_helmet" || SelectedWeapon == "Grapple_jumpkit" || SelectedWeapon == "Grapple_gauntlet" || SelectedWeapon == "Grapple_mbody" || SelectedWeapon == "PulseBlade_fbody" || SelectedWeapon == "PulseBlade_gear" || SelectedWeapon == "PulseBlade_helmet" || SelectedWeapon == "PulseBlade_jumpkit" || SelectedWeapon == "PulseBlade_gauntlet" || SelectedWeapon == "PulseBlade_mbody" || SelectedWeapon == "HoloPilot_fbody" || SelectedWeapon == "HoloPilot_gear" || SelectedWeapon == "HoloPilot_helmet" || SelectedWeapon == "HoloPilot_jumpkit" || SelectedWeapon == "HoloPilot_viewhands" || SelectedWeapon == "HoloPilot_mbody" || SelectedWeapon == "Cloak_fbody" || SelectedWeapon == "Cloak_gear" || SelectedWeapon == "Cloak_helmet" || SelectedWeapon == "Cloak_jumpkit" || SelectedWeapon == "Cloak_gauntlet" || SelectedWeapon == "Cloak_mbody" || SelectedWeapon == "Cloak_ghillie" || SelectedWeapon == "AWall_fbody" || SelectedWeapon == "AWall_gear" || SelectedWeapon == "AWall_helmet" || SelectedWeapon == "AWall_jumpkit" || SelectedWeapon == "AWall_gauntlet" || SelectedWeapon == "AWall_mbody" || SelectedWeapon == "Stim_fbody" || SelectedWeapon == "Stim_gear" || SelectedWeapon == "Stim_fgear" || SelectedWeapon == "Stim_head" || SelectedWeapon == "Stim_jumpkit" || SelectedWeapon == "Stim_fjumpkit" || SelectedWeapon == "Stim_gauntlet" || SelectedWeapon == "Stim_mbody"  || SelectedWeapon == "Jack_gauntlet")
                    {
                    SaveTexture(SelectedWeapon + "_nml.dds", normalImage, zipArchive, BCnEncoder.Shared.CompressionFormat.Bc5);
                    }
                    else
                    {
                    SaveTexture(SelectedWeapon + "_Default_nml.dds", normalImage, zipArchive, BCnEncoder.Shared.CompressionFormat.Bc5);
                    }
                    i += 3;
                    progressForm?.AdvanceEntry(i);
                }

                if (glossinessPictureBox.Enabled && glossinessPictureBox.Image != null)
                {
                    MagickImage glossinessImage = new MagickImage(ImageToByteArray(glossinessPictureBox.Image));
                     if (SelectedWeapon == "PhaseShift_fbody" || SelectedWeapon == "PhaseShift_gear" || SelectedWeapon == "PhaseShift_helmet" || SelectedWeapon == "PhaseShift_jumpkit" || SelectedWeapon == "PhaseShift_hair" || SelectedWeapon == "PhaseShift_viewhand" || SelectedWeapon == "PhaseShift_mbody" || SelectedWeapon == "Grapple_fbody" || SelectedWeapon == "Grapple_gear" || SelectedWeapon == "Grapple_helmet" || SelectedWeapon == "Grapple_jumpkit" || SelectedWeapon == "Grapple_gauntlet" || SelectedWeapon == "Grapple_mbody" || SelectedWeapon == "PulseBlade_fbody" || SelectedWeapon == "PulseBlade_gear" || SelectedWeapon == "PulseBlade_helmet" || SelectedWeapon == "PulseBlade_jumpkit" || SelectedWeapon == "PulseBlade_gauntlet" || SelectedWeapon == "PulseBlade_mbody" || SelectedWeapon == "HoloPilot_fbody" || SelectedWeapon == "HoloPilot_gear" || SelectedWeapon == "HoloPilot_helmet" || SelectedWeapon == "HoloPilot_jumpkit" || SelectedWeapon == "HoloPilot_viewhands" || SelectedWeapon == "HoloPilot_mbody" || SelectedWeapon == "Cloak_fbody" || SelectedWeapon == "Cloak_gear" || SelectedWeapon == "Cloak_helmet" || SelectedWeapon == "Cloak_jumpkit" || SelectedWeapon == "Cloak_gauntlet" || SelectedWeapon == "Cloak_mbody" || SelectedWeapon == "Cloak_ghillie" || SelectedWeapon == "AWall_fbody" || SelectedWeapon == "AWall_gear" || SelectedWeapon == "AWall_helmet" || SelectedWeapon == "AWall_jumpkit" || SelectedWeapon == "AWall_gauntlet" || SelectedWeapon == "AWall_mbody" || SelectedWeapon == "Stim_fbody" || SelectedWeapon == "Stim_gear" || SelectedWeapon == "Stim_fgear" || SelectedWeapon == "Stim_head" || SelectedWeapon == "Stim_jumpkit" || SelectedWeapon == "Stim_fjumpkit" || SelectedWeapon == "Stim_gauntlet" || SelectedWeapon == "Stim_mbody"  || SelectedWeapon == "Jack_gauntlet")
                    {  
                        SaveTexture(SelectedWeapon + "_gls.dds", glossinessImage, zipArchive, BCnEncoder.Shared.CompressionFormat.Bc4);
                    }
                    else
                    {
                    SaveTexture(SelectedWeapon + "_Default_gls.dds", glossinessImage, zipArchive, BCnEncoder.Shared.CompressionFormat.Bc4);
                    }
                    i += 3;
                    progressForm?.AdvanceEntry(i);
                }

                if (aoPictureBox.Enabled && aoPictureBox.Image != null)
                {
                    MagickImage aoImage = new MagickImage(ImageToByteArray(aoPictureBox.Image));
                    if(SelectedWeapon == "PhaseShift_fbody" || SelectedWeapon == "PhaseShift_gear" || SelectedWeapon == "PhaseShift_helmet" || SelectedWeapon == "PhaseShift_jumpkit" || SelectedWeapon == "PhaseShift_hair" || SelectedWeapon == "PhaseShift_viewhand" || SelectedWeapon == "PhaseShift_mbody" || SelectedWeapon == "Grapple_fbody" || SelectedWeapon == "Grapple_gear" || SelectedWeapon == "Grapple_helmet" || SelectedWeapon == "Grapple_jumpkit" || SelectedWeapon == "Grapple_gauntlet" || SelectedWeapon == "Grapple_mbody" || SelectedWeapon == "PulseBlade_fbody" || SelectedWeapon == "PulseBlade_gear" || SelectedWeapon == "PulseBlade_helmet" || SelectedWeapon == "PulseBlade_jumpkit" || SelectedWeapon == "PulseBlade_gauntlet" || SelectedWeapon == "PulseBlade_mbody" || SelectedWeapon == "HoloPilot_fbody" || SelectedWeapon == "HoloPilot_gear" || SelectedWeapon == "HoloPilot_helmet" || SelectedWeapon == "HoloPilot_jumpkit" || SelectedWeapon == "HoloPilot_viewhands" || SelectedWeapon == "HoloPilot_mbody" || SelectedWeapon == "Cloak_fbody" || SelectedWeapon == "Cloak_gear" || SelectedWeapon == "Cloak_helmet" || SelectedWeapon == "Cloak_jumpkit" || SelectedWeapon == "Cloak_gauntlet" || SelectedWeapon == "Cloak_mbody" || SelectedWeapon == "Cloak_ghillie" || SelectedWeapon == "AWall_fbody" || SelectedWeapon == "AWall_gear" || SelectedWeapon == "AWall_helmet" || SelectedWeapon == "AWall_jumpkit" || SelectedWeapon == "AWall_gauntlet" || SelectedWeapon == "AWall_mbody" || SelectedWeapon == "Stim_fbody" || SelectedWeapon == "Stim_gear" || SelectedWeapon == "Stim_fgear" || SelectedWeapon == "Stim_head" || SelectedWeapon == "Stim_jumpkit" || SelectedWeapon == "Stim_fjumpkit" || SelectedWeapon == "Stim_gauntlet" || SelectedWeapon == "Stim_mbody"  || SelectedWeapon == "Jack_gauntlet")
                    {
                        aoImage.SetCompression(CompressionMethod.DXT1);
                        SaveTexture(SelectedWeapon + "_ao.dds", aoImage, zipArchive);
                    }
                    else if (SelectedGame == "Titanfall2")
                    {
                        aoImage.SetCompression(CompressionMethod.DXT1);
                        SaveTexture(SelectedWeapon + "_Default_ao.dds", aoImage, zipArchive);
                    }
                    else if (SelectedGame == "Titanfall2" && SelectedWeapon == "Northstar")//program not responding
                    {
                        SaveTexture(SelectedWeapon + "_Default_ao.dds", aoImage, zipArchive, BCnEncoder.Shared.CompressionFormat.Bc7);
                    }
                    else
                    {
                        SaveTexture(SelectedWeapon + "_Default_ao.dds", aoImage, zipArchive, BCnEncoder.Shared.CompressionFormat.Bc4);
                    }
                    i += 3;
                    progressForm?.AdvanceEntry(i);
                }

                if (cavityPictureBox.Enabled && cavityPictureBox.Image != null)
                {
                    MagickImage cavityImage = new MagickImage(ImageToByteArray(cavityPictureBox.Image));
                    if (SelectedWeapon == "PhaseShift_fbody" || SelectedWeapon == "PhaseShift_gear" || SelectedWeapon == "PhaseShift_helmet" || SelectedWeapon == "PhaseShift_jumpkit" || SelectedWeapon == "PhaseShift_hair" || SelectedWeapon == "PhaseShift_viewhand" || SelectedWeapon == "PhaseShift_mbody" || SelectedWeapon == "Grapple_fbody" || SelectedWeapon == "Grapple_gear" || SelectedWeapon == "Grapple_helmet" || SelectedWeapon == "Grapple_jumpkit" || SelectedWeapon == "Grapple_gauntlet" || SelectedWeapon == "Grapple_mbody" || SelectedWeapon == "PulseBlade_fbody" || SelectedWeapon == "PulseBlade_gear" || SelectedWeapon == "PulseBlade_helmet" || SelectedWeapon == "PulseBlade_jumpkit" || SelectedWeapon == "PulseBlade_gauntlet" || SelectedWeapon == "PulseBlade_mbody" || SelectedWeapon == "HoloPilot_fbody" || SelectedWeapon == "HoloPilot_gear" || SelectedWeapon == "HoloPilot_helmet" || SelectedWeapon == "HoloPilot_jumpkit" || SelectedWeapon == "HoloPilot_viewhands" || SelectedWeapon == "HoloPilot_mbody" || SelectedWeapon == "Cloak_fbody" || SelectedWeapon == "Cloak_gear" || SelectedWeapon == "Cloak_helmet" || SelectedWeapon == "Cloak_jumpkit" || SelectedWeapon == "Cloak_gauntlet" || SelectedWeapon == "Cloak_mbody" || SelectedWeapon == "Cloak_ghillie" || SelectedWeapon == "AWall_fbody" || SelectedWeapon == "AWall_gear" || SelectedWeapon == "AWall_helmet" || SelectedWeapon == "AWall_jumpkit" || SelectedWeapon == "AWall_gauntlet" || SelectedWeapon == "AWall_mbody" || SelectedWeapon == "Stim_fbody" || SelectedWeapon == "Stim_gear" || SelectedWeapon == "Stim_fgear" || SelectedWeapon == "Stim_head" || SelectedWeapon == "Stim_jumpkit" || SelectedWeapon == "Stim_fjumpkit" || SelectedWeapon == "Stim_gauntlet" || SelectedWeapon == "Stim_mbody"  || SelectedWeapon == "Jack_gauntlet")
                    {
                        cavityImage.SetCompression(CompressionMethod.DXT1);
                        SaveTexture(SelectedWeapon + "_cav.dds", cavityImage, zipArchive);
                    }
                    else if (SelectedGame == "Titanfall2")
                    {
                        cavityImage.SetCompression(CompressionMethod.DXT1);
                        SaveTexture(SelectedWeapon + "_Default_cav.dds", cavityImage, zipArchive);
                    }
                    /*
                    else if (SelectedGame == "Titanfall2" && SelectedWeapon == "Northstar")//program not responding
                    {
                        SaveTexture(SelectedWeapon + "_Default_cav.dds", cavityImage, zipArchive, BCnEncoder.Shared.CompressionFormat.Bc7);
                    }
                    */
                    else
                    {
                        SaveTexture(SelectedWeapon + "_Default_cav.dds", cavityImage, zipArchive, BCnEncoder.Shared.CompressionFormat.Bc4);
                    }
                    i += 3;
                    progressForm?.AdvanceEntry(i);
                }
                /*
                if (cavityPictureBox.Enabled && cavityPictureBox.Image != null)
                {
                    MagickImage cavityImage = new MagickImage(ImageToByteArray(cavityPictureBox.Image));
                    if (SelectedGame == "Titanfall2")
                    {
                        cavityImage.SetCompression(CompressionMethod.DXT1);
                        SaveTexture(SelectedWeapon + "_Default_cav.dds", cavityImage, zipArchive);
                    }
                    else if (SelectedGame == "Titanfall2" && SelectedWeapon == "Northstar")//program not responding
                    {
                        SaveTexture(SelectedWeapon + "_Default_cav.dds", cavityImage, zipArchive, BCnEncoder.Shared.CompressionFormat.Bc7);
                    }
                    else
                    {
                        SaveTexture(SelectedWeapon + "_Default_cav.dds", cavityImage, zipArchive, BCnEncoder.Shared.CompressionFormat.Bc4);
                    }
                    i += 3;
                    progressForm?.AdvanceEntry(i);
                }
                */

                 if (illuminationPictureBox.Enabled && illuminationPictureBox.Image != null)
                {
                    MagickImage illuminationImage = new MagickImage(ImageToByteArray(illuminationPictureBox.Image));
                    if (SelectedWeapon == "Northstar" || SelectedWeapon == "ION")//program not responding
                    {
                        SaveTexture(SelectedWeapon + "_Default_ilm.dds", illuminationImage, zipArchive, BCnEncoder.Shared.CompressionFormat.Bc7);
                    }
                    else if (SelectedWeapon == "PhaseShift_fbody" || SelectedWeapon == "PhaseShift_gear" || SelectedWeapon == "PhaseShift_helmet" || SelectedWeapon == "PhaseShift_jumpkit" || SelectedWeapon == "PhaseShift_hair" || SelectedWeapon == "PhaseShift_viewhand" || SelectedWeapon == "PhaseShift_mbody" || SelectedWeapon == "Grapple_fbody" || SelectedWeapon == "Grapple_gear" || SelectedWeapon == "Grapple_helmet" || SelectedWeapon == "Grapple_jumpkit" || SelectedWeapon == "Grapple_gauntlet" || SelectedWeapon == "Grapple_mbody" || SelectedWeapon == "PulseBlade_fbody" || SelectedWeapon == "PulseBlade_gear" || SelectedWeapon == "PulseBlade_helmet" || SelectedWeapon == "PulseBlade_jumpkit" || SelectedWeapon == "PulseBlade_gauntlet" || SelectedWeapon == "PulseBlade_mbody" || SelectedWeapon == "HoloPilot_fbody" || SelectedWeapon == "HoloPilot_gear" || SelectedWeapon == "HoloPilot_helmet" || SelectedWeapon == "HoloPilot_jumpkit" || SelectedWeapon == "HoloPilot_viewhands" || SelectedWeapon == "HoloPilot_mbody" || SelectedWeapon == "Cloak_fbody" || SelectedWeapon == "Cloak_gear" || SelectedWeapon == "Cloak_helmet" || SelectedWeapon == "Cloak_jumpkit" || SelectedWeapon == "Cloak_gauntlet" || SelectedWeapon == "Cloak_mbody" || SelectedWeapon == "Cloak_ghillie" || SelectedWeapon == "AWall_fbody" || SelectedWeapon == "AWall_gear" || SelectedWeapon == "AWall_helmet" || SelectedWeapon == "AWall_jumpkit" || SelectedWeapon == "AWall_gauntlet" || SelectedWeapon == "AWall_mbody" || SelectedWeapon == "Stim_fbody" || SelectedWeapon == "Stim_gear" || SelectedWeapon == "Stim_fgear" || SelectedWeapon == "Stim_head" || SelectedWeapon == "Stim_jumpkit" || SelectedWeapon == "Stim_fjumpkit" || SelectedWeapon == "Stim_gauntlet" || SelectedWeapon == "Stim_mbody"  || SelectedWeapon == "Jack_gauntlet")
                    {
                    illuminationImage.SetCompression(CompressionMethod.DXT1);
                    SaveTexture(SelectedWeapon + "_ilm.dds", illuminationImage, zipArchive);
                    }

                    else
					{
                    illuminationImage.SetCompression(CompressionMethod.DXT1);
                    SaveTexture(SelectedWeapon + "_Default_ilm.dds", illuminationImage, zipArchive);
					}
                    i += 3;
                    progressForm?.AdvanceEntry(i);
                }

                MessageBox.Show(rm.GetString("GenerateSuccess"), rm.GetString("Generate"), MessageBoxButtons.OK);
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
            switch (Info.Width)
            {
                case 4096:
                    WidthCheck = 0;
                    HightCheck = 0;
                    break;
                case 2048:
                    WidthCheck = 1;
                    HightCheck = 1;
                    break;
                case 1024:
                    WidthCheck = 2;
                    HightCheck = 2;
                    break;
                case 512:
                    WidthCheck = 3;
                    HightCheck = 3;
                    break;
            }
            if (Info.Width != Info.Height)
            {
                HightCheck++;
            }

            for (int i = WidthCheck, j = HightCheck; i <= 3; i++, j++)
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
                    ImageNumber += 3;
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
            ImageNumber = 0;
            if (SelectedGame == "APEX")
            {
                switch (SelectedWeapon)
                {
                    case "ChargeRifle":
                        {
                            EnableTexture(colorPictureBox);
                            EnableTexture(normalPictureBox);
                            EnableTexture(glossinessPictureBox);
                            EnableTexture(specularPictureBox);
                            break;
                        }
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
                    case "Sword":
                    case "Kunai":
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
                    case "AcogSight":
                    case "AogSight":
                    case "SniperScope":
                    case "SniperScopeX4":
                    case "ThreatScopeSniper":
                        {
                            EnableTexture(colorPictureBox);
                            EnableTexture(normalPictureBox);
                            EnableTexture(glossinessPictureBox);
                            EnableTexture(specularPictureBox);
                            EnableTexture(aoPictureBox);
                            EnableTexture(cavityPictureBox);
                            break;
                        }
                    case "HoloReflexSight":
                        {
                            EnableTexture(colorPictureBox);
                            EnableTexture(normalPictureBox);
                            EnableTexture(glossinessPictureBox);
                            EnableTexture(specularPictureBox);
                            break;
                        }
                    case "Supressor":
                        {
                            EnableTexture(colorPictureBox);
                            EnableTexture(normalPictureBox);
                            EnableTexture(glossinessPictureBox);
                            EnableTexture(specularPictureBox);
                            EnableTexture(aoPictureBox);
                            break;
                        }
                        //Titans
                    case "ION":
                    case "Ronin":
                        {
                            EnableTexture(normalPictureBox);
                            EnableTexture(glossinessPictureBox);
                            EnableTexture(illuminationPictureBox);
                            EnableTexture(aoPictureBox);
                            EnableTexture(cavityPictureBox);
                            break;
                        }
                    case "Northstar":
                        {
                            EnableTexture(normalPictureBox);
                            EnableTexture(glossinessPictureBox);
                            break;
                        }
                        //Titans with all default compression
                    //case "ION":
                    case "Legion":
                    case "Scorch":
                    //case "Northstar":
                    //case "Ronin":
                    case "Tone":
                    case "Monarch":
                    case "PrimeION":
                    case "PrimeLegion":
                    case "PrimeNorthstar":
                    case "PrimeRonin":
                    case "PrimeScorch":
                    case "PrimeTone":
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
                        //pilot parts
                    //PhaseShift
                    case "PhaseShift_fbody":
                    case "PhaseShift_mbody":
                    case "PhaseShift_hair":
                    case "PhaseShift_jumpkit":
                    case "PhaseShift_gear":
                    case "PhaseShift_helmet": 
                    case "PhaseShift_viewhand":
                    //Grapple
                    case "Grapple_fbody":
                    case "Grapple_mbody":
                    case "Grapple_jumpkit":
                    case "Grapple_gear":
                    case "Grapple_helmet": 
                    case "Grapple_gauntlet":
                    //Pulse
                    case "PulseBlade_fbody":
                    case "PulseBlade_mbody":
                    case "PulseBlade_jumpkit":
                    case "PulseBlade_gear":
                    case "PulseBlade_helmet": 
                    case "PulseBlade_gauntlet":
                    //HoloPilot
                    case "HoloPilot_fbody":
                    case "HoloPilot_mbody":
                    case "HoloPilot_jumpkit":
                    case "HoloPilot_gear":
                    case "HoloPilot_helmet": 
                    case "HoloPilot_viewhands":
                    //CloakPilot
                    case "Cloak_fbody":
                    case "Cloak_mbody":
                    case "Cloak_jumpkit":
                    case "Cloak_gear":
                    case "Cloak_helmet": 
                    case "Cloak_gauntlet":
                    case "Cloak_ghillie":
					//StimPilot
                    case "Stim_fbody":
                    case "Stim_mbody":
                    case "Stim_jumpkit":
					case "Stim_fjumpkit":
                    case "Stim_gear":
					case "Stim_fgear":
                    case "Stim_head": 
                    case "Stim_gauntlet":
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
                        //Wall+Pilot
                        //Textures that are not showing here using BC7U aka DX10
                    case "AWall_fbody":
                    case "AWall_mbody":
                    case "AWall_jumpkit":
                    case "AWall_gear":
                    case "AWall_helmet": 
                    case "AWall_gauntlet":
                    case "AWall_ghillie":
                        {
                            EnableTexture(normalPictureBox);
                            EnableTexture(glossinessPictureBox);
                            EnableTexture(illuminationPictureBox);
                            break;
                        }
                    case "JackHandL":
                        {
                            EnableTexture(normalPictureBox);
                            EnableTexture(glossinessPictureBox);
                            EnableTexture(specularPictureBox);
                            EnableTexture(illuminationPictureBox);
                            EnableTexture(aoPictureBox);
                            EnableTexture(cavityPictureBox);
                            break;
                        }
                    case "JackHandR":
                        {
                            EnableTexture(colorPictureBox);
                            break;
                        }
                    case "PrimeSword":
                        {
                            EnableTexture(colorPictureBox);
                            EnableTexture(normalPictureBox);
                            EnableTexture(glossinessPictureBox);
                            EnableTexture(specularPictureBox);
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
                    case "Hcog":
                    case "ProScreen":
                    case "ThreatScope":
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
                        //突击步枪
                        rm.GetString("tip1"),
                        rm.GetString("Items"),
                        rm.GetString("Items1"),
                        rm.GetString("Items2"),
                        rm.GetString("Items3"),
                        //冲锋枪
                        rm.GetString("tip2"),
                        rm.GetString("Items5"),
                        rm.GetString("Items6"),
                        rm.GetString("Items7"),
                        rm.GetString("Items8"),
                        //轻机枪
                        rm.GetString("tip5"),
                        rm.GetString("Items10"),
                        rm.GetString("Items11"),
                        rm.GetString("Items9"),
                        //神射手
                        rm.GetString("tip13"),
                        rm.GetString("Items12"),
                        rm.GetString("Items15"),
                        //狙击枪
                        rm.GetString("tip4"),
                        rm.GetString("Items13"),
                        rm.GetString("Items14"),
                        rm.GetString("Items4"),
                        //散弹枪
                        rm.GetString("tip3"),
                        rm.GetString("Items16"),
                        rm.GetString("Items17"),
                        rm.GetString("Items18"),
                        rm.GetString("Items19"),
                        //手枪
                        rm.GetString("tip9"),
                        rm.GetString("Items20"),
                        rm.GetString("Items21"),
                        rm.GetString("Items22"),
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
                        rm.GetString("Items127"),
                        //近战武器
                        rm.GetString("tip12"),
                        rm.GetString("Items52"),
                        rm.GetString("Items53"),
                        //武器附件
                        rm.GetString("tip15"),
                        rm.GetString("Items56"),
                        rm.GetString("Items57"),
                        rm.GetString("Items58"),
                        rm.GetString("Items59"),
                        rm.GetString("Items60"),
                        rm.GetString("Items61"),
                        rm.GetString("Items62"),
                        rm.GetString("Items63"),
                        rm.GetString("Items64"),
                        rm.GetString("Items65"),
                        //泰坦皮肤
                        rm.GetString("tip16"),
                        rm.GetString("Items66"),
                        rm.GetString("Items67"),
                        rm.GetString("Items68"),
                        rm.GetString("Items69"),
                        rm.GetString("Items70"),
                        rm.GetString("Items71"),
                        rm.GetString("Items72"),
                        //Prime泰坦皮肤
                        rm.GetString("tip17"),
                        rm.GetString("Items73"),
                        rm.GetString("Items74"),
                        rm.GetString("Items75"),
                        rm.GetString("Items76"),
                        rm.GetString("Items77"),
                        rm.GetString("Items78"),
                        //PhaseShiftPilot Parts
                        rm.GetString("tip18"),
                        rm.GetString("Items79"),
                        rm.GetString("Items80"),
                        rm.GetString("Items81"),
                        rm.GetString("Items82"),
                        rm.GetString("Items83"),
                        rm.GetString("Items84"),
                        rm.GetString("Items85"),
                        //GrapplePilot Parts
                        rm.GetString("tip19"),
                        rm.GetString("Items86"),
                        rm.GetString("Items87"),
                        rm.GetString("Items88"),
                        rm.GetString("Items89"),
                        rm.GetString("Items90"),
                        rm.GetString("Items91"),
                        //PulsePilot Parts
                        rm.GetString("tip20"),
                        rm.GetString("Items92"),
                        rm.GetString("Items93"),
                        rm.GetString("Items94"),
                        rm.GetString("Items95"),
                        rm.GetString("Items96"),
                        rm.GetString("Items97"),
                        //HoloPilot Parts
                        rm.GetString("tip21"),
                        rm.GetString("Items98"),
                        rm.GetString("Items99"),
                        rm.GetString("Items100"),
                        rm.GetString("Items101"),
                        rm.GetString("Items102"),
                        rm.GetString("Items103"),
                        //CloakPilot Parts
                        rm.GetString("tip22"),
                        rm.GetString("Items104"),
                        rm.GetString("Items105"),
                        rm.GetString("Items106"),
                        rm.GetString("Items107"),
                        rm.GetString("Items108"),
                        rm.GetString("Items109"),
						rm.GetString("Items110"),
                        //Wall+Pilot Parts
                        rm.GetString("tip23"),
                        rm.GetString("Items111"),
                        rm.GetString("Items112"),
                        rm.GetString("Items113"),
                        rm.GetString("Items114"),
                        rm.GetString("Items115"),
                        rm.GetString("Items116"),
                        //StimPilot Parts
                        rm.GetString("tip24"),
                        rm.GetString("Items117"),
                        rm.GetString("Items118"),
                        rm.GetString("Items119"),
                        rm.GetString("Items120"),
                        rm.GetString("Items121"),
                        rm.GetString("Items122"),
                        rm.GetString("Items123"),
                        rm.GetString("Items124"),
                        //Jack Cooper Hands LOL
                        rm.GetString("tip25"),
                        rm.GetString("Items125"),
                        rm.GetString("Items126"),
                        //泰坦
                        //Need add new panel for both titan and pilot
                        /*rm.GetString("tip14"),
                        rm.GetString("Items54"),
                        rm.GetString("Items55"),*/
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
                case "浪人大剑":
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
                case "Pilot Sword":
                case "铁驭剑":
                    SelectedWeapon = "Sword";
                    break;
                case "Kunai":
                case "苦无":
                    SelectedWeapon = "Kunai";
                    break;
                case "Cockpit":
                case "驾驶舱":
                    SelectedWeapon = "Cockpit";
                    break;
                case "Console":
                case "控制台":
                    SelectedWeapon = "Console";
                    break;
                case "AcogSight":
                case "ACOG视镜":
                    SelectedWeapon = "AcogSight";
                    break;
                case "AogSight":
                case "进阶视镜":
                    SelectedWeapon = "AogSight";
                    break;
                case "Hcog":
                case "全像进阶战斗视镜":
                    SelectedWeapon = "Hcog";
                    break;
                case "HoloReflexSight":
                case "全像视镜":
                    SelectedWeapon = "HoloReflexSight";
                    break;
                case "ProScreen":
                case "击杀计数器":
                    SelectedWeapon = "ProScreen";
                    break;
                case "SniperScope":
                case "狙击镜":
                    SelectedWeapon = "SniperScope";
                    break;
                case "SniperScopeX4":
                case "4倍狙击镜":
                    SelectedWeapon = "SniperScopeX4";
                    break;
                case "Supressor":
                case "消音器":
                    SelectedWeapon = "Supressor";
                    break;
                case "ThreatScope":
                case "主武器威胁视镜":
                    SelectedWeapon = "ThreatScope";
                    break;
                case "ThreatScopeSniper":
                case "狙击步枪威胁视镜":
                    SelectedWeapon = "ThreatScopeSniper";
                    break;  
                case "ION":
                case "离子":
                    SelectedWeapon = "ION";
                    break;  
                case "Legion":
                case "军团":
                    SelectedWeapon = "Legion";
                    break;  
                case "Scorch":
                case "烈焰":
                    SelectedWeapon = "Scorch";
                    break;  
                case "Northstar":
                case "北极星":
                    SelectedWeapon = "Northstar";
                    break; 
                case "Ronin":
                case "浪人":
                    SelectedWeapon = "Ronin";
                    break; 
                case "Tone":
                case "强力":
                    SelectedWeapon = "Tone";
                    break; 
                case "Monarch":
                case "帝王":
                    SelectedWeapon = "Monarch";
                    break;
                case "PrimeLegion":
                case "至尊军团":
                    SelectedWeapon = "PrimeLegion";
                    break;
                case "PrimeNorthstar":
                case "至尊北极星":
                    SelectedWeapon = "PrimeNorthstar";
                    break;
                case "PrimeION":
                case "至尊离子":
                    SelectedWeapon = "PrimeION";
                    break;
                case "PrimeRonin":
                case "至尊浪人":
                    SelectedWeapon = "PrimeRonin";
                    break;
                case "PrimeScorch":
                case "至尊烈焰":
                    SelectedWeapon = "PrimeScorch";
                    break;
                case "PrimeTone":
                case "至尊强力":
                    SelectedWeapon = "PrimeTone";
                    break;
                case "PhaseShift_fbody":
                case "相位铁驭_女性身体":
                    SelectedWeapon = "PhaseShift_fbody";
                    break;
                case "PhaseShift_mbody":
                case "相位铁驭_男性身体":
                    SelectedWeapon = "PhaseShift_mbody";
                    break;
                case "PhaseShift_hair":
                case "相位铁驭_头发":
                    SelectedWeapon = "PhaseShift_hair";
                    break;
                case "PhaseShift_gear":
                case "相位铁驭_配件":
                    SelectedWeapon = "PhaseShift_gear";
                    break;
                case "PhaseShift_jumpkit":
                case "相位铁驭_跳跃装置":
                    SelectedWeapon = "PhaseShift_jumpkit";
                    break;
                case "PhaseShift_helmet":
                case "相位铁驭_头盔":
                    SelectedWeapon = "PhaseShift_helmet";
                    break;
                case "PhaseShift_viewhand":
                case "相位铁驭_手部":
                    SelectedWeapon = "PhaseShift_viewhand";
                    break;
                case "Grapple_fbody":
                case "钩爪铁驭_女性身体":
                    SelectedWeapon = "Grapple_fbody";
                    break;
                case "Grapple_mbody":
                case "钩爪铁驭_男性身体":
                    SelectedWeapon = "Grapple_mbody";
                    break;
                case "Grapple_gauntlet":
                case "钩爪铁驭_手套":
                    SelectedWeapon = "Grapple_gauntlet";
                    break;
                case "Grapple_gear":
                case "钩爪铁驭_配件":
                    SelectedWeapon = "Grapple_gear";
                    break;
                case "Grapple_jumpkit":
                case "钩爪铁驭_跳跃装置":
                    SelectedWeapon = "Grapple_jumpkit";
                    break;
                case "Grapple_helmet":
                case "钩爪铁驭_头盔":
                    SelectedWeapon = "Grapple_helmet";
                    break;
                case "PulseBlade_fbody":
                case "脉冲刀铁驭_女性身体":
                    SelectedWeapon = "PulseBlade_fbody";
                    break;
                case "PulseBlade_mbody":
                case "脉冲刀铁驭_男性身体":
                    SelectedWeapon = "PulseBlade_mbody";
                    break;
                case "PulseBlade_gauntlet":
                case "脉冲刀铁驭_手套":
                    SelectedWeapon = "PulseBlade_gauntlet";
                    break;
                case "PulseBlade_gear":
                case "脉冲刀铁驭_配件":
                    SelectedWeapon = "PulseBlade_gear";
                    break;
                case "PulseBlade_jumpkit":
                case "脉冲刀铁驭_跳跃装置":
                    SelectedWeapon = "PulseBlade_jumpkit";
                    break;
                case "PulseBlade_helmet":
                case "脉冲刀铁驭_头盔":
                    SelectedWeapon = "PulseBlade_helmet";
                    break;
                case "HoloPilot_fbody":
                case "幻影铁驭_女性身体":
                    SelectedWeapon = "HoloPilot_fbody";
                    break;
                case "HoloPilot_mbody":
                case "幻影铁驭_男性身体":
                    SelectedWeapon = "HoloPilot_mbody";
                    break;
                case "HoloPilot_viewhands":
                case "幻影铁驭_手部":
                    SelectedWeapon = "HoloPilot_viewhands";
                    break;
                case "HoloPilot_gear":
                case "幻影铁驭_配件":
                    SelectedWeapon = "HoloPilot_gear";
                    break;
                case "HoloPilot_jumpkit":
                case "幻影铁驭_跳跃装置":
                    SelectedWeapon = "HoloPilot_jumpkit";
                    break;
                case "HoloPilot_helmet":
                case "幻影铁驭_头盔":
                    SelectedWeapon = "HoloPilot_helmet";
                    break;
                case "Cloak_fbody":
                case "隐身铁驭_女性身体":
                    SelectedWeapon = "Cloak_fbody";
                    break;
                case "Cloak_mbody":
                case "隐身铁驭_男性身体":
                    SelectedWeapon = "Cloak_mbody";
                    break;
                case "Cloak_gauntlet":
                case "隐身铁驭_手套":
                    SelectedWeapon = "Cloak_gauntlet";
                    break;
                case "Cloak_gear":
                case "隐身铁驭_配件":
                    SelectedWeapon = "Cloak_gear";
                    break;
                case "Cloak_jumpkit":
                case "隐身铁驭_跳跃装置":
                    SelectedWeapon = "Cloak_jumpkit";
                    break;
                case "Cloak_helmet":
                case "隐身铁驭_头盔":
                    SelectedWeapon = "Cloak_helmet";
                    break;
                case "Cloak_ghillie":
                case "隐身铁驭_吉利服":
                    SelectedWeapon = "Cloak_ghillie";
                    break;
                case "AWall_fbody":
                case "A盾铁驭_女性身体":
                    SelectedWeapon = "AWall_fbody";
                    break;
                case "AWall_mbody":
                case "A盾铁驭_男性身体":
                    SelectedWeapon = "AWall_mbody";
                    break;
                case "AWall_gauntlet":
                case "A盾铁驭_手套":
                    SelectedWeapon = "AWall_gauntlet";
                    break;
                case "AWall_gear":
                case "A盾铁驭_配件":
                    SelectedWeapon = "AWall_gear";
                    break;
                case "AWall_jumpkit":
                case "A盾铁驭_跳跃装置":
                    SelectedWeapon = "AWall_jumpkit";
                    break;
                case "AWall_helmet":
                case "A盾铁驭_头盔":
                    SelectedWeapon = "AWall_helmet";
                    break;
                case "Stim_fbody":
                case "兴奋剂铁驭_女性身体":
                    SelectedWeapon = "Stim_fbody";
                    break;
                case "Stim_mbody":
                case "兴奋剂铁驭_男性身体":
                    SelectedWeapon = "Stim_mbody";
                    break;
                case "Stim_gauntlet":
                case "兴奋剂铁驭_手套":
                    SelectedWeapon = "Stim_gauntlet";
                    break;
                case "Stim_gear":
                case "兴奋剂铁驭_男性配件":
                    SelectedWeapon = "Stim_gear";
                    break;
                case "Stim_fgear":
                case "兴奋剂铁驭_女性配件":
                    SelectedWeapon = "Stim_fgear";
                    break;
                case "Stim_jumpkit":
                case "兴奋剂铁驭_男性跳跃装置":
                    SelectedWeapon = "Stim_jumpkit";
                    break;
                case "Stim_fjumpkit":
                case "兴奋剂铁驭_女性跳跃装置":
                    SelectedWeapon = "Stim_fjumpkit";
                    break;
                case "Stim_head":
                case "兴奋剂铁驭_头部":
                    SelectedWeapon = "Stim_head";
                    break;
                    /*
                case "Jack_gauntlet":
                    SelectedWeapon = "Jack_gauntlet";
                    break;
                case "Jack_gauntletr":
                    SelectedWeapon = "Jack_gauntletr";
                    break;
                    */
                case "JackHandL":
                case "杰克_左手手套":
                    SelectedWeapon = "JackHandL";
                    break;
                case "JackHandR":
                case "杰克_右手手套":
                    SelectedWeapon = "JackHandR";
                    break;
                case "PrimeSword":
                case "至尊浪人剑":
                    SelectedWeapon = "PrimeSword";
                    break;
                default:
                    SelectedWeapon = "NULL";
                    break;
            }
        }
    }
}

