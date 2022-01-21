
namespace Titanfall2_SkinTool
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.PathText = new System.Windows.Forms.TextBox();
            this.OpenButton = new System.Windows.Forms.Button();
            this.SkinFileSelect = new System.Windows.Forms.OpenFileDialog();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.Menu_Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_SettingGamePath = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_AutoUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_About = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Author = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolLanguageMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.LanguageChinese = new System.Windows.Forms.ToolStripMenuItem();
            this.LanguageEnglish = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Test = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(-4, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "皮肤文件：";
            // 
            // PathText
            // 
            this.PathText.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PathText.Location = new System.Drawing.Point(119, 37);
            this.PathText.Name = "PathText";
            this.PathText.ReadOnly = true;
            this.PathText.Size = new System.Drawing.Size(622, 28);
            this.PathText.TabIndex = 1;
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(747, 37);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(41, 25);
            this.OpenButton.TabIndex = 2;
            this.OpenButton.Text = "...";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // SkinFileSelect
            // 
            this.SkinFileSelect.FileOk += new System.ComponentModel.CancelEventHandler(this.SkinFileSelect_FileOk);
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Setting,
            this.Menu_About,
            this.ToolLanguageMenu});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(800, 28);
            this.Menu.TabIndex = 4;
            this.Menu.Text = "menuStrip1";
            // 
            // Menu_Setting
            // 
            this.Menu_Setting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_SettingGamePath,
            this.Menu_AutoUpdate});
            this.Menu_Setting.Name = "Menu_Setting";
            this.Menu_Setting.Size = new System.Drawing.Size(53, 24);
            this.Menu_Setting.Text = "设置";
            // 
            // Menu_SettingGamePath
            // 
            this.Menu_SettingGamePath.Name = "Menu_SettingGamePath";
            this.Menu_SettingGamePath.Size = new System.Drawing.Size(182, 26);
            this.Menu_SettingGamePath.Text = "设置游戏路径";
            this.Menu_SettingGamePath.Click += new System.EventHandler(this.Menu_SettingGamePath_Click);
            //
            // Menu_AutoUpdate
            // 
            this.Menu_AutoUpdate.Name = "Menu_AutoUpdate";
            this.Menu_AutoUpdate.Size = new System.Drawing.Size(224, 26);
            this.Menu_AutoUpdate.Text = "自动升级";
            this.Menu_AutoUpdate.Click += new System.EventHandler(this.Menu_AutoUpdate_Click);
            // 
            // Menu_About
            // 
            this.Menu_About.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Author});
            this.Menu_About.Name = "Menu_About";
            this.Menu_About.Size = new System.Drawing.Size(53, 24);
            this.Menu_About.Text = "关于";
            // 
            // Menu_Author
            // 
            this.Menu_Author.Name = "Menu_Author";
            this.Menu_Author.Size = new System.Drawing.Size(122, 26);
            this.Menu_Author.Text = "作者";
            this.Menu_Author.Click += new System.EventHandler(this.Menu_Author_Click);
            // 
            // ToolLanguageMenu
            // 
            this.ToolLanguageMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LanguageChinese,
            this.LanguageEnglish});
            this.ToolLanguageMenu.Name = "ToolLanguageMenu";
            this.ToolLanguageMenu.Size = new System.Drawing.Size(53, 24);
            this.ToolLanguageMenu.Text = "语言";
            // 
            // LanguageChinese
            // 
            this.LanguageChinese.Name = "LanguageChinese";
            this.LanguageChinese.Size = new System.Drawing.Size(122, 26);
            this.LanguageChinese.Text = "中文";
            this.LanguageChinese.Click += new System.EventHandler(this.LanguageChinese_Click);
            // 
            // LanguageEnglish
            // 
            this.LanguageEnglish.Name = "LanguageEnglish";
            this.LanguageEnglish.Size = new System.Drawing.Size(122, 26);
            this.LanguageEnglish.Text = "英文";
            this.LanguageEnglish.Click += new System.EventHandler(this.LanguageEnglish_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 108);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(776, 330);
            this.textBox1.TabIndex = 5;
            // 
            // Test
            // 
            this.Test.Location = new System.Drawing.Point(272, 71);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(204, 31);
            this.Test.TabIndex = 6;
            this.Test.Text = "测试版本";
            this.Test.UseVisualStyleBackColor = true;
            this.Test.Click += new System.EventHandler(this.Test_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Test);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.PathText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "泰坦陨落二皮肤工具";
            this.Shown += new System.EventHandler(this.MainWindow_OnShown);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PathText;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.OpenFileDialog SkinFileSelect;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem Menu_Setting;
        private System.Windows.Forms.ToolStripMenuItem Menu_SettingGamePath;
        private System.Windows.Forms.ToolStripMenuItem Menu_About;
        private System.Windows.Forms.ToolStripMenuItem Menu_Author;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Test;
        private System.Windows.Forms.ToolStripMenuItem ToolLanguageMenu;
        private System.Windows.Forms.ToolStripMenuItem LanguageChinese;
        private System.Windows.Forms.ToolStripMenuItem LanguageEnglish;
        private System.Windows.Forms.ToolStripMenuItem Menu_AutoUpdate;
    }
}

