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
        //需要修复
        public ReallyData[] Alternator_col;
        public ReallyData[] Alternator_nml;
        public ReallyData[] Alternator_gls;
        public ReallyData[] Alternator_spc;

        public Alternator()
        {


            Alternator_col = new ReallyData[3];
            Alternator_nml = new ReallyData[3];
            Alternator_gls = new ReallyData[3];
            Alternator_spc = new ReallyData[3];

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



        }
    }
}
