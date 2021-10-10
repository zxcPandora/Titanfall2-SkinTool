
namespace Titanfall2_SkinTool
{
    partial class SkinPackMakerWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkinPackMakerWindow));
            this.colorPictureBox = new System.Windows.Forms.PictureBox();
            this.normalPictureBox = new System.Windows.Forms.PictureBox();
            this.glossinessPictureBox = new System.Windows.Forms.PictureBox();
            this.specularPictureBox = new System.Windows.Forms.PictureBox();
            this.texturesSetGroup = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.illuminationPictureBox = new System.Windows.Forms.PictureBox();
            this.cavityPictureBox = new System.Windows.Forms.PictureBox();
            this.aoPictureBox = new System.Windows.Forms.PictureBox();
            this.generalInfoGroup = new System.Windows.Forms.GroupBox();
            this.assetTypeComboBox = new System.Windows.Forms.ComboBox();
            this.openSkinPackPathSelectButton = new System.Windows.Forms.Button();
            this.skinPackPathTextBox = new System.Windows.Forms.TextBox();
            this.skinNameTextBox = new System.Windows.Forms.TextBox();
            this.labelx = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.skinPackPathDialogue = new System.Windows.Forms.FolderBrowserDialog();
            this.generateSkinPackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.colorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glossinessPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specularPictureBox)).BeginInit();
            this.texturesSetGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.illuminationPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cavityPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aoPictureBox)).BeginInit();
            this.generalInfoGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorPictureBox
            // 
            this.colorPictureBox.AllowDrop = true;
            this.colorPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.colorPictureBox, "colorPictureBox");
            this.colorPictureBox.Name = "colorPictureBox";
            this.colorPictureBox.TabStop = false;
            this.colorPictureBox.Click += new System.EventHandler(this.texturePictureBox_NClick);
            this.colorPictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.texturePictureBox_DragDrop);
            this.colorPictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.texturePictureBox_DragEnter);
            this.colorPictureBox.DoubleClick += new System.EventHandler(this.texturePictureBox_NClick);
            this.colorPictureBox.MouseEnter += new System.EventHandler(this.texturePictureBox_MouseEnter);
            // 
            // normalPictureBox
            // 
            this.normalPictureBox.AllowDrop = true;
            this.normalPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.normalPictureBox, "normalPictureBox");
            this.normalPictureBox.Name = "normalPictureBox";
            this.normalPictureBox.TabStop = false;
            this.normalPictureBox.Click += new System.EventHandler(this.texturePictureBox_NClick);
            this.normalPictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.texturePictureBox_DragDrop);
            this.normalPictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.texturePictureBox_DragEnter);
            this.normalPictureBox.DoubleClick += new System.EventHandler(this.texturePictureBox_NClick);
            this.normalPictureBox.MouseEnter += new System.EventHandler(this.texturePictureBox_MouseEnter);
            // 
            // glossinessPictureBox
            // 
            this.glossinessPictureBox.AllowDrop = true;
            this.glossinessPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.glossinessPictureBox, "glossinessPictureBox");
            this.glossinessPictureBox.Name = "glossinessPictureBox";
            this.glossinessPictureBox.TabStop = false;
            this.glossinessPictureBox.Click += new System.EventHandler(this.texturePictureBox_NClick);
            this.glossinessPictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.texturePictureBox_DragDrop);
            this.glossinessPictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.texturePictureBox_DragEnter);
            this.glossinessPictureBox.DoubleClick += new System.EventHandler(this.texturePictureBox_NClick);
            this.glossinessPictureBox.MouseEnter += new System.EventHandler(this.texturePictureBox_MouseEnter);
            // 
            // specularPictureBox
            // 
            this.specularPictureBox.AllowDrop = true;
            this.specularPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.specularPictureBox, "specularPictureBox");
            this.specularPictureBox.Name = "specularPictureBox";
            this.specularPictureBox.TabStop = false;
            this.specularPictureBox.Click += new System.EventHandler(this.texturePictureBox_NClick);
            this.specularPictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.texturePictureBox_DragDrop);
            this.specularPictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.texturePictureBox_DragEnter);
            this.specularPictureBox.DoubleClick += new System.EventHandler(this.texturePictureBox_NClick);
            this.specularPictureBox.MouseEnter += new System.EventHandler(this.texturePictureBox_MouseEnter);
            // 
            // texturesSetGroup
            // 
            this.texturesSetGroup.Controls.Add(this.label7);
            this.texturesSetGroup.Controls.Add(this.label6);
            this.texturesSetGroup.Controls.Add(this.label5);
            this.texturesSetGroup.Controls.Add(this.label8);
            this.texturesSetGroup.Controls.Add(this.label3);
            this.texturesSetGroup.Controls.Add(this.label2);
            this.texturesSetGroup.Controls.Add(this.label4);
            this.texturesSetGroup.Controls.Add(this.illuminationPictureBox);
            this.texturesSetGroup.Controls.Add(this.cavityPictureBox);
            this.texturesSetGroup.Controls.Add(this.aoPictureBox);
            this.texturesSetGroup.Controls.Add(this.colorPictureBox);
            this.texturesSetGroup.Controls.Add(this.normalPictureBox);
            this.texturesSetGroup.Controls.Add(this.glossinessPictureBox);
            this.texturesSetGroup.Controls.Add(this.specularPictureBox);
            resources.ApplyResources(this.texturesSetGroup, "texturesSetGroup");
            this.texturesSetGroup.Name = "texturesSetGroup";
            this.texturesSetGroup.TabStop = false;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // illuminationPictureBox
            // 
            this.illuminationPictureBox.AllowDrop = true;
            this.illuminationPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.illuminationPictureBox, "illuminationPictureBox");
            this.illuminationPictureBox.Name = "illuminationPictureBox";
            this.illuminationPictureBox.TabStop = false;
            this.illuminationPictureBox.Click += new System.EventHandler(this.texturePictureBox_NClick);
            this.illuminationPictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.texturePictureBox_DragDrop);
            this.illuminationPictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.texturePictureBox_DragEnter);
            this.illuminationPictureBox.DoubleClick += new System.EventHandler(this.texturePictureBox_NClick);
            this.illuminationPictureBox.MouseEnter += new System.EventHandler(this.texturePictureBox_MouseEnter);
            // 
            // cavityPictureBox
            // 
            this.cavityPictureBox.AllowDrop = true;
            this.cavityPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.cavityPictureBox, "cavityPictureBox");
            this.cavityPictureBox.Name = "cavityPictureBox";
            this.cavityPictureBox.TabStop = false;
            this.cavityPictureBox.Click += new System.EventHandler(this.texturePictureBox_NClick);
            this.cavityPictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.texturePictureBox_DragDrop);
            this.cavityPictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.texturePictureBox_DragEnter);
            this.cavityPictureBox.DoubleClick += new System.EventHandler(this.texturePictureBox_NClick);
            this.cavityPictureBox.MouseEnter += new System.EventHandler(this.texturePictureBox_MouseEnter);
            // 
            // aoPictureBox
            // 
            this.aoPictureBox.AllowDrop = true;
            this.aoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.aoPictureBox, "aoPictureBox");
            this.aoPictureBox.Name = "aoPictureBox";
            this.aoPictureBox.TabStop = false;
            this.aoPictureBox.Click += new System.EventHandler(this.texturePictureBox_NClick);
            this.aoPictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.texturePictureBox_DragDrop);
            this.aoPictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.texturePictureBox_DragEnter);
            this.aoPictureBox.DoubleClick += new System.EventHandler(this.texturePictureBox_NClick);
            this.aoPictureBox.MouseEnter += new System.EventHandler(this.texturePictureBox_MouseEnter);
            // 
            // generalInfoGroup
            // 
            this.generalInfoGroup.Controls.Add(this.assetTypeComboBox);
            this.generalInfoGroup.Controls.Add(this.openSkinPackPathSelectButton);
            this.generalInfoGroup.Controls.Add(this.skinPackPathTextBox);
            this.generalInfoGroup.Controls.Add(this.skinNameTextBox);
            this.generalInfoGroup.Controls.Add(this.labelx);
            this.generalInfoGroup.Controls.Add(this.pathTextBox);
            this.generalInfoGroup.Controls.Add(this.label1);
            resources.ApplyResources(this.generalInfoGroup, "generalInfoGroup");
            this.generalInfoGroup.Name = "generalInfoGroup";
            this.generalInfoGroup.TabStop = false;
            // 
            // assetTypeComboBox
            // 
            this.assetTypeComboBox.FormattingEnabled = true;
            this.assetTypeComboBox.Items.AddRange(new object[] {
            resources.GetString("assetTypeComboBox.Items"),
            resources.GetString("assetTypeComboBox.Items1"),
            resources.GetString("assetTypeComboBox.Items2"),
            resources.GetString("assetTypeComboBox.Items3"),
            resources.GetString("assetTypeComboBox.Items4"),
            resources.GetString("assetTypeComboBox.Items5"),
            resources.GetString("assetTypeComboBox.Items6"),
            resources.GetString("assetTypeComboBox.Items7"),
            resources.GetString("assetTypeComboBox.Items8"),
            resources.GetString("assetTypeComboBox.Items9"),
            resources.GetString("assetTypeComboBox.Items10"),
            resources.GetString("assetTypeComboBox.Items11"),
            resources.GetString("assetTypeComboBox.Items12"),
            resources.GetString("assetTypeComboBox.Items13"),
            resources.GetString("assetTypeComboBox.Items14"),
            resources.GetString("assetTypeComboBox.Items15"),
            resources.GetString("assetTypeComboBox.Items16"),
            resources.GetString("assetTypeComboBox.Items17"),
            resources.GetString("assetTypeComboBox.Items18"),
            resources.GetString("assetTypeComboBox.Items19"),
            resources.GetString("assetTypeComboBox.Items20"),
            resources.GetString("assetTypeComboBox.Items21"),
            resources.GetString("assetTypeComboBox.Items22")});
            resources.ApplyResources(this.assetTypeComboBox, "assetTypeComboBox");
            this.assetTypeComboBox.Name = "assetTypeComboBox";
            this.assetTypeComboBox.SelectionChangeCommitted += new System.EventHandler(this.assetTypeComboBox_SelectionChangeCommitted);
            // 
            // openSkinPackPathSelectButton
            // 
            resources.ApplyResources(this.openSkinPackPathSelectButton, "openSkinPackPathSelectButton");
            this.openSkinPackPathSelectButton.Name = "openSkinPackPathSelectButton";
            this.openSkinPackPathSelectButton.UseVisualStyleBackColor = true;
            this.openSkinPackPathSelectButton.Click += new System.EventHandler(this.openSkinPackPathSelectButton_Click);
            // 
            // skinPackPathTextBox
            // 
            resources.ApplyResources(this.skinPackPathTextBox, "skinPackPathTextBox");
            this.skinPackPathTextBox.Name = "skinPackPathTextBox";
            this.skinPackPathTextBox.ReadOnly = true;
            this.skinPackPathTextBox.TabStop = false;
            // 
            // skinNameTextBox
            // 
            resources.ApplyResources(this.skinNameTextBox, "skinNameTextBox");
            this.skinNameTextBox.Name = "skinNameTextBox";
            // 
            // labelx
            // 
            resources.ApplyResources(this.labelx, "labelx");
            this.labelx.Name = "labelx";
            // 
            // pathTextBox
            // 
            resources.ApplyResources(this.pathTextBox, "pathTextBox");
            this.pathTextBox.Name = "pathTextBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // skinPackPathDialogue
            // 
            this.skinPackPathDialogue.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // generateSkinPackButton
            // 
            resources.ApplyResources(this.generateSkinPackButton, "generateSkinPackButton");
            this.generateSkinPackButton.Name = "generateSkinPackButton";
            this.generateSkinPackButton.UseVisualStyleBackColor = true;
            this.generateSkinPackButton.Click += new System.EventHandler(this.generateSkinPackButton_Click);
            // 
            // SkinPackMakerWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.generateSkinPackButton);
            this.Controls.Add(this.generalInfoGroup);
            this.Controls.Add(this.texturesSetGroup);
            this.Name = "SkinPackMakerWindow";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.colorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glossinessPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specularPictureBox)).EndInit();
            this.texturesSetGroup.ResumeLayout(false);
            this.texturesSetGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.illuminationPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cavityPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aoPictureBox)).EndInit();
            this.generalInfoGroup.ResumeLayout(false);
            this.generalInfoGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox colorPictureBox;
        private System.Windows.Forms.PictureBox normalPictureBox;
        private System.Windows.Forms.PictureBox glossinessPictureBox;
        private System.Windows.Forms.PictureBox specularPictureBox;
        private System.Windows.Forms.GroupBox texturesSetGroup;
        private System.Windows.Forms.GroupBox generalInfoGroup;
        private System.Windows.Forms.Button openSkinPackPathSelectButton;
        private System.Windows.Forms.TextBox skinPackPathTextBox;
        private System.Windows.Forms.TextBox skinNameTextBox;
        private System.Windows.Forms.Label pathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog skinPackPathDialogue;
        private System.Windows.Forms.ComboBox assetTypeComboBox;
        private System.Windows.Forms.Label labelx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button generateSkinPackButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox illuminationPictureBox;
        private System.Windows.Forms.PictureBox cavityPictureBox;
        private System.Windows.Forms.PictureBox aoPictureBox;
    }
}