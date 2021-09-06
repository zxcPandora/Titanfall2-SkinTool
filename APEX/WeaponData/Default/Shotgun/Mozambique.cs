using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.WeaponData.Default.Shotgun
{
    class Mozambique
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }
        //需要修复
        public ReallyData[] Mozambique_col;
        public ReallyData[] Mozambique_nml;
        public ReallyData[] Mozambique_gls;
        public ReallyData[] Mozambique_spc;

        public Mozambique()
        {


            Mozambique_col = new ReallyData[3];
            Mozambique_nml = new ReallyData[3];
            Mozambique_gls = new ReallyData[3];
            Mozambique_spc = new ReallyData[3];

            //2为2048x2048,1为1024x1024,0为512x512

            Mozambique_col[0].name = "col";
            Mozambique_col[0].seek = 7972982784;
            Mozambique_col[0].length = 131072;
            Mozambique_col[0].seeklength = 128;

            Mozambique_col[1].name = "col";
            Mozambique_col[1].seek = Mozambique_col[2 - 1].seek + Mozambique_col[2 - 1].length;
            Mozambique_col[1].length = Mozambique_col[2 - 1].length * 4;
            Mozambique_col[1].seeklength = 128;


            Mozambique_nml[0].name = "nml";
            Mozambique_nml[0].seek = 7973638144;
            Mozambique_nml[0].length = 262144;
            Mozambique_nml[0].seeklength = 128;

            Mozambique_nml[1].name = "nml";
            Mozambique_nml[1].seek = Mozambique_nml[2 - 1].seek + Mozambique_nml[2 - 1].length;
            Mozambique_nml[1].length = Mozambique_nml[2 - 1].length * 4;
            Mozambique_nml[1].seeklength = 128;


            Mozambique_gls[0].name = "gls";
            Mozambique_gls[0].seek = 7974948864;
            Mozambique_gls[0].length = 131072;
            Mozambique_gls[0].seeklength = 128;

            Mozambique_gls[1].name = "gls";
            Mozambique_gls[1].seek = Mozambique_gls[2 - 1].seek + Mozambique_gls[2 - 1].length;
            Mozambique_gls[1].length = Mozambique_gls[2 - 1].length * 4;
            Mozambique_gls[1].seeklength = 128;


            Mozambique_spc[0].name = "spc";
            Mozambique_spc[0].seek = 7975604224;
            Mozambique_spc[0].length = 131072;
            Mozambique_spc[0].seeklength = 128;

            Mozambique_spc[1].name = "spc";
            Mozambique_spc[1].seek = Mozambique_spc[2 - 1].seek + Mozambique_spc[2 - 1].length;
            Mozambique_spc[1].length = Mozambique_spc[2 - 1].length * 4;
            Mozambique_spc[1].seeklength = 128;



        }
    }
}
