using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.WeaponData.Default.Shotgun
{
    class Peacekeeper
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }
        //需要修复
        public ReallyData[] Peacekeeper_col;
        public ReallyData[] Peacekeeper_nml;
        public ReallyData[] Peacekeeper_gls;
        public ReallyData[] Peacekeeper_spc;

        public Peacekeeper()
        {


            Peacekeeper_col = new ReallyData[3];
            Peacekeeper_nml = new ReallyData[3];
            Peacekeeper_gls = new ReallyData[3];
            Peacekeeper_spc = new ReallyData[3];

            //2为2048x2048,1为1024x1024,0为512x512

            Peacekeeper_col[1].name = "col";
            Peacekeeper_col[1].seek = 198840320;
            Peacekeeper_col[1].length = 524288;
            Peacekeeper_col[1].seeklength = 128;

            Peacekeeper_col[2].name = "col";
            Peacekeeper_col[2].seek = Peacekeeper_col[2 - 1].seek + Peacekeeper_col[2 - 1].length;
            Peacekeeper_col[2].length = Peacekeeper_col[2 - 1].length * 4;
            Peacekeeper_col[2].seeklength = 128;


            Peacekeeper_nml[1].name = "nml";
            Peacekeeper_nml[1].seek = 201461760;
            Peacekeeper_nml[1].length = 1048576;
            Peacekeeper_nml[1].seeklength = 128;

            Peacekeeper_nml[2].name = "nml";
            Peacekeeper_nml[2].seek = Peacekeeper_nml[2 - 1].seek + Peacekeeper_nml[2 - 1].length;
            Peacekeeper_nml[2].length = Peacekeeper_nml[2 - 1].length * 4;
            Peacekeeper_nml[2].seeklength = 128;


            Peacekeeper_gls[1].name = "gls";
            Peacekeeper_gls[1].seek = 206704640;
            Peacekeeper_gls[1].length = 524288;
            Peacekeeper_gls[1].seeklength = 128;

            Peacekeeper_gls[2].name = "gls";
            Peacekeeper_gls[2].seek = Peacekeeper_gls[2 - 1].seek + Peacekeeper_gls[2 - 1].length;
            Peacekeeper_gls[2].length = Peacekeeper_gls[2 - 1].length * 4;
            Peacekeeper_gls[2].seeklength = 128;


            Peacekeeper_spc[1].name = "spc";
            Peacekeeper_spc[1].seek = 209326080;
            Peacekeeper_spc[1].length = 524288;
            Peacekeeper_spc[1].seeklength = 128;

            Peacekeeper_spc[2].name = "spc";
            Peacekeeper_spc[2].seek = Peacekeeper_spc[2 - 1].seek + Peacekeeper_spc[2 - 1].length;
            Peacekeeper_spc[2].length = Peacekeeper_spc[2 - 1].length * 4;
            Peacekeeper_spc[2].seeklength = 128;



        }
    }
}
