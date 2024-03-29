﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.WeaponData.Default.SubmachineGun
{
    class R99
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }

        public ReallyData[] R99_col;
        public ReallyData[] R99_nml;
        public ReallyData[] R99_gls;
        public ReallyData[] R99_spc;
        public ReallyData[] R99_ilm;
        public ReallyData[] R99_ao;
        public ReallyData[] R99_cav;
        public R99()
        {


            R99_col = new ReallyData[3];
            R99_nml = new ReallyData[3];
            R99_gls = new ReallyData[3];
            R99_spc = new ReallyData[3];
            R99_ilm = new ReallyData[3];
            R99_ao = new ReallyData[3];
            R99_cav = new ReallyData[3];
            //2为2048x2048,1为1024x1024,0为512x512

            //col
            R99_col[0].name = "col";
            R99_col[0].seek = 648716288;
            R99_col[0].length = 131072;
            R99_col[0].seeklength = 128;

            R99_col[1].name = "col";
            R99_col[1].seek = 7984779264;
            R99_col[1].length = 524288;
            R99_col[1].seeklength = 128;

            R99_col[2].name = "col";
            R99_col[2].seek = R99_col[2 - 1].seek + R99_col[2 - 1].length;
            R99_col[2].length = R99_col[2 - 1].length * 4;
            R99_col[2].seeklength = 128;

            //nml
            R99_nml[0].name = "nml";
            R99_nml[0].seek = 648912896;
            R99_nml[0].length = 262144;
            R99_nml[0].seeklength = 128;

            R99_nml[1].name = "nml";
            R99_nml[1].seek = 7987400704;
            R99_nml[1].length = 1048576;
            R99_nml[1].seeklength = 128;

            R99_nml[2].name = "nml";
            R99_nml[2].seek = R99_nml[2 - 1].seek + R99_nml[2 - 1].length;
            R99_nml[2].length = R99_nml[2 - 1].length * 4;
            R99_nml[2].seeklength = 128;

            //gls
            R99_gls[0].name = "gls";
            R99_gls[0].seek = 649175040;
            R99_gls[0].length = 131072;
            R99_gls[0].seeklength = 128;

            R99_gls[1].name = "gls";
            R99_gls[1].seek = 7992643584;
            R99_gls[1].length = 524288;
            R99_gls[1].seeklength = 128;

            R99_gls[2].name = "gls";
            R99_gls[2].seek = R99_gls[2 - 1].seek + R99_gls[2 - 1].length;
            R99_gls[2].length = R99_gls[2 - 1].length * 4;
            R99_gls[2].seeklength = 128;

            //spc
            R99_spc[0].name = "spc";
            R99_spc[0].seek = 649306112;
            R99_spc[0].length = 131072;
            R99_spc[0].seeklength = 128;

            R99_spc[1].name = "spc";
            R99_spc[1].seek = 7995265024;
            R99_spc[1].length = 524288;
            R99_spc[1].seeklength = 128;

            R99_spc[2].name = "spc";
            R99_spc[2].seek = R99_spc[2 - 1].seek + R99_spc[2 - 1].length;
            R99_spc[2].length = R99_spc[2 - 1].length * 4;
            R99_spc[2].seeklength = 128;

            //ilm
            R99_ilm[0].name = "ilm";
            R99_ilm[0].seek = 649437184;
            R99_ilm[0].length = 131072;
            R99_ilm[0].seeklength = 128;

            R99_ilm[1].name = "ilm";
            R99_ilm[1].seek = 7997886464;
            R99_ilm[1].length = 524288;
            R99_ilm[1].seeklength = 128;

            R99_ilm[2].name = "ilm";
            R99_ilm[2].seek = R99_ilm[2 - 1].seek + R99_ilm[2 - 1].length;
            R99_ilm[2].length = R99_ilm[2 - 1].length * 4;
            R99_ilm[2].seeklength = 128;

            //ao
            R99_ao[0].name = "ao";
            R99_ao[0].seek = 649568256;
            R99_ao[0].length = 131072;
            R99_ao[0].seeklength = 128;

            R99_ao[1].name = "ao";
            R99_ao[1].seek = 8000507904;
            R99_ao[1].length = 524288;
            R99_ao[1].seeklength = 128;

            R99_ao[2].name = "ao";
            R99_ao[2].seek = R99_ao[2 - 1].seek + R99_ao[2 - 1].length;
            R99_ao[2].length = R99_ao[2 - 1].length * 4;
            R99_ao[2].seeklength = 128;

            //cav
            R99_cav[0].name = "cav";
            R99_cav[0].seek = 649699328;
            R99_cav[0].length = 131072;
            R99_cav[0].seeklength = 128;

            R99_cav[1].name = "cav";
            R99_cav[1].seek = 8003129344;
            R99_cav[1].length = 524288;
            R99_cav[1].seeklength = 128;

            R99_cav[2].name = "cav";
            R99_cav[2].seek = R99_cav[2 - 1].seek + R99_cav[2 - 1].length;
            R99_cav[2].length = R99_cav[2 - 1].length * 4;
            R99_cav[2].seeklength = 128;
        }
    }
}
