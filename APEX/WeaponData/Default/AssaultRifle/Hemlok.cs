using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titanfall2_SkinTool.APEX.WeaponData.Default.AssaultRifle
{
    class Hemlok
    {
        public struct ReallyData
        {
            public string name;
            public long seek;
            public int length;
            public int seeklength;
        }
        //需要修复
        public ReallyData[] Hemlok_col;
        public ReallyData[] Hemlok_nml;
        public ReallyData[] Hemlok_gls;
        public ReallyData[] Hemlok_spc;
        
        public Hemlok()
        {
            

            Hemlok_col = new ReallyData[3];
            Hemlok_nml = new ReallyData[3];
            Hemlok_gls = new ReallyData[3];
            Hemlok_spc = new ReallyData[3];
            
            //2为2048x2048,1为1024x1024,0为512x512

            Hemlok_col[1].name = "col";
            Hemlok_col[1].seek = 7431786496;
            Hemlok_col[1].length = 524288;
            Hemlok_col[1].seeklength = 128;

            Hemlok_col[2].name = "col";
            Hemlok_col[2].seek = Hemlok_col[2 - 1].seek + Hemlok_col[2 - 1].length;
            Hemlok_col[2].length = Hemlok_col[2 - 1].length * 4;
            Hemlok_col[2].seeklength = 128;


            Hemlok_nml[1].name = "nml";
            Hemlok_nml[1].seek = 7434407936;
            Hemlok_nml[1].length = 1048576;
            Hemlok_nml[1].seeklength = 128;

            Hemlok_nml[2].name = "nml";
            Hemlok_nml[2].seek = Hemlok_nml[2 - 1].seek + Hemlok_nml[2 - 1].length;
            Hemlok_nml[2].length = Hemlok_nml[2 - 1].length * 4;
            Hemlok_nml[2].seeklength = 128;


            Hemlok_gls[1].name = "gls";
            Hemlok_gls[1].seek = 7439650816;
            Hemlok_gls[1].length = 524288;
            Hemlok_gls[1].seeklength = 128;

            Hemlok_gls[2].name = "gls";
            Hemlok_gls[2].seek = Hemlok_gls[2 - 1].seek + Hemlok_gls[2 - 1].length;
            Hemlok_gls[2].length = Hemlok_gls[2 - 1].length * 4;
            Hemlok_gls[2].seeklength = 128;


            Hemlok_spc[1].name = "spc";
            Hemlok_spc[1].seek = 7442272256;
            Hemlok_spc[1].length = 524288;
            Hemlok_spc[1].seeklength = 128;

            Hemlok_spc[2].name = "spc";
            Hemlok_spc[2].seek = Hemlok_spc[2 - 1].seek + Hemlok_spc[2 - 1].length;
            Hemlok_spc[2].length = Hemlok_spc[2 - 1].length * 4;
            Hemlok_spc[2].seeklength = 128;


            
        }
    }
}
