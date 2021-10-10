using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.WeaponData.Default.AssaultRifle
{
    class Havoc
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }

        public ReallyData[] Havoc_col;
        public ReallyData[] Havoc_nml;
        public ReallyData[] Havoc_gls;
        public ReallyData[] Havoc_spc;
        public ReallyData[] Havoc_ilm;
        public ReallyData[] Havoc_ao;
        public ReallyData[] Havoc_cav;
        public Havoc()
        {


            Havoc_col = new ReallyData[3];
            Havoc_nml = new ReallyData[3];
            Havoc_gls = new ReallyData[3];
            Havoc_spc = new ReallyData[3];
            Havoc_ilm = new ReallyData[3];
            Havoc_ao = new ReallyData[3];
            Havoc_cav = new ReallyData[3];
            //2为2048x2048,1为1024x1024,0为512x512

            //col
            Havoc_col[0].name = "col";
            Havoc_col[0].seek = 510746624;
            Havoc_col[0].length = 131072;
            Havoc_col[0].seeklength = 128;

            Havoc_col[1].name = "col";
            Havoc_col[1].seek = 6861623296;
            Havoc_col[1].length = 524288;
            Havoc_col[1].seeklength = 128;

            Havoc_col[2].name = "col";
            Havoc_col[2].seek = Havoc_col[2 - 1].seek + Havoc_col[2 - 1].length;
            Havoc_col[2].length = Havoc_col[2 - 1].length * 4;
            Havoc_col[2].seeklength = 128;

            //nml
            Havoc_col[0].name = "nml";
            Havoc_col[0].seek = 510943232;
            Havoc_col[0].length = 262144;
            Havoc_col[0].seeklength = 128;

            Havoc_nml[1].name = "nml";
            Havoc_nml[1].seek = 6864244736;
            Havoc_nml[1].length = 1048576;
            Havoc_nml[1].seeklength = 128;

            Havoc_nml[2].name = "nml";
            Havoc_nml[2].seek = Havoc_nml[2 - 1].seek + Havoc_nml[2 - 1].length;
            Havoc_nml[2].length = Havoc_nml[2 - 1].length * 4;
            Havoc_nml[2].seeklength = 128;

            //gls
            Havoc_gls[0].name = "gls";
            Havoc_gls[0].seek = 511205376;
            Havoc_gls[0].length = 131072;
            Havoc_gls[0].seeklength = 128;

            Havoc_gls[1].name = "gls";
            Havoc_gls[1].seek = 6869487616;
            Havoc_gls[1].length = 524288;
            Havoc_gls[1].seeklength = 128;

            Havoc_gls[2].name = "gls";
            Havoc_gls[2].seek = Havoc_gls[2 - 1].seek + Havoc_gls[2 - 1].length;
            Havoc_gls[2].length = Havoc_gls[2 - 1].length * 4;
            Havoc_gls[2].seeklength = 128;

            //spc
            Havoc_spc[0].name = "spc";
            Havoc_spc[0].seek = 511336448;
            Havoc_spc[0].length = 131072;
            Havoc_spc[0].seeklength = 128;

            Havoc_spc[1].name = "spc";
            Havoc_spc[1].seek = 6872109056;
            Havoc_spc[1].length = 524288;
            Havoc_spc[1].seeklength = 128;

            Havoc_spc[2].name = "spc";
            Havoc_spc[2].seek = Havoc_spc[2 - 1].seek + Havoc_spc[2 - 1].length;
            Havoc_spc[2].length = Havoc_spc[2 - 1].length * 4;
            Havoc_spc[2].seeklength = 128;

            //ilm
            Havoc_ilm[0].name = "ilm";
            Havoc_ilm[0].seek = 511467520;
            Havoc_ilm[0].length = 131072;
            Havoc_ilm[0].seeklength = 128;

            Havoc_ilm[1].name = "ilm";
            Havoc_ilm[1].seek = 6874730496;
            Havoc_ilm[1].length = 524288;
            Havoc_ilm[1].seeklength = 128;

            Havoc_ilm[2].name = "ilm";
            Havoc_ilm[2].seek = Havoc_ilm[2 - 1].seek + Havoc_ilm[2 - 1].length;
            Havoc_ilm[2].length = Havoc_ilm[2 - 1].length * 4;
            Havoc_ilm[2].seeklength = 128;

            //ao
            Havoc_ao[0].name = "ao";
            Havoc_ao[0].seek = 511598592;
            Havoc_ao[0].length = 131072;
            Havoc_ao[0].seeklength = 128;

            Havoc_ao[1].name = "ao";
            Havoc_ao[1].seek = 6877351936;
            Havoc_ao[1].length = 524288;
            Havoc_ao[1].seeklength = 128;

            Havoc_ao[2].name = "ao";
            Havoc_ao[2].seek = Havoc_ao[2 - 1].seek + Havoc_ao[2 - 1].length;
            Havoc_ao[2].length = Havoc_ao[2 - 1].length * 4;
            Havoc_ao[2].seeklength = 128;

            //cav
            Havoc_cav[0].name = "cav";
            Havoc_cav[0].seek = 511729664;
            Havoc_cav[0].length = 131072;
            Havoc_cav[0].seeklength = 128;

            Havoc_cav[1].name = "cav";
            Havoc_cav[1].seek = 6879973376;
            Havoc_cav[1].length = 524288;
            Havoc_cav[1].seeklength = 128;

            Havoc_cav[2].name = "cav";
            Havoc_cav[2].seek = Havoc_cav[2 - 1].seek + Havoc_cav[2 - 1].length;
            Havoc_cav[2].length = Havoc_cav[2 - 1].length * 4;
            Havoc_cav[2].seeklength = 128;
        }
    }
}
