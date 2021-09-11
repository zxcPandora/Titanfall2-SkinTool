using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.WeaponData.Default.Shotgun
{
    class EVA8
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }
        //需要修复
        public ReallyData[] EVA8_col;
        public ReallyData[] EVA8_nml;
        public ReallyData[] EVA8_gls;
        public ReallyData[] EVA8_spc;

        public EVA8()
        {


            EVA8_col = new ReallyData[3];
            EVA8_nml = new ReallyData[3];
            EVA8_gls = new ReallyData[3];
            EVA8_spc = new ReallyData[3];

            //2为2048x2048,1为1024x1024,0为512x512

            //col
            EVA8_col[0].name = "col";
            EVA8_col[0].seek = 112680960;
            EVA8_col[0].length = 131072;
            EVA8_col[0].seeklength = 128;

            EVA8_col[1].name = "col";
            EVA8_col[1].seek = 768282624;
            EVA8_col[1].length = 524288;
            EVA8_col[1].seeklength = 128;

            EVA8_col[2].name = "col";
            EVA8_col[2].seek = EVA8_col[2 - 1].seek + EVA8_col[2 - 1].length;
            EVA8_col[2].length = EVA8_col[2 - 1].length * 4;
            EVA8_col[2].seeklength = 128;

            //nml
            EVA8_nml[0].name = "nml";
            EVA8_nml[0].seek = 112877568;
            EVA8_nml[0].length = 262144;
            EVA8_nml[0].seeklength = 128;

            EVA8_nml[1].name = "nml";
            EVA8_nml[1].seek = 770904064;
            EVA8_nml[1].length = 1048576;
            EVA8_nml[1].seeklength = 128;

            EVA8_nml[2].name = "nml";
            EVA8_nml[2].seek = EVA8_nml[2 - 1].seek + EVA8_nml[2 - 1].length;
            EVA8_nml[2].length = EVA8_nml[2 - 1].length * 4;
            EVA8_nml[2].seeklength = 128;

            //gls
            EVA8_gls[0].name = "gls";
            EVA8_gls[0].seek = 113139712;
            EVA8_gls[0].length = 131072;
            EVA8_gls[0].seeklength = 128;

            EVA8_gls[1].name = "gls";
            EVA8_gls[1].seek = 776146944;
            EVA8_gls[1].length = 524288;
            EVA8_gls[1].seeklength = 128;

            EVA8_gls[2].name = "gls";
            EVA8_gls[2].seek = EVA8_gls[2 - 1].seek + EVA8_gls[2 - 1].length;
            EVA8_gls[2].length = EVA8_gls[2 - 1].length * 4;
            EVA8_gls[2].seeklength = 128;

            //spc
            EVA8_spc[0].name = "spc";
            EVA8_spc[0].seek = 113270784;
            EVA8_spc[0].length = 131072;
            EVA8_spc[0].seeklength = 128;

            EVA8_spc[1].name = "spc";
            EVA8_spc[1].seek = 778768384;
            EVA8_spc[1].length = 524288;
            EVA8_spc[1].seeklength = 128;

            EVA8_spc[2].name = "spc";
            EVA8_spc[2].seek = EVA8_spc[2 - 1].seek + EVA8_spc[2 - 1].length;
            EVA8_spc[2].length = EVA8_spc[2 - 1].length * 4;
            EVA8_spc[2].seeklength = 128;



        }
    }
}
