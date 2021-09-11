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
        //需要修复
        public ReallyData[] TripleTake_col;
        public ReallyData[] TripleTake_nml;
        public ReallyData[] TripleTake_gls;
        public ReallyData[] TripleTake_spc;

        public TripleTake()
        {


            TripleTake_col = new ReallyData[3];
            TripleTake_nml = new ReallyData[3];
            TripleTake_gls = new ReallyData[3];
            TripleTake_spc = new ReallyData[3];

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



        }
    }
}
