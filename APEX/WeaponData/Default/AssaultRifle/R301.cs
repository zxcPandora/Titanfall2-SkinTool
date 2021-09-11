using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.WeaponData.Default.AssaultRifle
{
    class R301
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }
        //需要修复
        public ReallyData[] R301_col;
        public ReallyData[] R301_nml;
        public ReallyData[] R301_gls;
        public ReallyData[] R301_spc;
        //需要修复
        /*public ReallyData[] R301_ilm;
        public ReallyData[] R301_ao;
        public ReallyData[] R301_cav;*/
        public R301()
        {
            //int i = 1;

            R301_col = new ReallyData[3];
            R301_nml = new ReallyData[3];
            R301_gls = new ReallyData[3];
            R301_spc = new ReallyData[3];
            //需要修复
            /*R301_ilm = new ReallyData[3];
                R301_ao = new ReallyData[3];
                R301_cav = new ReallyData[3];*/
            //2为2048x2048,1为1024x1024,0为512x512

            //col
            R301_col[0].name = "col";
            R301_col[0].seek = 108388352;
            R301_col[0].length = 131072;
            R301_col[0].seeklength = 128;

            R301_col[1].name = "col";
            R301_col[1].seek = 713232384;
            R301_col[1].length = 524288;
            R301_col[1].seeklength = 128;

            R301_col[2].name = "col";
            R301_col[2].seek = R301_col[2 - 1].seek + R301_col[2 - 1].length;
            R301_col[2].length = R301_col[2 - 1].length * 4;
            R301_col[2].seeklength = 128;

            //nml
            R301_nml[0].name = "nml";
            R301_nml[0].seek = 108584960;
            R301_nml[0].length = 262144;
            R301_nml[0].seeklength = 128;

            R301_nml[1].name = "nml";
            R301_nml[1].seek = 715853824;
            R301_nml[1].length = 1048576;
            R301_nml[1].seeklength = 128;

            R301_nml[2].name = "nml";
            R301_nml[2].seek = R301_nml[2 - 1].seek + R301_nml[2 - 1].length;
            R301_nml[2].length = R301_nml[2 - 1].length * 4;
            R301_nml[2].seeklength = 128;

            //gls
            R301_gls[0].name = "gls";
            R301_gls[0].seek = 108847104;
            R301_gls[0].length = 131072;
            R301_gls[0].seeklength = 128;

            R301_gls[1].name = "gls";
            R301_gls[1].seek = 721096704;
            R301_gls[1].length = 524288;
            R301_gls[1].seeklength = 128;

            R301_gls[2].name = "gls";
            R301_gls[2].seek = R301_gls[2 - 1].seek + R301_gls[2 - 1].length;
            R301_gls[2].length = R301_gls[2 - 1].length * 4;
            R301_gls[2].seeklength = 128;

            //spc
            R301_spc[0].name = "spc";
            R301_spc[0].seek = 108978176;
            R301_spc[0].length = 131072;
            R301_spc[0].seeklength = 128;

            R301_spc[1].name = "spc";
            R301_spc[1].seek = 723718144;
            R301_spc[1].length = 524288;
            R301_spc[1].seeklength = 128;

            R301_spc[2].name = "spc";
            R301_spc[2].seek = R301_spc[2 - 1].seek + R301_spc[2 - 1].length;
            R301_spc[2].length = R301_spc[2 - 1].length * 4;
            R301_spc[2].seeklength = 128;


            //需要修复
            /*R301_ilm[0].name = "ilm";
                R301_ilm[0].seek = 9524678656;
                R301_ilm[0].length = 131072;
                R301_ilm[0].seeklength = 128;
                while (i <= 2)
                {
                    R301_ilm[i].name = "ilm";
                    R301_ilm[i].seek = R301_ilm[i - 1].seek + R301_ilm[i - 1].length;
                    R301_ilm[i].length = R301_ilm[i - 1].length * 4;
                    R301_ilm[i].seeklength = 128;
                    i++;
                }
                i = 1;

                R301_ao[0].name = "ao";
                R301_ao[0].seek = 9527431168;
                R301_ao[0].length = 131072;
                R301_ao[0].seeklength = 128;
                while (i <= 2)
                {
                    R301_ao[i].name = "ao";
                    R301_ao[i].seek = R301_ao[i - 1].seek + R301_ao[i - 1].length;
                    R301_ao[i].length = R301_ao[i - 1].length * 4;
                    R301_ao[i].seeklength = 128;
                    i++;
                }
                i = 1;

                R301_cav[0].name = "cav";
                R301_cav[0].seek = 9530183680;
                R301_cav[0].length = 131072;
                R301_cav[0].seeklength = 128;
                while (i <= 2)
                {
                    R301_cav[i].name = "cav";
                    R301_cav[i].seek = R301_cav[i - 1].seek + R301_cav[i - 1].length;
                    R301_cav[i].length = R301_cav[i - 1].length * 4;
                    R301_cav[i].seeklength = 128;
                    i++;
                }
                i = 1;*/
        }
    }
}
