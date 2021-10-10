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

        public ReallyData[] Peacekeeper_col;
        public ReallyData[] Peacekeeper_nml;
        public ReallyData[] Peacekeeper_gls;
        public ReallyData[] Peacekeeper_spc;
        public ReallyData[] Peacekeeper_ilm;
        public ReallyData[] Peacekeeper_ao;
        public ReallyData[] Peacekeeper_cav;
        public Peacekeeper()
        {


            Peacekeeper_col = new ReallyData[3];
            Peacekeeper_nml = new ReallyData[3];
            Peacekeeper_gls = new ReallyData[3];
            Peacekeeper_spc = new ReallyData[3];
            Peacekeeper_ilm = new ReallyData[3];
            Peacekeeper_ao = new ReallyData[3];
            Peacekeeper_cav = new ReallyData[3];
            //2为2048x2048,1为1024x1024,0为512x512

            //col
            Peacekeeper_col[0].name = "col";
            Peacekeeper_col[0].seek = 71254016;
            Peacekeeper_col[0].length = 131072;
            Peacekeeper_col[0].seeklength = 128;

            Peacekeeper_col[1].name = "col";
            Peacekeeper_col[1].seek = 198840320;
            Peacekeeper_col[1].length = 524288;
            Peacekeeper_col[1].seeklength = 128;

            Peacekeeper_col[2].name = "col";
            Peacekeeper_col[2].seek = Peacekeeper_col[2 - 1].seek + Peacekeeper_col[2 - 1].length;
            Peacekeeper_col[2].length = Peacekeeper_col[2 - 1].length * 4;
            Peacekeeper_col[2].seeklength = 128;

            //nml
            Peacekeeper_nml[0].name = "nml";
            Peacekeeper_nml[0].seek = 71450624;
            Peacekeeper_nml[0].length = 262144;
            Peacekeeper_nml[0].seeklength = 128;

            Peacekeeper_nml[1].name = "nml";
            Peacekeeper_nml[1].seek = 201461760;
            Peacekeeper_nml[1].length = 1048576;
            Peacekeeper_nml[1].seeklength = 128;

            Peacekeeper_nml[2].name = "nml";
            Peacekeeper_nml[2].seek = Peacekeeper_nml[2 - 1].seek + Peacekeeper_nml[2 - 1].length;
            Peacekeeper_nml[2].length = Peacekeeper_nml[2 - 1].length * 4;
            Peacekeeper_nml[2].seeklength = 128;

            //gls
            Peacekeeper_gls[0].name = "gls";
            Peacekeeper_gls[0].seek = 71712768;
            Peacekeeper_gls[0].length = 131072;
            Peacekeeper_gls[0].seeklength = 128;

            Peacekeeper_gls[1].name = "gls";
            Peacekeeper_gls[1].seek = 206704640;
            Peacekeeper_gls[1].length = 524288;
            Peacekeeper_gls[1].seeklength = 128;

            Peacekeeper_gls[2].name = "gls";
            Peacekeeper_gls[2].seek = Peacekeeper_gls[2 - 1].seek + Peacekeeper_gls[2 - 1].length;
            Peacekeeper_gls[2].length = Peacekeeper_gls[2 - 1].length * 4;
            Peacekeeper_gls[2].seeklength = 128;

            //spc
            Peacekeeper_spc[0].name = "spc";
            Peacekeeper_spc[0].seek = 71843840;
            Peacekeeper_spc[0].length = 131072;
            Peacekeeper_spc[0].seeklength = 128;

            Peacekeeper_spc[1].name = "spc";
            Peacekeeper_spc[1].seek = 209326080;
            Peacekeeper_spc[1].length = 524288;
            Peacekeeper_spc[1].seeklength = 128;

            Peacekeeper_spc[2].name = "spc";
            Peacekeeper_spc[2].seek = Peacekeeper_spc[2 - 1].seek + Peacekeeper_spc[2 - 1].length;
            Peacekeeper_spc[2].length = Peacekeeper_spc[2 - 1].length * 4;
            Peacekeeper_spc[2].seeklength = 128;

            //ilm
            Peacekeeper_ilm[0].name = "ilm";
            Peacekeeper_ilm[0].seek = 71974912;
            Peacekeeper_ilm[0].length = 131072;
            Peacekeeper_ilm[0].seeklength = 128;

            Peacekeeper_ilm[1].name = "ilm";
            Peacekeeper_ilm[1].seek = 211947520;
            Peacekeeper_ilm[1].length = 524288;
            Peacekeeper_ilm[1].seeklength = 128;

            Peacekeeper_ilm[2].name = "ilm";
            Peacekeeper_ilm[2].seek = Peacekeeper_ilm[2 - 1].seek + Peacekeeper_ilm[2 - 1].length;
            Peacekeeper_ilm[2].length = Peacekeeper_ilm[2 - 1].length * 4;
            Peacekeeper_ilm[2].seeklength = 128;

            //ao
            Peacekeeper_ao[0].name = "ao";
            Peacekeeper_ao[0].seek = 72105984;
            Peacekeeper_ao[0].length = 131072;
            Peacekeeper_ao[0].seeklength = 128;

            Peacekeeper_ao[1].name = "ao";
            Peacekeeper_ao[1].seek = 214568960;
            Peacekeeper_ao[1].length = 524288;
            Peacekeeper_ao[1].seeklength = 128;

            Peacekeeper_ao[2].name = "ao";
            Peacekeeper_ao[2].seek = Peacekeeper_ao[2 - 1].seek + Peacekeeper_ao[2 - 1].length;
            Peacekeeper_ao[2].length = Peacekeeper_ao[2 - 1].length * 4;
            Peacekeeper_ao[2].seeklength = 128;

            //cav
            Peacekeeper_cav[0].name = "cav";
            Peacekeeper_cav[0].seek = 72237056;
            Peacekeeper_cav[0].length = 131072;
            Peacekeeper_cav[0].seeklength = 128;

            Peacekeeper_cav[1].name = "cav";
            Peacekeeper_cav[1].seek = 217190400;
            Peacekeeper_cav[1].length = 524288;
            Peacekeeper_cav[1].seeklength = 128;

            Peacekeeper_cav[2].name = "cav";
            Peacekeeper_cav[2].seek = Peacekeeper_cav[2 - 1].seek + Peacekeeper_cav[2 - 1].length;
            Peacekeeper_cav[2].length = Peacekeeper_cav[2 - 1].length * 4;
            Peacekeeper_cav[2].seeklength = 128;
        }
    }
}
