using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.WeaponData.Default.AssaultRifle
{
    class VK47Flatline
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }
        //需要修复
        public ReallyData[] VK47Flatline_col;
        public ReallyData[] VK47Flatline_nml;
        public ReallyData[] VK47Flatline_gls;
        public ReallyData[] VK47Flatline_spc;

        public VK47Flatline()
        {


            VK47Flatline_col = new ReallyData[3];
            VK47Flatline_nml = new ReallyData[3];
            VK47Flatline_gls = new ReallyData[3];
            VK47Flatline_spc = new ReallyData[3];

            //2为2048x2048,1为1024x1024,0为512x512

            VK47Flatline_col[1].name = "col";
            VK47Flatline_col[1].seek = 7431786496;
            VK47Flatline_col[1].length = 524288;
            VK47Flatline_col[1].seeklength = 128;

            VK47Flatline_col[2].name = "col";
            VK47Flatline_col[2].seek = VK47Flatline_col[2 - 1].seek + VK47Flatline_col[2 - 1].length;
            VK47Flatline_col[2].length = VK47Flatline_col[2 - 1].length * 4;
            VK47Flatline_col[2].seeklength = 128;


            VK47Flatline_nml[1].name = "nml";
            VK47Flatline_nml[1].seek = 7434407936;
            VK47Flatline_nml[1].length = 1048576;
            VK47Flatline_nml[1].seeklength = 128;

            VK47Flatline_nml[2].name = "nml";
            VK47Flatline_nml[2].seek = VK47Flatline_nml[2 - 1].seek + VK47Flatline_nml[2 - 1].length;
            VK47Flatline_nml[2].length = VK47Flatline_nml[2 - 1].length * 4;
            VK47Flatline_nml[2].seeklength = 128;


            VK47Flatline_gls[1].name = "gls";
            VK47Flatline_gls[1].seek = 7439650816;
            VK47Flatline_gls[1].length = 524288;
            VK47Flatline_gls[1].seeklength = 128;

            VK47Flatline_gls[2].name = "gls";
            VK47Flatline_gls[2].seek = VK47Flatline_gls[2 - 1].seek + VK47Flatline_gls[2 - 1].length;
            VK47Flatline_gls[2].length = VK47Flatline_gls[2 - 1].length * 4;
            VK47Flatline_gls[2].seeklength = 128;


            VK47Flatline_spc[1].name = "spc";
            VK47Flatline_spc[1].seek = 7442272256;
            VK47Flatline_spc[1].length = 524288;
            VK47Flatline_spc[1].seeklength = 128;

            VK47Flatline_spc[2].name = "spc";
            VK47Flatline_spc[2].seek = VK47Flatline_spc[2 - 1].seek + VK47Flatline_spc[2 - 1].length;
            VK47Flatline_spc[2].length = VK47Flatline_spc[2 - 1].length * 4;
            VK47Flatline_spc[2].seeklength = 128;



        }
    }
}
