using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.WeaponData.Default.AssaultRifle
{
    class ChargeRifle
    {
        //Doesn't ready!
        //还在写
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }
        //需要修复
        public ReallyData[] ChargeRifle_col;
        public ReallyData[] ChargeRifle_nml;
        public ReallyData[] ChargeRifle_gls;
        public ReallyData[] ChargeRifle_spc;
        
        public ChargeRifle()
        {
            //int i = 1;

            ChargeRifle_col = new ReallyData[3];
            ChargeRifle_nml = new ReallyData[3];
            ChargeRifle_gls = new ReallyData[3];
            ChargeRifle_spc = new ReallyData[3];
            

            //col
            ChargeRifle_col[0].name = "col";
            ChargeRifle_col[0].seek = 108388352;
            ChargeRifle_col[0].length = 131072;
            ChargeRifle_col[0].seeklength = 128;

            ChargeRifle_col[1].name = "col";
            ChargeRifle_col[1].seek = 713232384;
            ChargeRifle_col[1].length = 524288;
            ChargeRifle_col[1].seeklength = 128;

            ChargeRifle_col[2].name = "col";
            ChargeRifle_col[2].seek = ChargeRifle_col[2 - 1].seek + ChargeRifle_col[2 - 1].length;
            ChargeRifle_col[2].length = ChargeRifle_col[2 - 1].length * 4;
            ChargeRifle_col[2].seeklength = 128;

            //nml
            ChargeRifle_nml[0].name = "nml";
            ChargeRifle_nml[0].seek = 108584960;
            ChargeRifle_nml[0].length = 262144;
            ChargeRifle_nml[0].seeklength = 128;

            ChargeRifle_nml[1].name = "nml";
            ChargeRifle_nml[1].seek = 715853824;
            ChargeRifle_nml[1].length = 1048576;
            ChargeRifle_nml[1].seeklength = 128;

            ChargeRifle_nml[2].name = "nml";
            ChargeRifle_nml[2].seek = ChargeRifle_nml[2 - 1].seek + ChargeRifle_nml[2 - 1].length;
            ChargeRifle_nml[2].length = ChargeRifle_nml[2 - 1].length * 4;
            ChargeRifle_nml[2].seeklength = 128;

            //gls
            ChargeRifle_gls[0].name = "gls";
            ChargeRifle_gls[0].seek = 108847104;
            ChargeRifle_gls[0].length = 131072;
            ChargeRifle_gls[0].seeklength = 128;

            ChargeRifle_gls[1].name = "gls";
            ChargeRifle_gls[1].seek = 721096704;
            ChargeRifle_gls[1].length = 524288;
            ChargeRifle_gls[1].seeklength = 128;

            ChargeRifle_gls[2].name = "gls";
            ChargeRifle_gls[2].seek = ChargeRifle_gls[2 - 1].seek + ChargeRifle_gls[2 - 1].length;
            ChargeRifle_gls[2].length = ChargeRifle_gls[2 - 1].length * 4;
            ChargeRifle_gls[2].seeklength = 128;

            //spc
            ChargeRifle_spc[0].name = "spc";
            ChargeRifle_spc[0].seek = 108978176;
            ChargeRifle_spc[0].length = 131072;
            ChargeRifle_spc[0].seeklength = 128;

            ChargeRifle_spc[1].name = "spc";
            ChargeRifle_spc[1].seek = 723718144;
            ChargeRifle_spc[1].length = 524288;
            ChargeRifle_spc[1].seeklength = 128;

            ChargeRifle_spc[2].name = "spc";
            ChargeRifle_spc[2].seek = ChargeRifle_spc[2 - 1].seek + ChargeRifle_spc[2 - 1].length;
            ChargeRifle_spc[2].length = ChargeRifle_spc[2 - 1].length * 4;
            ChargeRifle_spc[2].seeklength = 128;


            
        }
    }
}
