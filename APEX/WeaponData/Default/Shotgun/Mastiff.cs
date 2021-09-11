using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.WeaponData.Default.Shotgun
{
    class Mastiff
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }
        //需要修复
        public ReallyData[] Mastiff_col;
        public ReallyData[] Mastiff_nml;
        public ReallyData[] Mastiff_gls;
        public ReallyData[] Mastiff_spc;

        public Mastiff()
        {


            Mastiff_col = new ReallyData[3];
            Mastiff_nml = new ReallyData[3];
            Mastiff_gls = new ReallyData[3];
            Mastiff_spc = new ReallyData[3];

            //2为2048x2048,1为1024x1024,0为512x512

            //col
            Mastiff_col[0].name = "col";
            Mastiff_col[0].seek = 602521600;
            Mastiff_col[0].length = 131072;
            Mastiff_col[0].seeklength = 128;

            Mastiff_col[1].name = "col";
            Mastiff_col[1].seek = 7610044416;
            Mastiff_col[1].length = 524288;
            Mastiff_col[1].seeklength = 128;

            Mastiff_col[2].name = "col";
            Mastiff_col[2].seek = Mastiff_col[2 - 1].seek + Mastiff_col[2 - 1].length;
            Mastiff_col[2].length = Mastiff_col[2 - 1].length * 4;
            Mastiff_col[2].seeklength = 128;

            //nml
            Mastiff_nml[0].name = "nml";
            Mastiff_nml[0].seek = 602718208;
            Mastiff_nml[0].length = 262144;
            Mastiff_nml[0].seeklength = 128;

            Mastiff_nml[1].name = "nml";
            Mastiff_nml[1].seek = 7612665856;
            Mastiff_nml[1].length = 1048576;
            Mastiff_nml[1].seeklength = 128;

            Mastiff_nml[2].name = "nml";
            Mastiff_nml[2].seek = Mastiff_nml[2 - 1].seek + Mastiff_nml[2 - 1].length;
            Mastiff_nml[2].length = Mastiff_nml[2 - 1].length * 4;
            Mastiff_nml[2].seeklength = 128;

            //gls
            Mastiff_gls[0].name = "gls";
            Mastiff_gls[0].seek = 602980352;
            Mastiff_gls[0].length = 131072;
            Mastiff_gls[0].seeklength = 128;

            Mastiff_gls[1].name = "gls";
            Mastiff_gls[1].seek = 7617908736;
            Mastiff_gls[1].length = 524288;
            Mastiff_gls[1].seeklength = 128;

            Mastiff_gls[2].name = "gls";
            Mastiff_gls[2].seek = Mastiff_gls[2 - 1].seek + Mastiff_gls[2 - 1].length;
            Mastiff_gls[2].length = Mastiff_gls[2 - 1].length * 4;
            Mastiff_gls[2].seeklength = 128;

            //spc
            Mastiff_spc[0].name = "spc";
            Mastiff_spc[0].seek = 603111424;
            Mastiff_spc[0].length = 131072;
            Mastiff_spc[0].seeklength = 128;

            Mastiff_spc[1].name = "spc";
            Mastiff_spc[1].seek = 7620530176;
            Mastiff_spc[1].length = 524288;
            Mastiff_spc[1].seeklength = 128;

            Mastiff_spc[2].name = "spc";
            Mastiff_spc[2].seek = Mastiff_spc[2 - 1].seek + Mastiff_spc[2 - 1].length;
            Mastiff_spc[2].length = Mastiff_spc[2 - 1].length * 4;
            Mastiff_spc[2].seeklength = 128;



        }
    }
}
