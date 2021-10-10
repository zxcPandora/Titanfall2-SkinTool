using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.WeaponData.Default.Sniper
{
    class Kraber
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }

        public ReallyData[] Kraber_col;
        public ReallyData[] Kraber_nml;
        public ReallyData[] Kraber_gls;
        public ReallyData[] Kraber_spc;
        public ReallyData[] Kraber_ao;
        public ReallyData[] Kraber_cav;
        public Kraber()
        {


            Kraber_col = new ReallyData[3];
            Kraber_nml = new ReallyData[3];
            Kraber_gls = new ReallyData[3];
            Kraber_spc = new ReallyData[3];
            Kraber_ao = new ReallyData[3];
            Kraber_cav = new ReallyData[3];
            //2为2048x2048,1为1024x1024,0为512x512

            //col
            Kraber_col[0].name = "col";
            Kraber_col[0].seek = 257196032;
            Kraber_col[0].length = 131072;
            Kraber_col[0].seeklength = 128;

            Kraber_col[1].name = "col";
            Kraber_col[1].seek = 2967015424;
            Kraber_col[1].length = 524288;
            Kraber_col[1].seeklength = 128;

            Kraber_col[2].name = "col";
            Kraber_col[2].seek = Kraber_col[2 - 1].seek + Kraber_col[2 - 1].length;
            Kraber_col[2].length = Kraber_col[2 - 1].length * 4;
            Kraber_col[2].seeklength = 128;

            //nml
            Kraber_nml[0].name = "nml";
            Kraber_nml[0].seek = 257392640;
            Kraber_nml[0].length = 262144;
            Kraber_nml[0].seeklength = 128;

            Kraber_nml[1].name = "nml";
            Kraber_nml[1].seek = 2969636864;
            Kraber_nml[1].length = 1048576;
            Kraber_nml[1].seeklength = 128;

            Kraber_nml[2].name = "nml";
            Kraber_nml[2].seek = Kraber_nml[2 - 1].seek + Kraber_nml[2 - 1].length;
            Kraber_nml[2].length = Kraber_nml[2 - 1].length * 4;
            Kraber_nml[2].seeklength = 128;

            //gls
            Kraber_gls[0].name = "gls";
            Kraber_gls[0].seek = 257654784;
            Kraber_gls[0].length = 131072;
            Kraber_gls[0].seeklength = 128;

            Kraber_gls[1].name = "gls";
            Kraber_gls[1].seek = 2974879744;
            Kraber_gls[1].length = 524288;
            Kraber_gls[1].seeklength = 128;

            Kraber_gls[2].name = "gls";
            Kraber_gls[2].seek = Kraber_gls[2 - 1].seek + Kraber_gls[2 - 1].length;
            Kraber_gls[2].length = Kraber_gls[2 - 1].length * 4;
            Kraber_gls[2].seeklength = 128;

            //spc
            Kraber_spc[0].name = "spc";
            Kraber_spc[0].seek = 257785856;
            Kraber_spc[0].length = 131072;
            Kraber_spc[0].seeklength = 128;

            Kraber_spc[1].name = "spc";
            Kraber_spc[1].seek = 2977501184;
            Kraber_spc[1].length = 524288;
            Kraber_spc[1].seeklength = 128;

            Kraber_spc[2].name = "spc";
            Kraber_spc[2].seek = Kraber_spc[2 - 1].seek + Kraber_spc[2 - 1].length;
            Kraber_spc[2].length = Kraber_spc[2 - 1].length * 4;
            Kraber_spc[2].seeklength = 128;

            //ao
            Kraber_ao[0].name = "ao";
            Kraber_ao[0].seek = 257916928;
            Kraber_ao[0].length = 131072;
            Kraber_ao[0].seeklength = 128;

            Kraber_ao[1].name = "ao";
            Kraber_ao[1].seek = 2980122624;
            Kraber_ao[1].length = 524288;
            Kraber_ao[1].seeklength = 128;

            Kraber_ao[2].name = "ao";
            Kraber_ao[2].seek = Kraber_ao[2 - 1].seek + Kraber_ao[2 - 1].length;
            Kraber_ao[2].length = Kraber_ao[2 - 1].length * 4;
            Kraber_ao[2].seeklength = 128;

            //cav
            Kraber_cav[0].name = "cav";
            Kraber_cav[0].seek = 258048000;
            Kraber_cav[0].length = 131072;
            Kraber_cav[0].seeklength = 128;

            Kraber_cav[1].name = "cav";
            Kraber_cav[1].seek = 2982744064;
            Kraber_cav[1].length = 524288;
            Kraber_cav[1].seeklength = 128;

            Kraber_cav[2].name = "cav";
            Kraber_cav[2].seek = Kraber_cav[2 - 1].seek + Kraber_cav[2 - 1].length;
            Kraber_cav[2].length = Kraber_cav[2 - 1].length * 4;
            Kraber_cav[2].seeklength = 128;
        }
    }
}
