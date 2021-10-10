using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.WeaponData.Default.AssaultRifle
{
    class Hemlok
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }

        public ReallyData[] Hemlok_col;
        public ReallyData[] Hemlok_nml;
        public ReallyData[] Hemlok_gls;
        public ReallyData[] Hemlok_spc;
        public ReallyData[] Hemlok_ao;
        public ReallyData[] Hemlok_cav;
        public Hemlok()
        {
            

            Hemlok_col = new ReallyData[3];
            Hemlok_nml = new ReallyData[3];
            Hemlok_gls = new ReallyData[3];
            Hemlok_spc = new ReallyData[3];
            Hemlok_ao = new ReallyData[3];
            Hemlok_cav = new ReallyData[3];
            //2为2048x2048,1为1024x1024,0为512x512

            //col
            Hemlok_col[0].name = "col";
            Hemlok_col[0].seek = 585351168;
            Hemlok_col[0].length = 131072;
            Hemlok_col[0].seeklength = 128;

            Hemlok_col[1].name = "col";
            Hemlok_col[1].seek = 7431786496;
            Hemlok_col[1].length = 524288;
            Hemlok_col[1].seeklength = 128;

            Hemlok_col[2].name = "col";
            Hemlok_col[2].seek = Hemlok_col[2 - 1].seek + Hemlok_col[2 - 1].length;
            Hemlok_col[2].length = Hemlok_col[2 - 1].length * 4;
            Hemlok_col[2].seeklength = 128;

            //nml
            Hemlok_nml[0].name = "nml";
            Hemlok_nml[0].seek = 585547776;
            Hemlok_nml[0].length = 262144;
            Hemlok_nml[0].seeklength = 128;

            Hemlok_nml[1].name = "nml";
            Hemlok_nml[1].seek = 7434407936;
            Hemlok_nml[1].length = 1048576;
            Hemlok_nml[1].seeklength = 128;

            Hemlok_nml[2].name = "nml";
            Hemlok_nml[2].seek = Hemlok_nml[2 - 1].seek + Hemlok_nml[2 - 1].length;
            Hemlok_nml[2].length = Hemlok_nml[2 - 1].length * 4;
            Hemlok_nml[2].seeklength = 128;

            //gls
            Hemlok_gls[0].name = "gls";
            Hemlok_gls[0].seek = 585809920;
            Hemlok_gls[0].length = 131072;
            Hemlok_gls[0].seeklength = 128;

            Hemlok_gls[1].name = "gls";
            Hemlok_gls[1].seek = 7439650816;
            Hemlok_gls[1].length = 524288;
            Hemlok_gls[1].seeklength = 128;

            Hemlok_gls[2].name = "gls";
            Hemlok_gls[2].seek = Hemlok_gls[2 - 1].seek + Hemlok_gls[2 - 1].length;
            Hemlok_gls[2].length = Hemlok_gls[2 - 1].length * 4;
            Hemlok_gls[2].seeklength = 128;

            //spc
            Hemlok_spc[0].name = "spc";
            Hemlok_spc[0].seek = 585940992;
            Hemlok_spc[0].length = 131072;
            Hemlok_spc[0].seeklength = 128;

            Hemlok_spc[1].name = "spc";
            Hemlok_spc[1].seek = 7442272256;
            Hemlok_spc[1].length = 524288;
            Hemlok_spc[1].seeklength = 128;

            Hemlok_spc[2].name = "spc";
            Hemlok_spc[2].seek = Hemlok_spc[2 - 1].seek + Hemlok_spc[2 - 1].length;
            Hemlok_spc[2].length = Hemlok_spc[2 - 1].length * 4;
            Hemlok_spc[2].seeklength = 128;

            //ao
            Hemlok_ao[0].name = "ao";
            Hemlok_ao[0].seek = 586072064;
            Hemlok_ao[0].length = 131072;
            Hemlok_ao[0].seeklength = 128;

            Hemlok_ao[1].name = "ao";
            Hemlok_ao[1].seek = 7444893696;
            Hemlok_ao[1].length = 524288;
            Hemlok_ao[1].seeklength = 128;

            Hemlok_ao[2].name = "ao";
            Hemlok_ao[2].seek = Hemlok_ao[2 - 1].seek + Hemlok_ao[2 - 1].length;
            Hemlok_ao[2].length = Hemlok_ao[2 - 1].length * 4;
            Hemlok_ao[2].seeklength = 128;

            //cav
            Hemlok_cav[0].name = "cav";
            Hemlok_cav[0].seek = 586203136;
            Hemlok_cav[0].length = 131072;
            Hemlok_cav[0].seeklength = 128;

            Hemlok_cav[1].name = "cav";
            Hemlok_cav[1].seek = 7447515136;
            Hemlok_cav[1].length = 524288;
            Hemlok_cav[1].seeklength = 128;

            Hemlok_cav[2].name = "cav";
            Hemlok_cav[2].seek = Hemlok_cav[2 - 1].seek + Hemlok_cav[2 - 1].length;
            Hemlok_cav[2].length = Hemlok_cav[2 - 1].length * 4;
            Hemlok_cav[2].seeklength = 128;
        }
    }
}
