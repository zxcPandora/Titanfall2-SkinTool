using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.WeaponData.Default.SubmachineGun
{
    class PDW
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }

        public ReallyData[] PDW_col;
        public ReallyData[] PDW_nml;
        public ReallyData[] PDW_gls;
        public ReallyData[] PDW_spc;
        public ReallyData[] PDW_ao;
        public ReallyData[] PDW_cav;
        public PDW()
        {


            PDW_col = new ReallyData[3];
            PDW_nml = new ReallyData[3];
            PDW_gls = new ReallyData[3];
            PDW_spc = new ReallyData[3];
            PDW_ao = new ReallyData[3];
            PDW_cav = new ReallyData[3];
            //2为2048x2048,1为1024x1024,0为512x512

            //col
            PDW_col[0].name = "col";
            PDW_col[0].seek = 637759488;
            PDW_col[0].length = 131072;
            PDW_col[0].seeklength = 128;

            PDW_col[1].name = "col";
            PDW_col[1].seek = 7906791424;
            PDW_col[1].length = 524288;
            PDW_col[1].seeklength = 128;

            PDW_col[2].name = "col";
            PDW_col[2].seek = PDW_col[2 - 1].seek + PDW_col[2 - 1].length;
            PDW_col[2].length = PDW_col[2 - 1].length * 4;
            PDW_col[2].seeklength = 128;

            //nml
            PDW_nml[0].name = "nml";
            PDW_nml[0].seek = 637956096;
            PDW_nml[0].length = 262144;
            PDW_nml[0].seeklength = 128;

            PDW_nml[1].name = "nml";
            PDW_nml[1].seek = 7909412864;
            PDW_nml[1].length = 1048576;
            PDW_nml[1].seeklength = 128;

            PDW_nml[2].name = "nml";
            PDW_nml[2].seek = PDW_nml[2 - 1].seek + PDW_nml[2 - 1].length;
            PDW_nml[2].length = PDW_nml[2 - 1].length * 4;
            PDW_nml[2].seeklength = 128;

            //gls
            PDW_gls[0].name = "gls";
            PDW_gls[0].seek = 638218240;
            PDW_gls[0].length = 131072;
            PDW_gls[0].seeklength = 128;

            PDW_gls[1].name = "gls";
            PDW_gls[1].seek = 7914655744;
            PDW_gls[1].length = 524288;
            PDW_gls[1].seeklength = 128;

            PDW_gls[2].name = "gls";
            PDW_gls[2].seek = PDW_gls[2 - 1].seek + PDW_gls[2 - 1].length;
            PDW_gls[2].length = PDW_gls[2 - 1].length * 4;
            PDW_gls[2].seeklength = 128;

            //spc
            PDW_spc[0].name = "spc";
            PDW_spc[0].seek = 638349312;
            PDW_spc[0].length = 131072;
            PDW_spc[0].seeklength = 128;

            PDW_spc[1].name = "spc";
            PDW_spc[1].seek = 7917277184;
            PDW_spc[1].length = 524288;
            PDW_spc[1].seeklength = 128;

            PDW_spc[2].name = "spc";
            PDW_spc[2].seek = PDW_spc[2 - 1].seek + PDW_spc[2 - 1].length;
            PDW_spc[2].length = PDW_spc[2 - 1].length * 4;
            PDW_spc[2].seeklength = 128;

            //ao
            PDW_ao[0].name = "ao";
            PDW_ao[0].seek = 638480384;
            PDW_ao[0].length = 131072;
            PDW_ao[0].seeklength = 128;

            PDW_ao[1].name = "ao";
            PDW_ao[1].seek = 7919898624;
            PDW_ao[1].length = 524288;
            PDW_ao[1].seeklength = 128;

            PDW_ao[2].name = "ao";
            PDW_ao[2].seek = PDW_ao[2 - 1].seek + PDW_ao[2 - 1].length;
            PDW_ao[2].length = PDW_ao[2 - 1].length * 4;
            PDW_ao[2].seeklength = 128;

            //cav
            PDW_cav[0].name = "cav";
            PDW_cav[0].seek = 638611456;
            PDW_cav[0].length = 131072;
            PDW_cav[0].seeklength = 128;

            PDW_cav[1].name = "cav";
            PDW_cav[1].seek = 7922520064;
            PDW_cav[1].length = 524288;
            PDW_cav[1].seeklength = 128;

            PDW_cav[2].name = "cav";
            PDW_cav[2].seek = PDW_cav[2 - 1].seek + PDW_cav[2 - 1].length;
            PDW_cav[2].length = PDW_cav[2 - 1].length * 4;
            PDW_cav[2].seeklength = 128;
        }
    }
}
