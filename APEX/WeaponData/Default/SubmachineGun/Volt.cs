using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.WeaponData.Default.SubmachineGun
{
    class Volt
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }
        //需要修复
        public ReallyData[] Volt_col;
        public ReallyData[] Volt_nml;
        public ReallyData[] Volt_gls;
        public ReallyData[] Volt_spc;

        public Volt()
        {
            //int i = 1;

            Volt_col = new ReallyData[3];
            Volt_nml = new ReallyData[3];
            Volt_gls = new ReallyData[3];
            Volt_spc = new ReallyData[3];


            //col
            Volt_col[1].name = "col";
            Volt_col[1].seek = 331550720;
            Volt_col[1].length = 524288;
            Volt_col[1].seeklength = 128;

            Volt_col[2].name = "col";
            Volt_col[2].seek = Volt_col[2 - 1].seek + Volt_col[2 - 1].length;
            Volt_col[2].length = Volt_col[2 - 1].length * 4;
            Volt_col[2].seeklength = 128;

            //nml
            Volt_nml[1].name = "nml";
            Volt_nml[1].seek = 333778944;
            Volt_nml[1].length = 1048576;
            Volt_nml[1].seeklength = 128;

            Volt_nml[2].name = "nml";
            Volt_nml[2].seek = Volt_nml[2 - 1].seek + Volt_nml[2 - 1].length;
            Volt_nml[2].length = Volt_nml[2 - 1].length * 4;
            Volt_nml[2].seeklength = 128;

            //gls
            Volt_gls[1].name = "gls";
            Volt_gls[1].seek = 339415040;
            Volt_gls[1].length = 524288;
            Volt_gls[1].seeklength = 128;

            Volt_gls[2].name = "gls";
            Volt_gls[2].seek = Volt_gls[2 - 1].seek + Volt_gls[2 - 1].length;
            Volt_gls[2].length = Volt_gls[2 - 1].length * 4;
            Volt_gls[2].seeklength = 128;

            //spc
            Volt_spc[1].name = "spc";
            Volt_spc[1].seek = 342036480;
            Volt_spc[1].length = 524288;
            Volt_spc[1].seeklength = 128;

            Volt_spc[2].name = "spc";
            Volt_spc[2].seek = Volt_spc[2 - 1].seek + Volt_spc[2 - 1].length;
            Volt_spc[2].length = Volt_spc[2 - 1].length * 4;
            Volt_spc[2].seeklength = 128;


        }
    }
}

