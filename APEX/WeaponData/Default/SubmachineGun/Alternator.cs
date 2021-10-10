using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.WeaponData.Default.SubmachineGun
{
    class Alternator
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }

        public ReallyData[] Alternator_col;
        public ReallyData[] Alternator_nml;
        public ReallyData[] Alternator_gls;
        public ReallyData[] Alternator_spc;
        public ReallyData[] Alternator_ao;
        public ReallyData[] Alternator_cav;
        public Alternator()
        {


            Alternator_col = new ReallyData[3];
            Alternator_nml = new ReallyData[3];
            Alternator_gls = new ReallyData[3];
            Alternator_spc = new ReallyData[3];
            Alternator_ao = new ReallyData[3];
            Alternator_cav = new ReallyData[3];
            //2为2048x2048,1为1024x1024,0为512x512
            //col可能有bug

            //col
            Alternator_col[0].name = "col";
            Alternator_col[0].seek = 419495936;
            Alternator_col[0].length = 131072;
            Alternator_col[0].seeklength = 128;

            Alternator_col[1].name = "col";
            Alternator_col[1].seek = 5619978240;
            Alternator_col[1].length = 524288;
            Alternator_col[1].seeklength = 128;

            Alternator_col[2].name = "col";
            Alternator_col[2].seek = Alternator_col[2 - 1].seek + Alternator_col[2 - 1].length;
            Alternator_col[2].length = Alternator_col[2 - 1].length * 4;
            Alternator_col[2].seeklength = 128;

            //nml
            Alternator_nml[0].name = "nml";
            Alternator_nml[0].seek = 419692544;
            Alternator_nml[0].length = 262144;
            Alternator_nml[0].seeklength = 128;

            Alternator_nml[1].name = "nml";
            Alternator_nml[1].seek = 5622599680;
            Alternator_nml[1].length = 1048576;
            Alternator_nml[1].seeklength = 128;

            Alternator_nml[2].name = "nml";
            Alternator_nml[2].seek = Alternator_nml[2 - 1].seek + Alternator_nml[2 - 1].length;
            Alternator_nml[2].length = Alternator_nml[2 - 1].length * 4;
            Alternator_nml[2].seeklength = 128;

            //gls
            Alternator_gls[0].name = "gls";
            Alternator_gls[0].seek = 419954688;
            Alternator_gls[0].length = 131072;
            Alternator_gls[0].seeklength = 128;

            Alternator_gls[1].name = "gls";
            Alternator_gls[1].seek = 5627842560;
            Alternator_gls[1].length = 524288;
            Alternator_gls[1].seeklength = 128;

            Alternator_gls[2].name = "gls";
            Alternator_gls[2].seek = Alternator_gls[2 - 1].seek + Alternator_gls[2 - 1].length;
            Alternator_gls[2].length = Alternator_gls[2 - 1].length * 4;
            Alternator_gls[2].seeklength = 128;

            //spc
            Alternator_spc[0].name = "spc";
            Alternator_spc[0].seek = 420085760;
            Alternator_spc[0].length = 131072;
            Alternator_spc[0].seeklength = 128;

            Alternator_spc[1].name = "spc";
            Alternator_spc[1].seek = 5630464000;
            Alternator_spc[1].length = 524288;
            Alternator_spc[1].seeklength = 128;

            Alternator_spc[2].name = "spc";
            Alternator_spc[2].seek = Alternator_spc[2 - 1].seek + Alternator_spc[2 - 1].length;
            Alternator_spc[2].length = Alternator_spc[2 - 1].length * 4;
            Alternator_spc[2].seeklength = 128;

            //ao
            Alternator_ao[0].name = "ao";
            Alternator_ao[0].seek = 420216832;
            Alternator_ao[0].length = 131072;
            Alternator_ao[0].seeklength = 128;

            Alternator_ao[1].name = "ao";
            Alternator_ao[1].seek = 5633085440;
            Alternator_ao[1].length = 524288;
            Alternator_ao[1].seeklength = 128;

            Alternator_ao[2].name = "ao";
            Alternator_ao[2].seek = Alternator_ao[2 - 1].seek + Alternator_ao[2 - 1].length;
            Alternator_ao[2].length = Alternator_ao[2 - 1].length * 4;
            Alternator_ao[2].seeklength = 128;

            //cav
            Alternator_cav[0].name = "cav";
            Alternator_cav[0].seek = 420347904;
            Alternator_cav[0].length = 131072;
            Alternator_cav[0].seeklength = 128;

            Alternator_cav[1].name = "cav";
            Alternator_cav[1].seek = 5635706880;
            Alternator_cav[1].length = 524288;
            Alternator_cav[1].seeklength = 128;

            Alternator_cav[2].name = "cav";
            Alternator_cav[2].seek = Alternator_cav[2 - 1].seek + Alternator_cav[2 - 1].length;
            Alternator_cav[2].length = Alternator_cav[2 - 1].length * 4;
            Alternator_cav[2].seeklength = 128;
        }
    }
}
