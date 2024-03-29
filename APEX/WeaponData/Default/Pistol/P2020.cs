﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.WeaponData.Default.Pistol
{
    class P2020
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }
        //需要修复
        public ReallyData[] P2020_col;
        public ReallyData[] P2020_nml;
        public ReallyData[] P2020_gls;
        public ReallyData[] P2020_spc;
        public ReallyData[] P2020_ao;
        public ReallyData[] P2020_cav;
        public P2020()
        {


            P2020_col = new ReallyData[3];
            P2020_nml = new ReallyData[3];
            P2020_gls = new ReallyData[3];
            P2020_spc = new ReallyData[3];
            P2020_ao = new ReallyData[3];
            P2020_cav = new ReallyData[3];
            //2为2048x2048,1为1024x1024,0为512x512

            //col
            P2020_col[0].name = "col";
            P2020_col[0].seek = 164696064;
            P2020_col[0].length = 131072;
            P2020_col[0].seeklength = 128;

            P2020_col[1].name = "col";
            P2020_col[1].seek = P2020_col[1 - 1].seek + P2020_col[1 - 1].length;
            P2020_col[1].length = P2020_col[1 - 1].length * 4;
            P2020_col[1].seeklength = 128;

            //nml
            P2020_nml[0].name = "nml";
            P2020_nml[0].seek = 165351424;
            P2020_nml[0].length = 262144;
            P2020_nml[0].seeklength = 128;

            P2020_nml[1].name = "nml";
            P2020_nml[1].seek = P2020_nml[1 - 1].seek + P2020_nml[1 - 1].length;
            P2020_nml[1].length = P2020_nml[1 - 1].length * 4;
            P2020_nml[1].seeklength = 128;

            //gls
            P2020_gls[0].name = "gls";
            P2020_gls[0].seek = 166662144;
            P2020_gls[0].length = 131072;
            P2020_gls[0].seeklength = 128;

            P2020_gls[1].name = "gls";
            P2020_gls[1].seek = P2020_gls[1 - 1].seek + P2020_gls[1 - 1].length;
            P2020_gls[1].length = P2020_gls[1 - 1].length * 4;
            P2020_gls[1].seeklength = 128;

            //spc
            P2020_spc[0].name = "spc";
            P2020_spc[0].seek = 167317504;
            P2020_spc[0].length = 131072;
            P2020_spc[0].seeklength = 128;

            P2020_spc[1].name = "spc";
            P2020_spc[1].seek = P2020_spc[1 - 1].seek + P2020_spc[1 - 1].length;
            P2020_spc[1].length = P2020_spc[1 - 1].length * 4;
            P2020_spc[1].seeklength = 128;

            //ao
            P2020_ao[0].name = "ao";
            P2020_ao[0].seek = 167972864;
            P2020_ao[0].length = 131072;
            P2020_ao[0].seeklength = 128;

            P2020_ao[1].name = "ao";
            P2020_ao[1].seek = P2020_ao[1 - 1].seek + P2020_ao[1 - 1].length;
            P2020_ao[1].length = P2020_ao[1 - 1].length * 4;
            P2020_ao[1].seeklength = 128;

            //cav
            P2020_cav[0].name = "cav";
            P2020_cav[0].seek = 168628224;
            P2020_cav[0].length = 131072;
            P2020_cav[0].seeklength = 128;

            P2020_cav[1].name = "cav";
            P2020_cav[1].seek = P2020_cav[1 - 1].seek + P2020_cav[1 - 1].length;
            P2020_cav[1].length = P2020_cav[1 - 1].length * 4;
            P2020_cav[1].seeklength = 128;
        }
    }
}
