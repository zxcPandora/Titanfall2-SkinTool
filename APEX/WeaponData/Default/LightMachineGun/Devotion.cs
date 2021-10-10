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

        public ReallyData[] Devotion_col;
        public ReallyData[] Devotion_nml;
        public ReallyData[] Devotion_gls;
        public ReallyData[] Devotion_spc;
        public ReallyData[] Devotion_ilm;
        public ReallyData[] Devotion_ao;
        public ReallyData[] Devotion_cav;
        public Devotion()
        {


            Devotion_col = new ReallyData[3];
            Devotion_nml = new ReallyData[3];
            Devotion_gls = new ReallyData[3];
            Devotion_spc = new ReallyData[3];
            Devotion_ilm = new ReallyData[3];
            Devotion_ao = new ReallyData[3];
            Devotion_cav = new ReallyData[3];
            //2为2048x2048,1为1024x1024,0为512x512

            //col
            Devotion_col[0].name = "col";
            Devotion_col[0].seek = 559849472;
            Devotion_col[0].length = 131072;
            Devotion_col[0].seeklength = 128;

            Devotion_col[1].name = "col";
            Devotion_col[1].seek = 7199789056;
            Devotion_col[1].length = 524288;
            Devotion_col[1].seeklength = 128;

            Devotion_col[2].name = "col";
            Devotion_col[2].seek = Devotion_col[2 - 1].seek + Devotion_col[2 - 1].length;
            Devotion_col[2].length = Devotion_col[2 - 1].length * 4;
            Devotion_col[2].seeklength = 128;

            //nml
            Devotion_nml[0].name = "nml";
            Devotion_nml[0].seek = 560046080;
            Devotion_nml[0].length = 262144;
            Devotion_nml[0].seeklength = 128;

            Devotion_nml[1].name = "nml";
            Devotion_nml[1].seek = 7202410496;
            Devotion_nml[1].length = 1048576;
            Devotion_nml[1].seeklength = 128;

            Devotion_nml[2].name = "nml";
            Devotion_nml[2].seek = Devotion_nml[2 - 1].seek + Devotion_nml[2 - 1].length;
            Devotion_nml[2].length = Devotion_nml[2 - 1].length * 4;
            Devotion_nml[2].seeklength = 128;

            //gls
            Devotion_gls[0].name = "gls";
            Devotion_gls[0].seek = 560308224;
            Devotion_gls[0].length = 131072;
            Devotion_gls[0].seeklength = 128;

            Devotion_gls[1].name = "gls";
            Devotion_gls[1].seek = 7207653376;
            Devotion_gls[1].length = 524288;
            Devotion_gls[1].seeklength = 128;

            Devotion_gls[2].name = "gls";
            Devotion_gls[2].seek = Devotion_gls[2 - 1].seek + Devotion_gls[2 - 1].length;
            Devotion_gls[2].length = Devotion_gls[2 - 1].length * 4;
            Devotion_gls[2].seeklength = 128;

            //spc
            Devotion_spc[0].name = "spc";
            Devotion_spc[0].seek = 560439296;
            Devotion_spc[0].length = 131072;
            Devotion_spc[0].seeklength = 128;

            Devotion_spc[1].name = "spc";
            Devotion_spc[1].seek = 7210274816;
            Devotion_spc[1].length = 524288;
            Devotion_spc[1].seeklength = 128;

            Devotion_spc[2].name = "spc";
            Devotion_spc[2].seek = Devotion_spc[2 - 1].seek + Devotion_spc[2 - 1].length;
            Devotion_spc[2].length = Devotion_spc[2 - 1].length * 4;
            Devotion_spc[2].seeklength = 128;

            //ilm,right?
            Devotion_ilm[0].name = "ilm";
            Devotion_ilm[0].seek = 560570368;
            Devotion_ilm[0].length = 131072;
            Devotion_ilm[0].seeklength = 128;

            Devotion_ilm[1].name = "ilm";
            Devotion_ilm[1].seek = 7212896256;
            Devotion_ilm[1].length = 524288;
            Devotion_ilm[1].seeklength = 128;

            Devotion_ilm[2].name = "ilm";
            Devotion_ilm[2].seek = Devotion_ilm[2 - 1].seek + Devotion_ilm[2 - 1].length;
            Devotion_ilm[2].length = Devotion_ilm[2 - 1].length * 4;
            Devotion_ilm[2].seeklength = 128;

            //ao
            Devotion_ao[0].name = "ao";
            Devotion_ao[0].seek = 560701440;
            Devotion_ao[0].length = 131072;
            Devotion_ao[0].seeklength = 128;

            Devotion_ao[1].name = "ao";
            Devotion_ao[1].seek = 7215517696;
            Devotion_ao[1].length = 524288;
            Devotion_ao[1].seeklength = 128;

            Devotion_ao[2].name = "ao";
            Devotion_ao[2].seek = Devotion_ao[2 - 1].seek + Devotion_ao[2 - 1].length;
            Devotion_ao[2].length = Devotion_ao[2 - 1].length * 4;
            Devotion_ao[2].seeklength = 128;

            //cav
            Devotion_cav[0].name = "cav";
            Devotion_cav[0].seek = 560832512;
            Devotion_cav[0].length = 131072;
            Devotion_cav[0].seeklength = 128;

            Devotion_cav[1].name = "cav";
            Devotion_cav[1].seek = 7218139136;
            Devotion_cav[1].length = 524288;
            Devotion_cav[1].seeklength = 128;

            Devotion_cav[2].name = "cav";
            Devotion_cav[2].seek = Devotion_cav[2 - 1].seek + Devotion_cav[2 - 1].length;
            Devotion_cav[2].length = Devotion_cav[2 - 1].length * 4;
            Devotion_cav[2].seeklength = 128;
        }
    }
}
