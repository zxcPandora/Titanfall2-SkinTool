using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.WeaponData.Default.AssaultRifle
{
    class R301
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }

        public ReallyData[] R301_col;
        public ReallyData[] R301_nml;
        public ReallyData[] R301_gls;
        public ReallyData[] R301_spc;
        public ReallyData[] R301_ao;
        public ReallyData[] R301_cav;

        //r301 没有ilm贴图
        /*public ReallyData[] R301_ilm;*/
        public R301()
        {
            //int i = 1;

            R301_col = new ReallyData[3];
            R301_nml = new ReallyData[3];
            R301_gls = new ReallyData[3];
            R301_spc = new ReallyData[3];
            R301_ao = new ReallyData[3];
            R301_cav = new ReallyData[3];
            //2为2048x2048,1为1024x1024,0为512x512

            //col
            R301_col[0].name = "col";
            R301_col[0].seek = 108388352;
            R301_col[0].length = 131072;
            R301_col[0].seeklength = 128;

            R301_col[1].name = "col";
            R301_col[1].seek = 713232384;
            R301_col[1].length = 524288;
            R301_col[1].seeklength = 128;

            R301_col[2].name = "col";
            R301_col[2].seek = R301_col[2 - 1].seek + R301_col[2 - 1].length;
            R301_col[2].length = R301_col[2 - 1].length * 4;
            R301_col[2].seeklength = 128;

            //nml
            R301_nml[0].name = "nml";
            R301_nml[0].seek = 108584960;
            R301_nml[0].length = 262144;
            R301_nml[0].seeklength = 128;

            R301_nml[1].name = "nml";
            R301_nml[1].seek = 715853824;
            R301_nml[1].length = 1048576;
            R301_nml[1].seeklength = 128;

            R301_nml[2].name = "nml";
            R301_nml[2].seek = R301_nml[2 - 1].seek + R301_nml[2 - 1].length;
            R301_nml[2].length = R301_nml[2 - 1].length * 4;
            R301_nml[2].seeklength = 128;

            //gls
            R301_gls[0].name = "gls";
            R301_gls[0].seek = 108847104;
            R301_gls[0].length = 131072;
            R301_gls[0].seeklength = 128;

            R301_gls[1].name = "gls";
            R301_gls[1].seek = 721096704;
            R301_gls[1].length = 524288;
            R301_gls[1].seeklength = 128;

            R301_gls[2].name = "gls";
            R301_gls[2].seek = R301_gls[2 - 1].seek + R301_gls[2 - 1].length;
            R301_gls[2].length = R301_gls[2 - 1].length * 4;
            R301_gls[2].seeklength = 128;

            //spc
            R301_spc[0].name = "spc";
            R301_spc[0].seek = 108978176;
            R301_spc[0].length = 131072;
            R301_spc[0].seeklength = 128;

            R301_spc[1].name = "spc";
            R301_spc[1].seek = 723718144;
            R301_spc[1].length = 524288;
            R301_spc[1].seeklength = 128;

            R301_spc[2].name = "spc";
            R301_spc[2].seek = R301_spc[2 - 1].seek + R301_spc[2 - 1].length;
            R301_spc[2].length = R301_spc[2 - 1].length * 4;
            R301_spc[2].seeklength = 128;

            //ao
            R301_ao[0].name = "ao";
            R301_ao[0].seek = 109109248;
            R301_ao[0].length = 131072;
            R301_ao[0].seeklength = 128;

            R301_ao[1].name = "ao";
            R301_ao[1].seek = 726339584;
            R301_ao[1].length = 524288;
            R301_ao[1].seeklength = 128;

            R301_ao[2].name = "ao";
            R301_ao[2].seek = R301_ao[2 - 1].seek + R301_ao[2 - 1].length;
            R301_ao[2].length = R301_ao[2 - 1].length * 4;
            R301_ao[2].seeklength = 128;

            //cav
            R301_cav[0].name = "cav";
            R301_cav[0].seek = 109240320;
            R301_cav[0].length = 131072;
            R301_cav[0].seeklength = 128;

            R301_cav[1].name = "cav";
            R301_cav[1].seek = 728961024;
            R301_cav[1].length = 524288;
            R301_cav[1].seeklength = 128;

            R301_cav[2].name = "cav";
            R301_cav[2].seek = R301_cav[2 - 1].seek + R301_cav[2 - 1].length;
            R301_cav[2].length = R301_cav[2 - 1].length * 4;
            R301_cav[2].seeklength = 128;

            //R301没有ilm贴图
        }
    }
}
