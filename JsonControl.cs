using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Text.Json;
using System.Data.SQLite;

namespace Titanfall2_SkinTool
{
    public class JsonControl
    {
        public struct JsonInfo
        {
            public string fileName;
            public int width;
            public int height;
            public bool hexOffest;
            public long offest;
            public int length;
            public string textureName;
            public string textureType;
            public string textureFormat;
            public bool autoReSize;
            public int endWidth;
            public int endHeight;
        }

        //skin.json
        /*
        {
            "FileName":"test/1.dds",
            "Width":"2048",
            "Height":"2048",
            "HexOffest":"true",
            "Offest":"10000000000000",
            "Length":"1000"

            //Option(ToDo)
            //Helpful for save to the database and quicky install the same skin
            //"TextureName":"car_smg"
            //"TextureType":"Cav"
            //"TextureFormat":"DXT1"

            //Extra(ToDo)
            //"AutoReSize":"true"
            //"EndWidth":"1"
            //"EndHeight":"1"
        } 
        */

        public class Utf8ReaderFromFile
        {
            private static ReadOnlySpan<byte> Utf8Bom => new byte[] { 0xEF, 0xBB, 0xBF };

            public static void Run(string fileName)
            {
                List<JsonInfo> t = new List<JsonInfo>();
                ReadOnlySpan<byte> jsonReadOnlySpan = File.ReadAllBytes(fileName);

                // Read past the UTF-8 BOM bytes if a BOM exists.
                if (jsonReadOnlySpan.StartsWith(Utf8Bom))
                {
                    jsonReadOnlySpan = jsonReadOnlySpan.Slice(Utf8Bom.Length);
                }

                int count = 0;
                int total = 0;
                JsonInfo info = new JsonInfo();

                Utf8JsonReader reader = new Utf8JsonReader(jsonReadOnlySpan);

                while (reader.Read())
                {
                    JsonTokenType tokenType = reader.TokenType;

                    switch (tokenType)
                    {
                        case JsonTokenType.StartObject:
                            total++;
                            break;
                        case JsonTokenType.PropertyName:
                            string name = reader.GetString();
                            switch (name)
                            {
                                case "FileName":
                                    reader.Read();
                                    info.fileName = reader.GetString();
                                    break;
                                case "Width":
                                    reader.Read();
                                    info.width = reader.GetInt32();
                                    break;
                                case "Height":
                                    reader.Read();
                                    info.height = reader.GetInt32();
                                    break;
                                case "HexOffest":
                                    reader.Read();
                                    info.hexOffest = reader.GetBoolean();
                                    break;
                                case "Offest":
                                    reader.Read();
                                    info.offest = reader.GetInt64();
                                    break;
                                case "Length":
                                    reader.Read();
                                    info.length = (int)reader.GetInt64();
                                    break;
                                case "TextureName":
                                    reader.Read();
                                    info.textureName = reader.GetString();
                                    break;
                                case "TextureType":
                                    reader.Read();
                                    info.textureType = reader.GetString();
                                    break;
                                case "TextureFormat":
                                    reader.Read();
                                    info.textureFormat = reader.GetString();
                                    break;
                                case "AutoReSize":
                                    reader.Read();
                                    info.autoReSize = reader.GetBoolean();
                                    break;
                                case "EndWidth":
                                    reader.Read();
                                    info.endWidth = reader.GetInt32();
                                    break;
                                case "EndHeight":
                                    reader.Read();
                                    info.endHeight = reader.GetInt32();
                                    break;
                            }
                            break;
                    }
                }
            }


        }
    }
}