using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.WeaponData.Default.SubmachineGun
{
    class R99
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }
        //需要修复
        public ReallyData[] R99_col;
        public ReallyData[] R99_nml;
        public ReallyData[] R99_gls;
        public ReallyData[] R99_spc;

        public R99()
        {


            R99_col = new ReallyData[3];
            R99_nml = new ReallyData[3];
            R99_gls = new ReallyData[3];
            R99_spc = new ReallyData[3];

            //2为2048x2048,1为1024x1024,0为512x512

            R99_col[1].name = "col";
            R99_col[1].seek = 7984779264;
            R99_col[1].length = 524288;
            R99_col[1].seeklength = 128;

            R99_col[2].name = "col";
            R99_col[2].seek = R99_col[2 - 1].seek + R99_col[2 - 1].length;
            R99_col[2].length = R99_col[2 - 1].length * 4;
            R99_col[2].seeklength = 128;


            R99_nml[1].name = "nml";
            R99_nml[1].seek = 7987400704;
            R99_nml[1].length = 1048576;
            R99_nml[1].seeklength = 128;

            R99_nml[2].name = "nml";
            R99_nml[2].seek = R99_nml[2 - 1].seek + R99_nml[2 - 1].length;
            R99_nml[2].length = R99_nml[2 - 1].length * 4;
            R99_nml[2].seeklength = 128;


            R99_gls[1].name = "gls";
            R99_gls[1].seek = 7992643584;
            R99_gls[1].length = 524288;
            R99_gls[1].seeklength = 128;

            R99_gls[2].name = "gls";
            R99_gls[2].seek = R99_gls[2 - 1].seek + R99_gls[2 - 1].length;
            R99_gls[2].length = R99_gls[2 - 1].length * 4;
            R99_gls[2].seeklength = 128;


            R99_spc[1].name = "spc";
            R99_spc[1].seek = 7995265024;
            R99_spc[1].length = 524288;
            R99_spc[1].seeklength = 128;

            R99_spc[2].name = "spc";
            R99_spc[2].seek = R99_spc[2 - 1].seek + R99_spc[2 - 1].length;
            R99_spc[2].length = R99_spc[2 - 1].length * 4;
            R99_spc[2].seeklength = 128;



        }
    }
}
