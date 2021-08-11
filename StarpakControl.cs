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
        public StarpakControl(string name,Int64 seek,int length,int type,string GamePath)
        {
            string filename= "pc_stream.starpak";
            byte[] byData = new byte[length];
            if (name.Contains("WingmanElite")||name.Contains("R101"))
                filename = "pc_stream(03).starpak";
            try
            {
                FileStream aFile = new FileStream(name, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                aFile.Seek(type, SeekOrigin.Begin);
                aFile.Read(byData, 0, length);

                FileStream fswrite = new FileStream(GamePath + "\\r2\\paks\\Win64\\"+filename, FileMode.Open, FileAccess.Write, FileShare.ReadWrite);
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
