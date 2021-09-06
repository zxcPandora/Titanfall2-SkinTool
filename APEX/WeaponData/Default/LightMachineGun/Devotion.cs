using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.WeaponData.Default.LightMachineGun
{
    class Devotion
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }
        //需要修复
        public ReallyData[] Devotion_col;
        public ReallyData[] Devotion_nml;
        public ReallyData[] Devotion_gls;
        public ReallyData[] Devotion_spc;

        public Devotion()
        {


            Devotion_col = new ReallyData[3];
            Devotion_nml = new ReallyData[3];
            Devotion_gls = new ReallyData[3];
            Devotion_spc = new ReallyData[3];

            //2为2048x2048,1为1024x1024,0为512x512

            Devotion_col[1].name = "col";
            Devotion_col[1].seek = 7199789056;
            Devotion_col[1].length = 524288;
            Devotion_col[1].seeklength = 128;

            Devotion_col[2].name = "col";
            Devotion_col[2].seek = Devotion_col[2 - 1].seek + Devotion_col[2 - 1].length;
            Devotion_col[2].length = Devotion_col[2 - 1].length * 4;
            Devotion_col[2].seeklength = 128;


            Devotion_nml[1].name = "nml";
            Devotion_nml[1].seek = 7202410496;
            Devotion_nml[1].length = 1048576;
            Devotion_nml[1].seeklength = 128;

            Devotion_nml[2].name = "nml";
            Devotion_nml[2].seek = Devotion_nml[2 - 1].seek + Devotion_nml[2 - 1].length;
            Devotion_nml[2].length = Devotion_nml[2 - 1].length * 4;
            Devotion_nml[2].seeklength = 128;


            Devotion_gls[1].name = "gls";
            Devotion_gls[1].seek = 7207653376;
            Devotion_gls[1].length = 524288;
            Devotion_gls[1].seeklength = 128;

            Devotion_gls[2].name = "gls";
            Devotion_gls[2].seek = Devotion_gls[2 - 1].seek + Devotion_gls[2 - 1].length;
            Devotion_gls[2].length = Devotion_gls[2 - 1].length * 4;
            Devotion_gls[2].seeklength = 128;


            Devotion_spc[1].name = "spc";
            Devotion_spc[1].seek = 7210274816;
            Devotion_spc[1].length = 524288;
            Devotion_spc[1].seeklength = 128;

            Devotion_spc[2].name = "spc";
            Devotion_spc[2].seek = Devotion_spc[2 - 1].seek + Devotion_spc[2 - 1].length;
            Devotion_spc[2].length = Devotion_spc[2 - 1].length * 4;
            Devotion_spc[2].seeklength = 128;



        }
    }
}
