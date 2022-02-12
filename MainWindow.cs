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
using System.Net.Http;
using System.Threading.Tasks;


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

        //We don't need this
        //DateTime dt = DateTime.ParseExact(Info.Substring(index + 14, 20), "yyyy-MM-ddTHH:mm:ssZ", System.Globalization.CultureInfo.CurrentCulture);

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
                Properties.Settings.Default.GamePath = GamePath;
                Properties.Settings.Default.Save();
                textBox1.AppendText(rm.GetString("GameLoadSuccess") + SelectedGame + "\r\n");
                Console.WriteLine(GamePath);
            }
        }

        private void Menu_Author_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rm.GetString("MenuAboutAuthor") + "：zxcPandora\r\n" +
                "Bilibili：极度分裂的潘多拉\r\n" +
                "WeaponData:MrSteyk's Tool\r\n" +
                "Main author:zxcPandora#1581(Discord)\r\n" +
                "SkinPack:sal#3261(Discord)\r\n" +
                "CommandLine:KanjiuAkuma(Github)", rm.GetString("AboutAuthor"), MessageBoxButtons.OK);
        }

        private void Test_Click(object sender, EventArgs e)
        {
            String msg;
            try
            {
                SkinTool tool = new SkinTool(GamePath, SelectedGame, (m) => textBox1.AppendText(m + "\r\n"));
                tool.InstallSkin(PathText.Text);

                // success
                msg = rm.GetString("InstallSuccess");
            }
            catch (Exception ex)   // Catches MyException as well
            {
                // failed
                msg = rm.GetString("InstallFailed") + ex.Message;
            }

            // info popup
            MessageBox.Show(msg, rm.GetString("Tip"), MessageBoxButtons.OK);
        }

        private void Language_Default()
        {
            if (Properties.Settings.Default.Language == null || Properties.Settings.Default.Language.Length == 0)
            {
                Properties.Settings.Default.Language = CultureInfo.CurrentUICulture.Name;
                Properties.Settings.Default.Save();
            }
            switch (Properties.Settings.Default.Language)
            {
                case "zh-CN":
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo(Properties.Settings.Default.Language);
                    this.LanguageChinese.Checked = true;
                    break;
                default:
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    this.LanguageEnglish.Checked = true;
                    break;
            }
            if (Properties.Settings.Default.AutoUpdate==true)
            {
                this.Menu_AutoUpdate.Checked = true;
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
            this.Menu_AutoUpdate.Text = rm.GetString("AutoUpdate");
            if (Properties.Settings.Default.GamePath != null && Properties.Settings.Default.GamePath.Length != 0)
            {
                GamePath = Properties.Settings.Default.GamePath;
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
            if (Properties.Settings.Default.AutoUpdate ==true)
            {
                this.Menu_AutoUpdate.Checked = true;
            }
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
            this.Menu_AutoUpdate.Text = rm.GetString("AutoUpdate");
            Properties.Settings.Default.Language = "zh-CN";
            Properties.Settings.Default.Save();
            textBox1.Clear();
            textBox1.AppendText(rm.GetString("Language") + ":" + rm.GetString("Chinese") + "\r\n");
        }

        private void LanguageEnglish_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.AutoUpdate == true)
            {
                this.Menu_AutoUpdate.Checked = true;
            }
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
            this.Menu_AutoUpdate.Text = rm.GetString("AutoUpdate");
            Properties.Settings.Default.Language = "en-US";
            Properties.Settings.Default.Save();
            textBox1.Clear();
            textBox1.AppendText(rm.GetString("Language") + ":" + rm.GetString("English") + "\r\n");
        }

        private void VersionCheck()
        {
            HttpClient httpClient = new HttpClient();
            String Uri = "https://api.github.com/repos/zxcPandora/Titanfall2-SkinTool/releases/latest";
            String Header = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/36.0.1985.143 Safari/537.36";
            httpClient.DefaultRequestHeaders.Add("user-agent", Header);
            string resultStr = null;
            try
            {
                var response = httpClient.GetStringAsync(Uri);
                resultStr = response.Result;
            }
            catch (HttpRequestException e)
            {
                MessageBox.Show(e.Message);
            }
            
            string tag = "tag_name";
            string updatelog = "body";
            string tempStr = "";
            int index = 0;
            int index2 = 0;
            index = resultStr.IndexOf(tag, index);
            tempStr = resultStr.Substring(index + 12, resultStr.Length - (index+12));
            index2 = tempStr.IndexOf("\"", index2);
            string TagVersion = tempStr.Substring(0, index2);

            index = 0;
            index2 = 0;
            index = resultStr.IndexOf(updatelog, index);
            tempStr = resultStr.Substring(index + 8, resultStr.Length - (index + 8));
            index2 = tempStr.IndexOf("\"", index2);
            string log = tempStr.Substring(0, index2);
            log = log.Replace("\\r", "\r").Replace("\\n", "\n");

            if (TagVersion.CompareTo(Properties.Settings.Default.Version) != 0)
            {
                DialogResult msgresult = MessageBox.Show(rm.GetString("UpdateText")+"\r\n"+ rm.GetString("UpdateText2")+"\r\n"+log, rm.GetString("AutoUpdate"), MessageBoxButtons.YesNo);
                if (msgresult == DialogResult.Yes)
                {
                    string language = Properties.Settings.Default.Language;
                    string filename = null;
                    switch (language)
                    {
                        case "zh-CN":
                            filename = "SkinTool-Maker-CHS.zip";
                            break;
                        case "en-US":
                            filename = "SkinTool-Maker-ENG.zip";
                            break;
                        default:
                            filename = "SkinTool-Maker-ENG.zip";
                            break;
                    }
                    Download(filename, TagVersion);
                }
            }
        }

        private void Download(string filename, string version)
        {
            ProgressForm progressForm = null;
            try
            {
                string URL = "https://github.com/zxcPandora/Titanfall2-SkinTool/releases/download/" + version + "/" + filename;
                System.Net.HttpWebRequest Myrq = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(URL);
                System.Net.HttpWebResponse myrp = (System.Net.HttpWebResponse)Myrq.GetResponse();
                int totalBytes = (int)myrp.ContentLength;
                Console.WriteLine(totalBytes);

                Thread progressThread = new Thread(() =>
                {
                    progressForm = new ProgressForm(totalBytes, "Download");
                    progressForm.ShowDialog();
                }
            );

                progressThread.Start();

                System.IO.Stream st = myrp.GetResponseStream();
                System.IO.Stream so = new System.IO.FileStream(filename, System.IO.FileMode.Create);
                int totalDownloadedByte = 0;
                byte[] by = new byte[1024];
                int osize = st.Read(by, 0, (int)by.Length);
                while (osize > 0)
                {
                    totalDownloadedByte = osize + totalDownloadedByte;

                    so.Write(by, 0, osize);

                    osize = st.Read(by, 0, (int)by.Length);

                    progressForm?.AdvanceEntry(totalDownloadedByte);

                    Console.WriteLine(totalDownloadedByte);

                }
                so.Close();
                st.Close();
            }
            catch (System.Exception)
            {
                throw;
            }
            progressForm?.ForceClose();
            MessageBox.Show(rm.GetString("DownloadSuccess"), rm.GetString("Tip"), MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        private void skinPackMakerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SkinPackMakerWindow window = new SkinPackMakerWindow(SelectedGame);
            window.ShowDialog();
        }

        private void MainWindow_OnShown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.AutoUpdate == true)
            {
                VersionCheck();
            }
        }

        private void Menu_AutoUpdate_Click(object sender, EventArgs e)
        {
            if (this.Menu_AutoUpdate.Checked == true)
            {
                Properties.Settings.Default.AutoUpdate = false;
                this.Menu_AutoUpdate.Checked = false;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.AutoUpdate = true;
                this.Menu_AutoUpdate.Checked = true;
                Properties.Settings.Default.Save();
            }
        }
    }
}

