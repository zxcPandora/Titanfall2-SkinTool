using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Resources;
using System.Text;

/// <summary>
/// Basically pulled all the needed functions from MainWindow.cs
/// into here to be able to install skins w/o the user inteface
/// </summary>
namespace Titanfall2_SkinTool
{

    public interface IMessageSink
    {
        public void Process(string message);
    }

    public class SkinTool
    {
        private String gamePath;
        private String selectedGame;
        private Action<string> messageHandler;
        private ResourceManager rm = new ResourceManager("Titanfall2_SkinTool.Language", Assembly.GetExecutingAssembly());

        /// <summary>
        ///  For use with commandline
        /// </summary>
        /// <param name="gamePath"></param>
        /// <param name="messageHandler"></param>
        public SkinTool(string gamePath, Action<string> messageHandler)
        {
            this.messageHandler = messageHandler;
            this.gamePath = System.IO.Path.GetDirectoryName(gamePath);
            switch (System.IO.Path.GetFileName(gamePath))
            {
                case "r5apex.exe":
                    selectedGame = "APEX";
                    break;
                case "Titanfall2.exe":
                    selectedGame = "Titanfall2";
                    break;
                default:
                    throw new MyException($"Invalid game path {gamePath}");
            }
        }

        /// <summary>
        /// For use in MainWindow.cs
        /// </summary>
        /// <param name="gamePath"></param>
        /// <param name="selectedGame"></param>
        /// <param name="messageHandler"></param>
        public SkinTool(string gamePath, string selectedGame, Action<string> messageHandler)
        {
            this.gamePath = gamePath;
            this.selectedGame = selectedGame;
            this.messageHandler = messageHandler;
        }

        public void InstallSkin(string skinPath)
        {
            Exception error = null;

            messageHandler($"Install skin {Path.GetFileNameWithoutExtension(skinPath)}");
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            try
            {
                if (!(File.Exists(gamePath + "\\r5apex.exe") || File.Exists(gamePath + "\\Titanfall2.exe")))
                {
                    throw new MyException(rm.GetString("GameLoadFailed"));
                }
                if (!File.Exists(skinPath))
                {
                    throw new MyException(rm.GetString("ZipLoadFailed"));
                }

                string ExtractPath = Environment.CurrentDirectory + "\\" + rm.GetString("SaveFolder") + "\\" + Path.GetFileNameWithoutExtension(skinPath);
                if (!Directory.Exists(ExtractPath))
                {
                    Directory.CreateDirectory(ExtractPath);
                }
                try
                {
                    ZipFile.ExtractToDirectory(skinPath, ExtractPath, Encoding.GetEncoding("GBK"));
                    messageHandler(rm.GetString("ZipLoadSuccess"));
                }
                catch (Exception ex)
                {
                    // todo: only message?
                    // was: MessageBox.Show(ex.Message);
                    messageHandler(ex.Message);
                }

                //Testing new way to save dds
                List<string> FileList = new List<string>();
                FindSkinFiles(ExtractPath, FileList, ".dds");

                // ToDo: assumed those are debug logs and disabled them.
                //       (Do mess up output when using command line version)
                // foreach (var i in FileList)
                //    Console.WriteLine(i);


                int DDSFolderExist = FileList.Count;
                if (DDSFolderExist == 0)
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
                        Titanfall2.PilotData.PilotDataControl pdc = new Titanfall2.PilotData.PilotDataControl(i, imagecheck);
                        toseek = Convert.ToInt64(pdc.Seek);
                        tolength = Convert.ToInt32(pdc.Length);
                        totype = Convert.ToInt32(pdc.SeekLength);
                    }
                    else //if(IsWeapon(i))
                    {
                        if (selectedGame == "APEX")
                        {
                            APEX.WeaponData.WeaponDataControl wdc = new APEX.WeaponData.WeaponDataControl(i, imagecheck);
                            toseek = Convert.ToInt64(wdc.FilePath[0, 1]);
                            tolength = Convert.ToInt32(wdc.FilePath[0, 2]);
                            totype = Convert.ToInt32(wdc.FilePath[0, 3]);
                        }
                        else if (selectedGame == "Titanfall2")
                        {
                            Titanfall2.WeaponData.WeaponDataControl wdc = new Titanfall2.WeaponData.WeaponDataControl(i, imagecheck);
                            toseek = Convert.ToInt64(wdc.FilePath[0, 1]);
                            tolength = Convert.ToInt32(wdc.FilePath[0, 2]);
                            totype = Convert.ToInt32(wdc.FilePath[0, 3]);
                        }
                    }
                    StarpakControl sc = new StarpakControl(i, toseek, tolength, totype, gamePath, selectedGame, imagecheck, "Replace");
                    //ToDo:Change to the Struct,still not done that...
                }

                messageHandler(rm.GetString("InstallSuccess"));
            }
            finally
            {
                // cleanup
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
                        // rethrow; also dont throw from finally directly (at least thats what vs says)
                        error = new MyException("Error occured while trying to delete the temporary files folder: \n" + ex.Message);
                    }
                }
            }

            if (error != null)
            {
                throw error;
            }
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
                // will be caught and processed in InstallSkin
                throw new MyException(ex.Message);
            }
        }

        private int ImageCheck(String ImageName)
        {
            int result = -1;
            int temp = ImageName.LastIndexOf("\\");
            ImageName = ImageName.Substring(0, temp);
            temp = ImageName.LastIndexOf("\\") + 1;
            ImageName = ImageName.Substring(temp, ImageName.Length - temp);
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