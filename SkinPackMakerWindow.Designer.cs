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
            this.normalLabel = new System.Windows.Forms.Label();
            this.glossinessLabel = new System.Windows.Forms.Label();
            this.specularLabel = new System.Windows.Forms.Label();
            this.illuminationLabel = new System.Windows.Forms.Label();
            this.cavityLabel = new System.Windows.Forms.Label();
            this.aoLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.illuminationPictureBox = new System.Windows.Forms.PictureBox();
            this.cavityPictureBox = new System.Windows.Forms.PictureBox();
            this.aoPictureBox = new System.Windows.Forms.PictureBox();
            this.generalInfoGroup = new System.Windows.Forms.GroupBox();
            this.assetTypeComboBox = new System.Windows.Forms.ComboBox();
            this.openSkinPackPathSelectButton = new System.Windows.Forms.Button();
            this.skinPackPathTextBox = new System.Windows.Forms.TextBox();
            this.skinNameTextBox = new System.Windows.Forms.TextBox();
            this.assetTypeLabel = new System.Windows.Forms.Label();
            this.savePathLabel = new System.Windows.Forms.Label();
            this.skinNameLabel = new System.Windows.Forms.Label();
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
            this.texturesSetGroup.Controls.Add(this.normalLabel);
            this.texturesSetGroup.Controls.Add(this.glossinessLabel);
            this.texturesSetGroup.Controls.Add(this.specularLabel);
            this.texturesSetGroup.Controls.Add(this.illuminationLabel);
            this.texturesSetGroup.Controls.Add(this.cavityLabel);
            this.texturesSetGroup.Controls.Add(this.aoLabel);
            this.texturesSetGroup.Controls.Add(this.colorLabel);
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
            // normalLabel
            // 
            resources.ApplyResources(this.normalLabel, "normalLabel");
            this.normalLabel.Name = "normalLabel";
            // 
            // glossinessLabel
            // 
            resources.ApplyResources(this.glossinessLabel, "glossinessLabel");
            this.glossinessLabel.Name = "glossinessLabel";
            // 
            // specularLabel
            // 
            resources.ApplyResources(this.specularLabel, "specularLabel");
            this.specularLabel.Name = "specularLabel";
            // 
            // illuminationLabel
            // 
            resources.ApplyResources(this.illuminationLabel, "illuminationLabel");
            this.illuminationLabel.Name = "illuminationLabel";
            // 
            // cavityLabel
            // 
            resources.ApplyResources(this.cavityLabel, "cavityLabel");
            this.cavityLabel.Name = "cavityLabel";
            // 
            // aoLabel
            // 
            resources.ApplyResources(this.aoLabel, "aoLabel");
            this.aoLabel.Name = "aoLabel";
            // 
            // colorLabel
            // 
            resources.ApplyResources(this.colorLabel, "colorLabel");
            this.colorLabel.Name = "colorLabel";
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
            this.generalInfoGroup.Controls.Add(this.assetTypeLabel);
            this.generalInfoGroup.Controls.Add(this.savePathLabel);
            this.generalInfoGroup.Controls.Add(this.skinNameLabel);
            resources.ApplyResources(this.generalInfoGroup, "generalInfoGroup");
            this.generalInfoGroup.Name = "generalInfoGroup";
            this.generalInfoGroup.TabStop = false;
            // 
            // assetTypeComboBox
            // 
            this.assetTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.assetTypeComboBox.FormattingEnabled = true;
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
            // assetTypeLabel
            // 
            resources.ApplyResources(this.assetTypeLabel, "assetTypeLabel");
            this.assetTypeLabel.Name = "assetTypeLabel";
            // 
            // savePathLabel
            // 
            resources.ApplyResources(this.savePathLabel, "savePathLabel");
            this.savePathLabel.Name = "savePathLabel";
            // 
            // skinNameLabel
            // 
            resources.ApplyResources(this.skinNameLabel, "skinNameLabel");
            this.skinNameLabel.Name = "skinNameLabel";
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
        private System.Windows.Forms.Label savePathLabel;
        private System.Windows.Forms.Label skinNameLabel;
        private System.Windows.Forms.FolderBrowserDialog skinPackPathDialogue;
        private System.Windows.Forms.ComboBox assetTypeComboBox;
        private System.Windows.Forms.Label assetTypeLabel;
        private System.Windows.Forms.Label glossinessLabel;
        private System.Windows.Forms.Label specularLabel;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Button generateSkinPackButton;
        private System.Windows.Forms.Label normalLabel;
        private System.Windows.Forms.Label illuminationLabel;
        private System.Windows.Forms.Label cavityLabel;
        private System.Windows.Forms.Label aoLabel;
        private System.Windows.Forms.PictureBox illuminationPictureBox;
        private System.Windows.Forms.PictureBox cavityPictureBox;
        private System.Windows.Forms.PictureBox aoPictureBox;
    }
}