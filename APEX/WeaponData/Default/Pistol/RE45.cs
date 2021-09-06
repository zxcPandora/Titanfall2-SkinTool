using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.WeaponData.Default.Pistol
{
    class RE45
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }
        //需要修复
        public ReallyData[] RE45_col;
        public ReallyData[] RE45_nml;
        public ReallyData[] RE45_gls;
        public ReallyData[] RE45_spc;

        public RE45()
        {


            RE45_col = new ReallyData[3];
            RE45_nml = new ReallyData[3];
            RE45_gls = new ReallyData[3];
            RE45_spc = new ReallyData[3];

            //2为2048x2048,1为1024x1024,0为512x512

            RE45_col[0].name = "col";
            RE45_col[0].seek = 7772114944;
            RE45_col[0].length = 131072;
            RE45_col[0].seeklength = 128;

            RE45_col[1].name = "col";
            RE45_col[1].seek = RE45_col[2 - 1].seek + RE45_col[2 - 1].length;
            RE45_col[1].length = RE45_col[2 - 1].length * 4;
            RE45_col[1].seeklength = 128;


            RE45_nml[0].name = "nml";
            RE45_nml[0].seek = 7772770304;
            RE45_nml[0].length = 262144;
            RE45_nml[0].seeklength = 128;

            RE45_nml[1].name = "nml";
            RE45_nml[1].seek = RE45_nml[2 - 1].seek + RE45_nml[2 - 1].length;
            RE45_nml[1].length = RE45_nml[2 - 1].length * 4;
            RE45_nml[1].seeklength = 128;


            RE45_gls[0].name = "gls";
            RE45_gls[0].seek = 7778013184;
            RE45_gls[0].length = 131072;
            RE45_gls[0].seeklength = 128;

            RE45_gls[1].name = "gls";
            RE45_gls[1].seek = RE45_gls[2 - 1].seek + RE45_gls[2 - 1].length;
            RE45_gls[1].length = RE45_gls[2 - 1].length * 4;
            RE45_gls[1].seeklength = 128;


            RE45_spc[0].name = "spc";
            RE45_spc[0].seek = 7778668544;
            RE45_spc[0].length = 131072;
            RE45_spc[0].seeklength = 128;

            RE45_spc[1].name = "spc";
            RE45_spc[1].seek = RE45_spc[2 - 1].seek + RE45_spc[2 - 1].length;
            RE45_spc[1].length = RE45_spc[2 - 1].length * 4;
            RE45_spc[1].seeklength = 128;



        }
    }
}
