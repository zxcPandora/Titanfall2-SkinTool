using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool
{
    class StarpakControl
    {
        public StarpakControl(string name, Int64 seek, int length, int type, string GamePath, string SelectedGame, int imagecheck, string Action)
        {                       //ToDo:Change to the Struct
            string FileName = null;
            string ControlPath = null;
            byte[] byData = new byte[length];
            switch (SelectedGame)
            {
                case "Titanfall2":
                    ControlPath = GamePath + "\\r2\\paks\\Win64\\";
                    if (name.Contains("WingmanElite") || name.Contains("R101") || name.Contains("PrimeLegion") || name.Contains("PrimeNorthstar") || name.Contains("PrimeScorch") || name.Contains("PrimeRonin_Default_gls") || name.Contains("PrimeION") || name.Contains("PrimeRonin_Default_nml") || name.Contains("PrimeRonin_Default_spc") || name.Contains("PrimeRonin_Default_cav") || name.Contains("PrimeRonin_Default_ao"))
                    {
                        FileName = "pc_stream(03).starpak";
                    }
                    else if (name.Contains("Monarch"))
                    {
                        FileName = "pc_stream(07).starpak";
                    }
                    else if (name.Contains("PrimeTone") || name.Contains("PrimeRonin_Default_ilm"))
                    {
                        FileName = "pc_stream(05).starpak";
                    }
                    else if (name.Contains("PrimeRonin_Default_col"))
                    {
                        FileName = "pc_stream(06).starpak";
                    }
                    else
                    {
                        FileName = "pc_stream.starpak";
                    }
                    break;
                //Fixed
                case "APEX":
                    ControlPath = GamePath + "\\paks\\Win64\\";
                    if ((name.Contains("P2020")!=true && name.Contains("RE45") != true && name.Contains("Wingman") != true && name.Contains("Mozambique") != true) && imagecheck == 0)
                    {
                        FileName = "pc_all.starpak";
                    }
                    else if (name.Contains("Volt"))
                    {
                        FileName = "pc_all(02).opt.starpak";
                    }
                    else if (name.Contains("ChargeRifle"))
                    {
                        FileName = "pc_all(03).opt.starpak";
                    }
                    else
                    {
                        FileName = "pc_all.opt.starpak";
                    }
                    break;
                default:
                    throw new MyException("Error!");
            }

            try
            {
                FileStream aFile = new FileStream(name, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                aFile.Seek(type, SeekOrigin.Begin);
                aFile.Read(byData, 0, length);

                //Fixed
                FileStream fswrite = new FileStream(ControlPath + FileName, FileMode.Open, FileAccess.Write, FileShare.ReadWrite);
                fswrite.Seek(seek, SeekOrigin.Begin);
                fswrite.Write(byData, 0, length);

                aFile.Close();
                fswrite.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine("IO错误已被抛出！");
                Console.WriteLine(ex.ToString());
                return;
            }
        }
    }
}
