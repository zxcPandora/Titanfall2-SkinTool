using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.WeaponData.Default.Sniper
{
    class G2A7
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }
        //需要修复
        public ReallyData[] G2A7_col;
        public ReallyData[] G2A7_nml;
        public ReallyData[] G2A7_gls;
        public ReallyData[] G2A7_spc;

        public G2A7()
        {


            G2A7_col = new ReallyData[3];
            G2A7_nml = new ReallyData[3];
            G2A7_gls = new ReallyData[3];
            G2A7_spc = new ReallyData[3];

            //2为2048x2048,1为1024x1024,0为512x512

            //col
            G2A7_col[0].name = "col";
            G2A7_col[0].seek = 244224000;
            G2A7_col[0].length = 131072;
            G2A7_col[0].seeklength = 128;

            G2A7_col[1].name = "col";
            G2A7_col[1].seek = 2867073024;
            G2A7_col[1].length = 524288;
            G2A7_col[1].seeklength = 128;

            G2A7_col[2].name = "col";
            G2A7_col[2].seek = G2A7_col[2 - 1].seek + G2A7_col[2 - 1].length;
            G2A7_col[2].length = G2A7_col[2 - 1].length * 4;
            G2A7_col[2].seeklength = 128;

            //nml
            G2A7_nml[0].name = "nml";
            G2A7_nml[0].seek = 244420608;
            G2A7_nml[0].length = 262144;
            G2A7_nml[0].seeklength = 128;

            G2A7_nml[1].name = "nml";
            G2A7_nml[1].seek = 2869694464;
            G2A7_nml[1].length = 1048576;
            G2A7_nml[1].seeklength = 128;

            G2A7_nml[2].name = "nml";
            G2A7_nml[2].seek = G2A7_nml[2 - 1].seek + G2A7_nml[2 - 1].length;
            G2A7_nml[2].length = G2A7_nml[2 - 1].length * 4;
            G2A7_nml[2].seeklength = 128;

            //gls
            G2A7_gls[0].name = "gls";
            G2A7_gls[0].seek = 244682752;
            G2A7_gls[0].length = 131072;
            G2A7_gls[0].seeklength = 128;

            G2A7_gls[1].name = "gls";
            G2A7_gls[1].seek = 2874937344;
            G2A7_gls[1].length = 524288;
            G2A7_gls[1].seeklength = 128;

            G2A7_gls[2].name = "gls";
            G2A7_gls[2].seek = G2A7_gls[2 - 1].seek + G2A7_gls[2 - 1].length;
            G2A7_gls[2].length = G2A7_gls[2 - 1].length * 4;
            G2A7_gls[2].seeklength = 128;

            //spc
            G2A7_spc[0].name = "spc";
            G2A7_spc[0].seek = 244813824;
            G2A7_spc[0].length = 131072;
            G2A7_spc[0].seeklength = 128;

            G2A7_spc[1].name = "spc";
            G2A7_spc[1].seek = 2877558784;
            G2A7_spc[1].length = 524288;
            G2A7_spc[1].seeklength = 128;

            G2A7_spc[2].name = "spc";
            G2A7_spc[2].seek = G2A7_spc[2 - 1].seek + G2A7_spc[2 - 1].length;
            G2A7_spc[2].length = G2A7_spc[2 - 1].length * 4;
            G2A7_spc[2].seeklength = 128;



        }
    }
}
