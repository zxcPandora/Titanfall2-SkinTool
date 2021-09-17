using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.WeaponData.Default.Sniper
{
    class Longbow
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }
        //需要修复
        public ReallyData[] Longbow_col;
        public ReallyData[] Longbow_nml;
        public ReallyData[] Longbow_gls;
        public ReallyData[] Longbow_spc;

        public Longbow()
        {


            Longbow_col = new ReallyData[3];
            Longbow_nml = new ReallyData[3];
            Longbow_gls = new ReallyData[3];
            Longbow_spc = new ReallyData[3];

            //2为2048x2048,1为1024x1024,0为512x512

            //col
            Longbow_col[0].name = "col";
            Longbow_col[0].seek = 665415680;
            Longbow_col[0].length = 131072;
            Longbow_col[0].seeklength = 128;

            Longbow_col[1].name = "col";
            Longbow_col[1].seek = 8098811904;
            Longbow_col[1].length = 524288;
            Longbow_col[1].seeklength = 128;

            Longbow_col[2].name = "col";
            Longbow_col[2].seek = Longbow_col[2 - 1].seek + Longbow_col[2 - 1].length;
            Longbow_col[2].length = Longbow_col[2 - 1].length * 4;
            Longbow_col[2].seeklength = 128;

            //nml
            Longbow_nml[0].name = "nml";
            Longbow_nml[0].seek = 665612288;
            Longbow_nml[0].length = 262144;
            Longbow_nml[0].seeklength = 128;

            Longbow_nml[1].name = "nml";
            Longbow_nml[1].seek = 8101433344;
            Longbow_nml[1].length = 1048576;
            Longbow_nml[1].seeklength = 128;

            Longbow_nml[2].name = "nml";
            Longbow_nml[2].seek = Longbow_nml[2 - 1].seek + Longbow_nml[2 - 1].length;
            Longbow_nml[2].length = Longbow_nml[2 - 1].length * 4;
            Longbow_nml[2].seeklength = 128;

            //gls
            Longbow_gls[0].name = "gls";
            Longbow_gls[0].seek = 665874432;
            Longbow_gls[0].length = 131072;
            Longbow_gls[0].seeklength = 128;

            Longbow_gls[1].name = "gls";
            Longbow_gls[1].seek = 8106676224;
            Longbow_gls[1].length = 524288;
            Longbow_gls[1].seeklength = 128;

            Longbow_gls[2].name = "gls";
            Longbow_gls[2].seek = Longbow_gls[2 - 1].seek + Longbow_gls[2 - 1].length;
            Longbow_gls[2].length = Longbow_gls[2 - 1].length * 4;
            Longbow_gls[2].seeklength = 128;

            //spc
            Longbow_spc[0].name = "spc";
            Longbow_spc[0].seek = 666005504;
            Longbow_spc[0].length = 131072;
            Longbow_spc[0].seeklength = 128;

            Longbow_spc[1].name = "spc";
            Longbow_spc[1].seek = 8109297664;
            Longbow_spc[1].length = 524288;
            Longbow_spc[1].seeklength = 128;

            Longbow_spc[2].name = "spc";
            Longbow_spc[2].seek = Longbow_spc[2 - 1].seek + Longbow_spc[2 - 1].length;
            Longbow_spc[2].length = Longbow_spc[2 - 1].length * 4;
            Longbow_spc[2].seeklength = 128;



        }
    }
}
