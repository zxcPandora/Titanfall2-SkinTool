using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.WeaponData.Default.Shotgun
{
    class Mozambique
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }

        public ReallyData[] Mozambique_col;
        public ReallyData[] Mozambique_nml;
        public ReallyData[] Mozambique_gls;
        public ReallyData[] Mozambique_spc;
        public ReallyData[] Mozambique_ao;
        public ReallyData[] Mozambique_cav;
        public Mozambique()
        {


            Mozambique_col = new ReallyData[3];
            Mozambique_nml = new ReallyData[3];
            Mozambique_gls = new ReallyData[3];
            Mozambique_spc = new ReallyData[3];
            Mozambique_ao = new ReallyData[3];
            Mozambique_cav = new ReallyData[3];
            //2为2048x2048,1为1024x1024,0为512x512

            //col
            Mozambique_col[0].name = "col";
            Mozambique_col[0].seek = 7972982784;
            Mozambique_col[0].length = 131072;
            Mozambique_col[0].seeklength = 128;

            Mozambique_col[1].name = "col";
            Mozambique_col[1].seek = Mozambique_col[1 - 1].seek + Mozambique_col[1 - 1].length;
            Mozambique_col[1].length = Mozambique_col[1 - 1].length * 4;
            Mozambique_col[1].seeklength = 128;

            //nml
            Mozambique_nml[0].name = "nml";
            Mozambique_nml[0].seek = 7973638144;
            Mozambique_nml[0].length = 262144;
            Mozambique_nml[0].seeklength = 128;

            Mozambique_nml[1].name = "nml";
            Mozambique_nml[1].seek = Mozambique_nml[1 - 1].seek + Mozambique_nml[1 - 1].length;
            Mozambique_nml[1].length = Mozambique_nml[1 - 1].length * 4;
            Mozambique_nml[1].seeklength = 128;

            //gls
            Mozambique_gls[0].name = "gls";
            Mozambique_gls[0].seek = 7974948864;
            Mozambique_gls[0].length = 131072;
            Mozambique_gls[0].seeklength = 128;

            Mozambique_gls[1].name = "gls";
            Mozambique_gls[1].seek = Mozambique_gls[1 - 1].seek + Mozambique_gls[1 - 1].length;
            Mozambique_gls[1].length = Mozambique_gls[1 - 1].length * 4;
            Mozambique_gls[1].seeklength = 128;

            //spc
            Mozambique_spc[0].name = "spc";
            Mozambique_spc[0].seek = 7975604224;
            Mozambique_spc[0].length = 131072;
            Mozambique_spc[0].seeklength = 128;

            Mozambique_spc[1].name = "spc";
            Mozambique_spc[1].seek = Mozambique_spc[1 - 1].seek + Mozambique_spc[1 - 1].length;
            Mozambique_spc[1].length = Mozambique_spc[1 - 1].length * 4;
            Mozambique_spc[1].seeklength = 128;

            //ao
            Mozambique_ao[0].name = "ao";
            Mozambique_ao[0].seek = 7976259584;
            Mozambique_ao[0].length = 131072;
            Mozambique_ao[0].seeklength = 128;

            Mozambique_ao[1].name = "ao";
            Mozambique_ao[1].seek = Mozambique_ao[1 - 1].seek + Mozambique_ao[1 - 1].length;
            Mozambique_ao[1].length = Mozambique_ao[1 - 1].length * 4;
            Mozambique_ao[1].seeklength = 128;

            //cav
            Mozambique_cav[0].name = "cav";
            Mozambique_cav[0].seek = 7976914944;
            Mozambique_cav[0].length = 131072;
            Mozambique_cav[0].seeklength = 128;

            Mozambique_cav[1].name = "cav";
            Mozambique_cav[1].seek = Mozambique_cav[1 - 1].seek + Mozambique_cav[1 - 1].length;
            Mozambique_cav[1].length = Mozambique_cav[1 - 1].length * 4;
            Mozambique_cav[1].seeklength = 128;
        }
    }
}
