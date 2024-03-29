﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.WeaponData.Default.AssaultRifle
{
    class VK47Flatline
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }

        public ReallyData[] VK47Flatline_col;
        public ReallyData[] VK47Flatline_nml;
        public ReallyData[] VK47Flatline_gls;
        public ReallyData[] VK47Flatline_spc;
        public ReallyData[] VK47Flatline_ao;
        public ReallyData[] VK47Flatline_cav;
        public VK47Flatline()
        {


            VK47Flatline_col = new ReallyData[3];
            VK47Flatline_nml = new ReallyData[3];
            VK47Flatline_gls = new ReallyData[3];
            VK47Flatline_spc = new ReallyData[3];
            VK47Flatline_ao = new ReallyData[3];
            VK47Flatline_cav = new ReallyData[3];
            //2为2048x2048,1为1024x1024,0为512x512

            //col
            VK47Flatline_col[0].name = "col";
            VK47Flatline_col[0].seek = 691552256;
            VK47Flatline_col[0].length = 131072;
            VK47Flatline_col[0].seeklength = 128;

            VK47Flatline_col[1].name = "col";
            VK47Flatline_col[1].seek = 8323796992;
            VK47Flatline_col[1].length = 524288;
            VK47Flatline_col[1].seeklength = 128;

            VK47Flatline_col[2].name = "col";
            VK47Flatline_col[2].seek = VK47Flatline_col[2 - 1].seek + VK47Flatline_col[2 - 1].length;
            VK47Flatline_col[2].length = VK47Flatline_col[2 - 1].length * 4;
            VK47Flatline_col[2].seeklength = 128;

            //nml
            VK47Flatline_nml[0].name = "nml";
            VK47Flatline_nml[0].seek = 691748864;
            VK47Flatline_nml[0].length = 262144;
            VK47Flatline_nml[0].seeklength = 128;

            VK47Flatline_nml[1].name = "nml";
            VK47Flatline_nml[1].seek = 8326418432;
            VK47Flatline_nml[1].length = 1048576;
            VK47Flatline_nml[1].seeklength = 128;

            VK47Flatline_nml[2].name = "nml";
            VK47Flatline_nml[2].seek = VK47Flatline_nml[2 - 1].seek + VK47Flatline_nml[2 - 1].length;
            VK47Flatline_nml[2].length = VK47Flatline_nml[2 - 1].length * 4;
            VK47Flatline_nml[2].seeklength = 128;

            //gls
            VK47Flatline_gls[0].name = "gls";
            VK47Flatline_gls[0].seek = 692011008;
            VK47Flatline_gls[0].length = 131072;
            VK47Flatline_gls[0].seeklength = 128;

            VK47Flatline_gls[1].name = "gls";
            VK47Flatline_gls[1].seek = 8331661312;
            VK47Flatline_gls[1].length = 524288;
            VK47Flatline_gls[1].seeklength = 128;

            VK47Flatline_gls[2].name = "gls";
            VK47Flatline_gls[2].seek = VK47Flatline_gls[2 - 1].seek + VK47Flatline_gls[2 - 1].length;
            VK47Flatline_gls[2].length = VK47Flatline_gls[2 - 1].length * 4;
            VK47Flatline_gls[2].seeklength = 128;

            //spc
            VK47Flatline_spc[0].name = "spc";
            VK47Flatline_spc[0].seek = 692142080;
            VK47Flatline_spc[0].length = 131072;
            VK47Flatline_spc[0].seeklength = 128;

            VK47Flatline_spc[1].name = "spc";
            VK47Flatline_spc[1].seek = 8334282752;
            VK47Flatline_spc[1].length = 524288;
            VK47Flatline_spc[1].seeklength = 128;

            VK47Flatline_spc[2].name = "spc";
            VK47Flatline_spc[2].seek = VK47Flatline_spc[2 - 1].seek + VK47Flatline_spc[2 - 1].length;
            VK47Flatline_spc[2].length = VK47Flatline_spc[2 - 1].length * 4;
            VK47Flatline_spc[2].seeklength = 128;

            //ao
            VK47Flatline_ao[0].name = "ao";
            VK47Flatline_ao[0].seek = 692273152;
            VK47Flatline_ao[0].length = 131072;
            VK47Flatline_ao[0].seeklength = 128;

            VK47Flatline_ao[1].name = "ao";
            VK47Flatline_ao[1].seek = 8336904192;
            VK47Flatline_ao[1].length = 524288;
            VK47Flatline_ao[1].seeklength = 128;

            VK47Flatline_ao[2].name = "ao";
            VK47Flatline_ao[2].seek = VK47Flatline_ao[2 - 1].seek + VK47Flatline_ao[2 - 1].length;
            VK47Flatline_ao[2].length = VK47Flatline_ao[2 - 1].length * 4;
            VK47Flatline_ao[2].seeklength = 128;

            //cav
            VK47Flatline_cav[0].name = "cav";
            VK47Flatline_cav[0].seek = 692404224;
            VK47Flatline_cav[0].length = 131072;
            VK47Flatline_cav[0].seeklength = 128;

            VK47Flatline_cav[1].name = "cav";
            VK47Flatline_cav[1].seek = 8339525632;
            VK47Flatline_cav[1].length = 524288;
            VK47Flatline_cav[1].seeklength = 128;

            VK47Flatline_cav[2].name = "cav";
            VK47Flatline_cav[2].seek = VK47Flatline_cav[2 - 1].seek + VK47Flatline_cav[2 - 1].length;
            VK47Flatline_cav[2].length = VK47Flatline_cav[2 - 1].length * 4;
            VK47Flatline_cav[2].seeklength = 128;
        }
    }
}
