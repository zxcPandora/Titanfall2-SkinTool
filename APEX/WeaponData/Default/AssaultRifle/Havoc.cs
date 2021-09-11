using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.WeaponData.Default.AssaultRifle
{
    class Havoc
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }
        //需要修复
        public ReallyData[] Havoc_col;
        public ReallyData[] Havoc_nml;
        public ReallyData[] Havoc_gls;
        public ReallyData[] Havoc_spc;

        public Havoc()
        {


            Havoc_col = new ReallyData[3];
            Havoc_nml = new ReallyData[3];
            Havoc_gls = new ReallyData[3];
            Havoc_spc = new ReallyData[3];

            //2为2048x2048,1为1024x1024,0为512x512

            //col
            Havoc_col[0].name = "col";
            Havoc_col[0].seek = 108388352;
            Havoc_col[0].length = 131072;
            Havoc_col[0].seeklength = 128;

            Havoc_col[1].name = "col";
            Havoc_col[1].seek = 6861623296;
            Havoc_col[1].length = 524288;
            Havoc_col[1].seeklength = 128;

            Havoc_col[2].name = "col";
            Havoc_col[2].seek = Havoc_col[2 - 1].seek + Havoc_col[2 - 1].length;
            Havoc_col[2].length = Havoc_col[2 - 1].length * 4;
            Havoc_col[2].seeklength = 128;

            //nml
            Havoc_col[0].name = "nml";
            Havoc_col[0].seek = 108584960;
            Havoc_col[0].length = 262144;
            Havoc_col[0].seeklength = 128;

            Havoc_nml[1].name = "nml";
            Havoc_nml[1].seek = 6864244736;
            Havoc_nml[1].length = 1048576;
            Havoc_nml[1].seeklength = 128;

            Havoc_nml[2].name = "nml";
            Havoc_nml[2].seek = Havoc_nml[2 - 1].seek + Havoc_nml[2 - 1].length;
            Havoc_nml[2].length = Havoc_nml[2 - 1].length * 4;
            Havoc_nml[2].seeklength = 128;

            //gls
            Havoc_gls[0].name = "gls";
            Havoc_gls[0].seek = 108847104;
            Havoc_gls[0].length = 131072;
            Havoc_gls[0].seeklength = 128;

            Havoc_gls[1].name = "gls";
            Havoc_gls[1].seek = 6869487616;
            Havoc_gls[1].length = 524288;
            Havoc_gls[1].seeklength = 128;

            Havoc_gls[2].name = "gls";
            Havoc_gls[2].seek = Havoc_gls[2 - 1].seek + Havoc_gls[2 - 1].length;
            Havoc_gls[2].length = Havoc_gls[2 - 1].length * 4;
            Havoc_gls[2].seeklength = 128;

            //spc
            Havoc_spc[0].name = "spc";
            Havoc_spc[0].seek = 108978176;
            Havoc_spc[0].length = 131072;
            Havoc_spc[0].seeklength = 128;

            Havoc_spc[1].name = "spc";
            Havoc_spc[1].seek = 6872109056;
            Havoc_spc[1].length = 524288;
            Havoc_spc[1].seeklength = 128;

            Havoc_spc[2].name = "spc";
            Havoc_spc[2].seek = Havoc_spc[2 - 1].seek + Havoc_spc[2 - 1].length;
            Havoc_spc[2].length = Havoc_spc[2 - 1].length * 4;
            Havoc_spc[2].seeklength = 128;



        }
    }
}
