using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.WeaponData.Default.Sniper
{
    class TripleTake
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }

        public ReallyData[] TripleTake_col;
        public ReallyData[] TripleTake_nml;
        public ReallyData[] TripleTake_gls;
        public ReallyData[] TripleTake_spc;
        public ReallyData[] TripleTake_ilm;
        public ReallyData[] TripleTake_ao;
        public ReallyData[] TripleTake_cav;
        public TripleTake()
        {


            TripleTake_col = new ReallyData[3];
            TripleTake_nml = new ReallyData[3];
            TripleTake_gls = new ReallyData[3];
            TripleTake_spc = new ReallyData[3];
            TripleTake_ilm = new ReallyData[3];
            TripleTake_ao = new ReallyData[3];
            TripleTake_cav = new ReallyData[3];
            //2为2048x2048,1为1024x1024,0为512x512

            //col
            TripleTake_col[0].name = "col";
            TripleTake_col[0].seek = 524058624;
            TripleTake_col[0].length = 131072;
            TripleTake_col[0].seeklength = 128;

            TripleTake_col[1].name = "col";
            TripleTake_col[1].seek = 7012552704;
            TripleTake_col[1].length = 524288;
            TripleTake_col[1].seeklength = 128;

            TripleTake_col[2].name = "col";
            TripleTake_col[2].seek = TripleTake_col[2 - 1].seek + TripleTake_col[2 - 1].length;
            TripleTake_col[2].length = TripleTake_col[2 - 1].length * 4;
            TripleTake_col[2].seeklength = 128;

            //nml
            TripleTake_nml[0].name = "nml";
            TripleTake_nml[0].seek = 524255232;
            TripleTake_nml[0].length = 262144;
            TripleTake_nml[0].seeklength = 128;

            TripleTake_nml[1].name = "nml";
            TripleTake_nml[1].seek = 7015174144;
            TripleTake_nml[1].length = 1048576;
            TripleTake_nml[1].seeklength = 128;

            TripleTake_nml[2].name = "nml";
            TripleTake_nml[2].seek = TripleTake_nml[2 - 1].seek + TripleTake_nml[2 - 1].length;
            TripleTake_nml[2].length = TripleTake_nml[2 - 1].length * 4;
            TripleTake_nml[2].seeklength = 128;

            //gls
            TripleTake_gls[0].name = "gls";
            TripleTake_gls[0].seek = 524517376;
            TripleTake_gls[0].length = 131072;
            TripleTake_gls[0].seeklength = 128;

            TripleTake_gls[1].name = "gls";
            TripleTake_gls[1].seek = 7020417024;
            TripleTake_gls[1].length = 524288;
            TripleTake_gls[1].seeklength = 128;

            TripleTake_gls[2].name = "gls";
            TripleTake_gls[2].seek = TripleTake_gls[2 - 1].seek + TripleTake_gls[2 - 1].length;
            TripleTake_gls[2].length = TripleTake_gls[2 - 1].length * 4;
            TripleTake_gls[2].seeklength = 128;

            //spc
            TripleTake_spc[0].name = "spc";
            TripleTake_spc[0].seek = 524648448;
            TripleTake_spc[0].length = 131072;
            TripleTake_spc[0].seeklength = 128;

            TripleTake_spc[1].name = "spc";
            TripleTake_spc[1].seek = 7023038464;
            TripleTake_spc[1].length = 524288;
            TripleTake_spc[1].seeklength = 128;

            TripleTake_spc[2].name = "spc";
            TripleTake_spc[2].seek = TripleTake_spc[2 - 1].seek + TripleTake_spc[2 - 1].length;
            TripleTake_spc[2].length = TripleTake_spc[2 - 1].length * 4;
            TripleTake_spc[2].seeklength = 128;

            //ilm
            TripleTake_ilm[0].name = "ilm";
            TripleTake_ilm[0].seek = 524779520;
            TripleTake_ilm[0].length = 131072;
            TripleTake_ilm[0].seeklength = 128;

            TripleTake_ilm[1].name = "ilm";
            TripleTake_ilm[1].seek = 7025659904;
            TripleTake_ilm[1].length = 524288;
            TripleTake_ilm[1].seeklength = 128;

            TripleTake_ilm[2].name = "ilm";
            TripleTake_ilm[2].seek = TripleTake_ilm[2 - 1].seek + TripleTake_ilm[2 - 1].length;
            TripleTake_ilm[2].length = TripleTake_ilm[2 - 1].length * 4;
            TripleTake_ilm[2].seeklength = 128;

            //ao
            TripleTake_ao[0].name = "ao";
            TripleTake_ao[0].seek = 524910592;
            TripleTake_ao[0].length = 131072;
            TripleTake_ao[0].seeklength = 128;

            TripleTake_ao[1].name = "ao";
            TripleTake_ao[1].seek = 7028281344;
            TripleTake_ao[1].length = 524288;
            TripleTake_ao[1].seeklength = 128;

            TripleTake_ao[2].name = "ao";
            TripleTake_ao[2].seek = TripleTake_ao[2 - 1].seek + TripleTake_ao[2 - 1].length;
            TripleTake_ao[2].length = TripleTake_ao[2 - 1].length * 4;
            TripleTake_ao[2].seeklength = 128;

            //cav
            TripleTake_cav[0].name = "cav";
            TripleTake_cav[0].seek = 525041664;
            TripleTake_cav[0].length = 131072;
            TripleTake_cav[0].seeklength = 128;

            TripleTake_cav[1].name = "cav";
            TripleTake_cav[1].seek = 7030902784;
            TripleTake_cav[1].length = 524288;
            TripleTake_cav[1].seeklength = 128;

            TripleTake_cav[2].name = "cav";
            TripleTake_cav[2].seek = TripleTake_cav[2 - 1].seek + TripleTake_cav[2 - 1].length;
            TripleTake_cav[2].length = TripleTake_cav[2 - 1].length * 4;
            TripleTake_cav[2].seeklength = 128;
        }
    }
}
