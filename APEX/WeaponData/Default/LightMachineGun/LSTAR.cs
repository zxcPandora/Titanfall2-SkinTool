using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.WeaponData.Default.LightMachineGun
{
    class LSTAR
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }

        public ReallyData[] LSTAR_col;
        public ReallyData[] LSTAR_nml;
        public ReallyData[] LSTAR_gls;
        public ReallyData[] LSTAR_spc;
        public ReallyData[] LSTAR_ao;
        public ReallyData[] LSTAR_cav;
        //LSTAR have a very specially texture,lol~
        public LSTAR()
        {


            LSTAR_col = new ReallyData[3];
            LSTAR_nml = new ReallyData[3];
            LSTAR_gls = new ReallyData[3];
            LSTAR_spc = new ReallyData[3];
            LSTAR_ao = new ReallyData[3];
            LSTAR_cav = new ReallyData[3];
            //2为2048x2048,1为1024x1024,0为512x512

            //col
            LSTAR_col[0].name = "col";
            LSTAR_col[0].seek = 575078400;
            LSTAR_col[0].length = 131072;
            LSTAR_col[0].seeklength = 128;

            LSTAR_col[1].name = "col";
            LSTAR_col[1].seek = 7317753856;
            LSTAR_col[1].length = 524288;
            LSTAR_col[1].seeklength = 128;

            LSTAR_col[2].name = "col";
            LSTAR_col[2].seek = LSTAR_col[2 - 1].seek + LSTAR_col[2 - 1].length;
            LSTAR_col[2].length = LSTAR_col[2 - 1].length * 4;
            LSTAR_col[2].seeklength = 128;

            //nml
            LSTAR_nml[0].name = "nml";
            LSTAR_nml[0].seek = 575275008;
            LSTAR_nml[0].length = 262144;
            LSTAR_nml[0].seeklength = 128;

            LSTAR_nml[1].name = "nml";
            LSTAR_nml[1].seek = 7320375296;
            LSTAR_nml[1].length = 1048576;
            LSTAR_nml[1].seeklength = 128;

            LSTAR_nml[2].name = "nml";
            LSTAR_nml[2].seek = LSTAR_nml[2 - 1].seek + LSTAR_nml[2 - 1].length;
            LSTAR_nml[2].length = LSTAR_nml[2 - 1].length * 4;
            LSTAR_nml[2].seeklength = 128;

            //gls
            LSTAR_gls[0].name = "gls";
            LSTAR_gls[0].seek = 575537152;
            LSTAR_gls[0].length = 131072;
            LSTAR_gls[0].seeklength = 128;

            LSTAR_gls[1].name = "gls";
            LSTAR_gls[1].seek = 7325618176;
            LSTAR_gls[1].length = 524288;
            LSTAR_gls[1].seeklength = 128;

            LSTAR_gls[2].name = "gls";
            LSTAR_gls[2].seek = LSTAR_gls[2 - 1].seek + LSTAR_gls[2 - 1].length;
            LSTAR_gls[2].length = LSTAR_gls[2 - 1].length * 4;
            LSTAR_gls[2].seeklength = 128;

            //spc
            LSTAR_spc[0].name = "spc";
            LSTAR_spc[0].seek = 575668224;
            LSTAR_spc[0].length = 131072;
            LSTAR_spc[0].seeklength = 128;

            LSTAR_spc[1].name = "spc";
            LSTAR_spc[1].seek = 7328239616;
            LSTAR_spc[1].length = 524288;
            LSTAR_spc[1].seeklength = 128;

            LSTAR_spc[2].name = "spc";
            LSTAR_spc[2].seek = LSTAR_spc[2 - 1].seek + LSTAR_spc[2 - 1].length;
            LSTAR_spc[2].length = LSTAR_spc[2 - 1].length * 4;
            LSTAR_spc[2].seeklength = 128;

            //ao
            LSTAR_ao[0].name = "ao";
            LSTAR_ao[0].seek = 575799296;
            LSTAR_ao[0].length = 131072;
            LSTAR_ao[0].seeklength = 128;

            LSTAR_ao[1].name = "ao";
            LSTAR_ao[1].seek = 7330861056;
            LSTAR_ao[1].length = 524288;
            LSTAR_ao[1].seeklength = 128;

            LSTAR_ao[2].name = "ao";
            LSTAR_ao[2].seek = LSTAR_ao[2 - 1].seek + LSTAR_ao[2 - 1].length;
            LSTAR_ao[2].length = LSTAR_ao[2 - 1].length * 4;
            LSTAR_ao[2].seeklength = 128;

            //cav
            LSTAR_cav[0].name = "cav";
            LSTAR_cav[0].seek = 575930368;
            LSTAR_cav[0].length = 131072;
            LSTAR_cav[0].seeklength = 128;

            LSTAR_cav[1].name = "cav";
            LSTAR_cav[1].seek = 7333482496;
            LSTAR_cav[1].length = 524288;
            LSTAR_cav[1].seeklength = 128;

            LSTAR_cav[2].name = "cav";
            LSTAR_cav[2].seek = LSTAR_cav[2 - 1].seek + LSTAR_cav[2 - 1].length;
            LSTAR_cav[2].length = LSTAR_cav[2 - 1].length * 4;
            LSTAR_cav[2].seeklength = 128;
        }
    }
}
