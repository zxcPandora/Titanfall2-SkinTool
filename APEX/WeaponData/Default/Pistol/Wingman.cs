﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.WeaponData.Default.Pistol
{
    class Wingman
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }

        public ReallyData[] Wingman_col;
        public ReallyData[] Wingman_nml;
        public ReallyData[] Wingman_gls;
        public ReallyData[] Wingman_spc;
        public ReallyData[] Wingman_ao;
        public ReallyData[] Wingman_cav;
        public Wingman()
        {


            Wingman_col = new ReallyData[3];
            Wingman_nml = new ReallyData[3];
            Wingman_gls = new ReallyData[3];
            Wingman_spc = new ReallyData[3];
            Wingman_ao = new ReallyData[3];
            Wingman_cav = new ReallyData[3];
            //2为2048x2048,1为1024x1024,0为512x512

            //col
            Wingman_col[0].name = "col";
            Wingman_col[0].seek = 3941470208;
            Wingman_col[0].length = 131072;
            Wingman_col[0].seeklength = 128;

            Wingman_col[1].name = "col";
            Wingman_col[1].seek = Wingman_col[1 - 1].seek + Wingman_col[1 - 1].length;
            Wingman_col[1].length = Wingman_col[1 - 1].length * 4;
            Wingman_col[1].seeklength = 128;

            //nml
            Wingman_nml[0].name = "nml";
            Wingman_nml[0].seek = 3942125568;
            Wingman_nml[0].length = 262144;
            Wingman_nml[0].seeklength = 128;

            Wingman_nml[1].name = "nml";
            Wingman_nml[1].seek = Wingman_nml[1 - 1].seek + Wingman_nml[1 - 1].length;
            Wingman_nml[1].length = Wingman_nml[1 - 1].length * 4;
            Wingman_nml[1].seeklength = 128;

            //gls
            Wingman_gls[0].name = "gls";
            Wingman_gls[0].seek = 3943436288;
            Wingman_gls[0].length = 131072;
            Wingman_gls[0].seeklength = 128;

            Wingman_gls[1].name = "gls";
            Wingman_gls[1].seek = Wingman_gls[1 - 1].seek + Wingman_gls[1 - 1].length;
            Wingman_gls[1].length = Wingman_gls[1 - 1].length * 4;
            Wingman_gls[1].seeklength = 128;

            //spc
            Wingman_spc[0].name = "spc";
            Wingman_spc[0].seek = 3944091648;
            Wingman_spc[0].length = 131072;
            Wingman_spc[0].seeklength = 128;

            Wingman_spc[1].name = "spc";
            Wingman_spc[1].seek = Wingman_spc[1 - 1].seek + Wingman_spc[1 - 1].length;
            Wingman_spc[1].length = Wingman_spc[1 - 1].length * 4;
            Wingman_spc[1].seeklength = 128;

            //ao
            Wingman_ao[0].name = "ao";
            Wingman_ao[0].seek = 3944747008;
            Wingman_ao[0].length = 131072;
            Wingman_ao[0].seeklength = 128;

            Wingman_ao[1].name = "ao";
            Wingman_ao[1].seek = Wingman_ao[1 - 1].seek + Wingman_ao[1 - 1].length;
            Wingman_ao[1].length = Wingman_ao[1 - 1].length * 4;
            Wingman_ao[1].seeklength = 128;

            //cav
            Wingman_cav[0].name = "cav";
            Wingman_cav[0].seek = 3945402368;
            Wingman_cav[0].length = 131072;
            Wingman_cav[0].seeklength = 128;

            Wingman_cav[1].name = "cav";
            Wingman_cav[1].seek = Wingman_cav[1 - 1].seek + Wingman_cav[1 - 1].length;
            Wingman_cav[1].length = Wingman_cav[1 - 1].length * 4;
            Wingman_cav[1].seeklength = 128;
        }
    }
}
