using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Titanfall2_SkinTool
{

    public partial class MainWindow : Form
    {
        string msg = null;
        string GamePath = null;
        string filePath = Environment.CurrentDirectory;
        string Folder = null;
        string SelectedGame = "BUG!";
        public string filename = "default";
        int DDSFolderExist = 0;

        ResourceManager rm = new ResourceManager("Titanfall2_SkinTool.Language", Assembly.GetExecutingAssembly());


        public MainWindow()
        {
            InitializeComponent();
            Language_Default();

            if (!File.Exists(filePath + "\\Config.xml"))
            {
                //ToDo...
            }
        }

        private void SkinFileSelect_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SkinFileSelect.ShowHelp = false;
            SkinFileSelect.InitialDirectory = @"F:\";
            SkinFileSelect.Filter = rm.GetString("Skin") + "(*.zip)|*.zip";
            SkinFileSelect.Title = rm.GetString("OpenFile");
            SkinFileSelect.Multiselect = false;
            SkinFileSelect.RestoreDirectory = true;
            if (this.SkinFileSelect.ShowDialog() == DialogResult.OK)
            {
                PathText.Text = this.SkinFileSelect.FileName;
                Folder = Path.GetFileNameWithoutExtension(PathText.Text);
            }
        }

        private void Menu_SettingGamePath_Click(object sender, EventArgs e)
        {
            SkinFileSelect.ShowHelp = false;
            SkinFileSelect.InitialDirectory = @"F:\";
            SkinFileSelect.Filter = rm.GetString("Game") + "|Titanfall2.exe;r5apex.exe";//fix
            SkinFileSelect.Title = rm.GetString("OpenFile");
            SkinFileSelect.Multiselect = false;
            SkinFileSelect.RestoreDirectory = true;
            if (this.SkinFileSelect.ShowDialog() == DialogResult.OK)
            {
                GamePath = System.IO.Path.GetDirectoryName(this.SkinFileSelect.FileName);
                switch (System.IO.Path.GetFileName(SkinFileSelect.FileName))
                {
                    case "r5apex.exe":
                        SelectedGame = "APEX";
                        break;
                    case "Titanfall2.exe":
                        SelectedGame = "Titanfall2";
                        break;
                    default:
                        SelectedGame = "BUG!";
                        break;
                }
                File.WriteAllText($"{filePath}\\Path.txt", GamePath);
                textBox1.AppendText(rm.GetString("GameLoadSuccess") + SelectedGame + "\r\n");

                Console.WriteLine(GamePath);
            }
        }

        private void Menu_Author_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rm.GetString("MenuAboutAuthor") + "：zxcPandora\r\nDiscord：zxcPandora#1581\r\nBilibili：极度分裂的潘多拉\r\nWeaponData:MrSteyk's Tool\r\nSkinPackMaker:salcodes", rm.GetString("AboutAuthor"), MessageBoxButtons.OK);
        }

        private void Test_Click(object sender, EventArgs e)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            try
            {
                if (File.Exists(GamePath + "\\r5apex.exe") || File.Exists(GamePath + "\\Titanfall2.exe"))
                {
                    //fixed
                }
                else
                {
                    throw new MyException(rm.GetString("GameLoadFailed"));
                }
                if (!File.Exists(PathText.Text) || PathText.Text == "")
                {
                    throw new MyException(rm.GetString("ZipLoadFailed"));
                }

                string ExtractPath = filePath + "\\" + rm.GetString("SaveFolder") + "\\" + Folder;
                if (!Directory.Exists(ExtractPath))
                {
                    Directory.CreateDirectory(ExtractPath);
                }
                try
                {
                    ZipFile.ExtractToDirectory(PathText.Text, ExtractPath, Encoding.GetEncoding("GBK"));
                    textBox1.AppendText(rm.GetString("ZipLoadSuccess") + "\r\n");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //Testing new way to save dds
                List<string> FileList=new List<string>();
                FindSkinFiles(ExtractPath, FileList, ".dds");

                foreach (var i in FileList)
                    Console.WriteLine(i);

                DDSFolderExist = FileList.Count;
                if (DDSFolderExist == 0 )
                {
                    throw new MyException(rm.GetString("FindSkinFailed"));
                }

                foreach (var i in FileList)
                {
                    int FolderLength = ExtractPath.Length;
                    String FileString = i.Substring(FolderLength);
                    int imagecheck = ImageCheck(i);
                    //the following code is waiting for the custom model
                    Int64 toseek = 0;
                    int tolength = 0;
                    int totype = 0;
                    //传递数组内容
                    //需要使用命名对代码进行优化
                    if (IsPilot(i))
                    {
                        Titanfall2.PilotData.PilotDataControl pdc = new Titanfall2.PilotData.PilotDataControl(i,imagecheck);
                        toseek = Convert.ToInt64(pdc.Seek);
                        tolength = Convert.ToInt32(pdc.Length);
                        totype = Convert.ToInt32(pdc.SeekLength);
                    }
                    else //if(IsWeapon(i))
                    {
                        if (SelectedGame == "APEX")
                        {
                            APEX.WeaponData.WeaponDataControl wdc = new APEX.WeaponData.WeaponDataControl(i, imagecheck);
                            toseek = Convert.ToInt64(wdc.FilePath[0, 1]);
                            tolength = Convert.ToInt32(wdc.FilePath[0, 2]);
                            totype = Convert.ToInt32(wdc.FilePath[0, 3]);
                        }
                        else if (SelectedGame == "Titanfall2")
                        {
                            Titanfall2.WeaponData.WeaponDataControl wdc = new Titanfall2.WeaponData.WeaponDataControl(i, imagecheck);
                            toseek = Convert.ToInt64(wdc.FilePath[0, 1]);
                            tolength = Convert.ToInt32(wdc.FilePath[0, 2]);
                            totype = Convert.ToInt32(wdc.FilePath[0, 3]);
                        }
                    }
                    StarpakControl sc = new StarpakControl(i, toseek, tolength, totype, GamePath, SelectedGame, imagecheck, "Replace");
                    //ToDo:Change to the Struct,still not done that...
                }

                FileList.Clear();
                msg = rm.GetString("InstallSuccess");
                textBox1.AppendText(msg + "\r\n");
                MessageBox.Show(msg, rm.GetString("Tip"), MessageBoxButtons.OK);
            }
            catch (MyException myException)
            {
                MessageBox.Show(myException.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            GC.Collect();
            if (Directory.Exists(rm.GetString("SaveFolder")))
            {
                try
                {
                    DirectoryInfo tempDir = new DirectoryInfo(rm.GetString("SaveFolder"));

                    foreach (DirectoryInfo dir in tempDir.EnumerateDirectories())
                    {
                        dir.Delete(true);
                    }

                    tempDir.Delete();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured while trying to delete the temporary files folder: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Language_Default()
        {
            String lang = CultureInfo.CurrentUICulture.Name;
            switch (lang)
            {
                case "zh-CN":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
                    this.LanguageChinese.Checked = true;
                    break;
                default:
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    this.LanguageEnglish.Checked = true;
                    break;
            }
            this.label1.Text = rm.GetString("label");
            this.Text = rm.GetString("Form");
            this.Menu_Setting.Text = rm.GetString("MenuSet");
            this.Menu_SettingGamePath.Text = rm.GetString("MenuSetPath");
            this.Menu_About.Text = rm.GetString("MenuAbout");
            this.Menu_Author.Text = rm.GetString("MenuAboutAuthor");
            this.ToolLanguageMenu.Text = rm.GetString("Language");
            this.LanguageChinese.Text = rm.GetString("Chinese");
            this.LanguageEnglish.Text = rm.GetString("English");
            this.Test.Text = rm.GetString("ImportBtn");
            this.toolsToolStripMenuItem.Text = rm.GetString("Tools");
            this.skinPackMakerToolStripMenuItem.Text = rm.GetString("SkinPackMaker");
            if (System.IO.File.Exists($"{filePath}\\Path.txt") == true)
            {
                GamePath = File.ReadAllText($"{filePath}\\Path.txt");
                if (System.IO.File.Exists($"{GamePath}\\Titanfall2.exe"))
                {
                    SelectedGame = "Titanfall2";
                }
                if (System.IO.File.Exists($"{GamePath}\\r5apex.exe"))
                {
                    SelectedGame = "APEX";
                }
                textBox1.AppendText(rm.GetString("GameLoadSuccess") + SelectedGame + "\r\n");
            }
            else
            {
                textBox1.AppendText(rm.GetString("SetGamePath") + "\r\n");
            }
        }

        private void LanguageChinese_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh-CN");
            this.label1.Text = rm.GetString("label");
            this.Text = rm.GetString("Form");
            this.Menu_Setting.Text = rm.GetString("MenuSet");
            this.Menu_SettingGamePath.Text = rm.GetString("MenuSetPath");
            this.Menu_About.Text = rm.GetString("MenuAbout");
            this.Menu_Author.Text = rm.GetString("MenuAboutAuthor");
            this.ToolLanguageMenu.Text = rm.GetString("Language");
            this.LanguageChinese.Text = rm.GetString("Chinese");
            this.LanguageEnglish.Text = rm.GetString("English");
            this.Test.Text = rm.GetString("ImportBtn");
            this.LanguageChinese.Checked = true;
            this.LanguageEnglish.Checked = false;
            this.toolsToolStripMenuItem.Text = rm.GetString("Tools");
            this.skinPackMakerToolStripMenuItem.Text = rm.GetString("SkinPackMaker");
            textBox1.Clear();
        }

        private void LanguageEnglish_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            this.label1.Text = rm.GetString("label");
            this.Text = rm.GetString("Form");
            this.Menu_Setting.Text = rm.GetString("MenuSet");
            this.Menu_SettingGamePath.Text = rm.GetString("MenuSetPath");
            this.Menu_About.Text = rm.GetString("MenuAbout");
            this.Menu_Author.Text = rm.GetString("MenuAboutAuthor");
            this.ToolLanguageMenu.Text = rm.GetString("Language");
            this.LanguageChinese.Text = rm.GetString("Chinese");
            this.LanguageEnglish.Text = rm.GetString("English");
            this.Test.Text = rm.GetString("ImportBtn");
            this.LanguageChinese.Checked = false;
            this.LanguageEnglish.Checked = true;
            this.toolsToolStripMenuItem.Text = rm.GetString("Tools");
            this.skinPackMakerToolStripMenuItem.Text = rm.GetString("SkinPackMaker");
            textBox1.Clear();
        }

        private void skinPackMakerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SkinPackMakerWindow window = new SkinPackMakerWindow(SelectedGame);
            window.ShowDialog();
        }

        private void FindSkinFiles(string FolderPath, List<string> FileList, string FileExtention)
        {
            try
            {
                DirectoryInfo di = new DirectoryInfo(FolderPath);
                FileSystemInfo[] fi = di.GetFileSystemInfos();
                foreach (var i in fi)
                {
                    if (i is DirectoryInfo)
                    {
                        FindSkinFiles(i.FullName, FileList, FileExtention);
                    }
                    else
                    {
                        if (i.Extension == FileExtention)
                        {
                            FileList.Add(i.FullName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int ImageCheck(String ImageName)
        {
            int result = -1;
            int temp=ImageName.LastIndexOf("\\");
            ImageName = ImageName.Substring(0,temp);
            temp = ImageName.LastIndexOf("\\")+1 ;
            ImageName = ImageName.Substring(temp,ImageName.Length-temp);
            switch (ImageName)
            {
                case "256x128":
                case "256x256":
                case "256":
                    //Big change,I don't want to do it:(
                    break;
                case "512x256":
                case "512x512":
                case "512":
                    result = 0;
                    break;
                case "1024x512":
                case "1024x1024":
                case "1024":
                    result = 1;
                    break;
                case "2048x1024":
                case "2048x2048":
                case "2048":
                    result = 2;
                    break;
                case "4096x2048":
                case "4096x4096":
                case "4096":
                    result = 3;
                    break;
                default:
                    result = -1;
                    break;
            }
            return result;
        }

        private bool IsPilot(string Name)
        {
            if (Name.Contains("Stim_") || Name.Contains("PhaseShift_") || Name.Contains("HoloPilot_") || Name.Contains("PulseBlade_") || Name.Contains("Grapple_") || Name.Contains("AWall_") || Name.Contains("Cloak_") || Name.Contains("Public_"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
