using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.WeaponData.Default.LightMachineGun
{
    class Spitfire
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }
        //需要修复
        public ReallyData[] Spitfire_col;
        public ReallyData[] Spitfire_nml;
        public ReallyData[] Spitfire_gls;
        public ReallyData[] Spitfire_spc;

        public Spitfire()
        {


            Spitfire_col = new ReallyData[3];
            Spitfire_nml = new ReallyData[3];
            Spitfire_gls = new ReallyData[3];
            Spitfire_spc = new ReallyData[3];

            //2为2048x2048,1为1024x1024,0为512x512

            Spitfire_col[1].name = "col";
            Spitfire_col[1].seek = 7260082176;
            Spitfire_col[1].length = 524288;
            Spitfire_col[1].seeklength = 128;

            Spitfire_col[2].name = "col";
            Spitfire_col[2].seek = Spitfire_col[2 - 1].seek + Spitfire_col[2 - 1].length;
            Spitfire_col[2].length = Spitfire_col[2 - 1].length * 4;
            Spitfire_col[2].seeklength = 128;


            Spitfire_nml[1].name = "nml";
            Spitfire_nml[1].seek = 7262703616;
            Spitfire_nml[1].length = 1048576;
            Spitfire_nml[1].seeklength = 128;

            Spitfire_nml[2].name = "nml";
            Spitfire_nml[2].seek = Spitfire_nml[2 - 1].seek + Spitfire_nml[2 - 1].length;
            Spitfire_nml[2].length = Spitfire_nml[2 - 1].length * 4;
            Spitfire_nml[2].seeklength = 128;


            Spitfire_gls[1].name = "gls";
            Spitfire_gls[1].seek = 7267946496;
            Spitfire_gls[1].length = 524288;
            Spitfire_gls[1].seeklength = 128;

            Spitfire_gls[2].name = "gls";
            Spitfire_gls[2].seek = Spitfire_gls[2 - 1].seek + Spitfire_gls[2 - 1].length;
            Spitfire_gls[2].length = Spitfire_gls[2 - 1].length * 4;
            Spitfire_gls[2].seeklength = 128;


            Spitfire_spc[1].name = "spc";
            Spitfire_spc[1].seek = 7270567936;
            Spitfire_spc[1].length = 524288;
            Spitfire_spc[1].seeklength = 128;

            Spitfire_spc[2].name = "spc";
            Spitfire_spc[2].seek = Spitfire_spc[2 - 1].seek + Spitfire_spc[2 - 1].length;
            Spitfire_spc[2].length = Spitfire_spc[2 - 1].length * 4;
            Spitfire_spc[2].seeklength = 128;



        }
    }
}
