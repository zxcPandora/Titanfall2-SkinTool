using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Resources;
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
        string[,] FilePath = new string[3, 8];
        string[] ImageCheck = new string[3];//2为2048x2048,1为1024x1024,0为512x512
        System.Resources.ResourceManager rm = new ResourceManager("Titanfall2_SkinTool.Language", Assembly.GetExecutingAssembly());

        public MainWindow()
        {
            InitializeComponent();

            if (!File.Exists(filePath + "\\Config.xml"))
            {
                //ToDo...
            }

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
                Array.Clear(ImageCheck, 0, ImageCheck.Length);
                Array.Clear(FilePath, 0, FilePath.Length);

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
                try
                {
                    // 打开zip文件
                    ZipArchive archive = ZipFile.OpenRead(PathText.Text);
                    // 获取文件列表
                    var files = archive.Entries;
                    // 显示列表
                    string lastfilename = "test";
                    int check = 0;//dds file exist
                    int lastcheck = 0;//folder
                    int total = 0;
                    int CountCheck = 0;
                    foreach (ZipArchiveEntry zav in files)
                    {
                        if (zav.Name.Contains(".dds"))
                        {
                            CountCheck++;
                        }
                    }
                    bool FileCount = files.Count != CountCheck;
                    Console.WriteLine("文件数检查:" + FileCount);
                    if (FileCount)
                    {
                        foreach (ZipArchiveEntry zav in files)
                        {
                            textBox1.AppendText(zav.FullName.Replace("/", "\\") + "\r\n");

                            if (zav.Name.Contains(".dds"))
                            {
                                if (check == 1)
                                {
                                    lastcheck = 1;
                                }
                                check = 1;
                                
                            }
                            else
                            {
                                lastfilename = zav.FullName;
                                lastfilename = lastfilename.Replace("/", "\\");
                                check = 0;
                                lastcheck = 0;
                                total = 0;
                            }
                            if (check == 1 && lastcheck == 0)
                            {
                                Console.WriteLine(lastfilename);

                            }
                            if (check == 1)
                            {
                                if (lastfilename.Contains("512"))
                                {
                                    ImageCheck[0] = lastfilename;
                                    FilePath[0, total] = zav.Name;
                                }

                                if (lastfilename.Contains("1024"))
                                {
                                    ImageCheck[1] = lastfilename;
                                    FilePath[1, total] = zav.Name;
                                }
                                if (lastfilename.Contains("2048"))
                                {
                                    ImageCheck[2] = lastfilename;
                                    FilePath[2, total] = zav.Name;
                                }
                                total++;
                            }
                        }
                    }
                    else
                    {
                        int Count512 = 0;
                        int Count1024 = 0;
                        int Count2048 = 0;
                        foreach (ZipArchiveEntry zav in files)
                        {
                            textBox1.AppendText(zav.FullName.Replace("/", "\\") + "\r\n");
                            string FolderResult = zav.FullName.Substring(0, zav.FullName.LastIndexOf(zav.Name));
                            FolderResult = FolderResult.Replace("/", "\\");
                            string FileResult = zav.Name;
                            if (FolderResult.Contains("512"))
                            {
                                ImageCheck[0] = FolderResult;
                                FilePath[0, Count512] = zav.Name;
                                Count512++;
                            }

                            if (FolderResult.Contains("1024"))
                            {
                                ImageCheck[1] = FolderResult;
                                FilePath[1, Count1024] = zav.Name;
                                Count1024++;
                            }
                            if (FolderResult.Contains("2048"))
                            {
                                ImageCheck[2] = FolderResult;
                                FilePath[2, Count2048] = zav.Name;
                                Count2048++;
                            }
                        }
                    }
                    //ZipList.Items = files;
                    textBox1.AppendText(rm.GetString("ZipReadSuccess") + "\r\n");
                }
                catch (Exception ex)
                {
                    msg = ex.Message;
                }
                DDSFolderExist = 0;
                for (int i = 0; i <= 2; i++)
                {
                    if (ImageCheck[i] != null)
                    {
                        DDSFolderExist++;
                    }
                }
                if (DDSFolderExist == 0)
                {
                    throw new MyException(rm.GetString("FindSkinFailed"));
                }

                string ExtractPath = filePath + "\\" + rm.GetString("SaveFolder") + "\\" + Folder;
                if (!Directory.Exists(ExtractPath))
                {
                    Directory.CreateDirectory(ExtractPath);
                }
                try
                {
                    ZipFile.ExtractToDirectory(PathText.Text, ExtractPath);
                    //textBox1.AppendText(ExtractPath+"\\"+filename + "\r\n");
                    textBox1.AppendText(rm.GetString("ZipLoadSuccess") + "\r\n");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                for (int i = 0; i <= 2; i++)
                {
                    if (ImageCheck[i] != null)
                    {
                        int folder = 4;
                        //string result = System.Text.RegularExpressions.Regex.Replace(ImageCheck[i], @"[^0-9]+", "");
                        if (ImageCheck[i].LastIndexOf("\\") - folder == -1)
                        {
                            folder = 3;
                        }
                        string result = ImageCheck[i].Substring((ImageCheck[i].LastIndexOf("\\") - folder)).Replace("\\", "");
                        int imagecheck = Convert.ToInt32(result);
                        Console.WriteLine(imagecheck);

                        switch (imagecheck)
                        {
                            case 512:
                                imagecheck = 0;
                                break;
                            case 1024:
                                imagecheck = 1;
                                break;
                            case 2048:
                                imagecheck = 2;
                                break;
                            default:
                                throw new MyException("Error!");
                        }
                        for (int j = 0; FilePath[i, j] != null; j++)
                        {
                            Int64 toseek = 0;
                            int tolength = 0;
                            int totype = 0;
                            //传递数组内容
                            //需要使用命名对代码进行优化
                            if (SelectedGame == "APEX")
                            {
                                APEX.WeaponData.WeaponDataControl wdc = new APEX.WeaponData.WeaponDataControl(FilePath[i, j], imagecheck);
                                toseek = Convert.ToInt64(wdc.FilePath[0, 1]);
                                tolength = Convert.ToInt32(wdc.FilePath[0, 2]);
                                totype = Convert.ToInt32(wdc.FilePath[0, 3]);
                            }
                            else if (SelectedGame == "Titanfall2")
                            {
                                Titanfall2.WeaponData.WeaponDataControl wdc = new Titanfall2.WeaponData.WeaponDataControl(FilePath[i, j], imagecheck);
                                toseek = Convert.ToInt64(wdc.FilePath[0, 1]);
                                tolength = Convert.ToInt32(wdc.FilePath[0, 2]);
                                totype = Convert.ToInt32(wdc.FilePath[0, 3]);
                            }

                            string reallypath = ExtractPath + "\\" + ImageCheck[i] + FilePath[i, j];
                            StarpakControl sc = new StarpakControl(reallypath, toseek, tolength, totype, GamePath, SelectedGame, imagecheck, "Replace");
                            //ToDo:Change to the Struct,still not done that...
                            Console.WriteLine(reallypath);
                            Console.WriteLine(toseek);
                            Console.WriteLine(tolength);
                            Console.WriteLine(totype);
                            Console.WriteLine(GamePath);
                        }
                    }

                }
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
            if(Directory.Exists(rm.GetString("SaveFolder")))
            {
                try
                {
                    DirectoryInfo tempDir = new DirectoryInfo(rm.GetString("SaveFolder"));

                    foreach(DirectoryInfo dir in tempDir.EnumerateDirectories())
                    {
                        dir.Delete(true);
                    }

                    tempDir.Delete();
                } catch(Exception ex)
                {
                    MessageBox.Show("Error occured while trying to delete the temporary files folder: \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
        }

        private void skinPackMakerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SkinPackMakerWindow window = new SkinPackMakerWindow();
            window.SetGame(SelectedGame);
            window.ShowDialog();
        }

       
    }
}
