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
    public class DataControl
    {
        struct DataInfo
        {
            long Offest;
            string Name;
            int maxWidth;
            int minWidth;
            int maxHeight;
            int minHeight;
            int Length;
        }

        private static string connStr= Environment.CurrentDirectory + @"/Data/DataBase.db";

        public bool SaveIntoDataBase()
        {
            SQLiteConnection conn = new SQLiteConnection(connStr);
            conn.Open();

            //在指定数据库中创建一个table
            string sql = "insert";
            SQLiteCommand command = new SQLiteCommand(sql, conn);
            command.ExecuteNonQuery();
            conn.Close();
            return false;
        }

        public bool GetFromDataBase()
        {
            SQLiteConnection conn = new SQLiteConnection(connStr);
            conn.Open();

            string sql = "select";
            SQLiteCommand command = new SQLiteCommand(sql, conn);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

            }
            conn.Close();
            return false;
        }

        public bool DataExistInDataBase()
        {
            return false;
        }

        public static void InitDBFile()
        {
            string path = Environment.CurrentDirectory + @"/Data/";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (!File.Exists(connStr))
            {
                SQLiteConnection.CreateFile(connStr);
                SQLiteConnection conn = new SQLiteConnection("Data Source=" + connStr + ";Pooling=true;FailIfMissing=false;");
                conn.Open();
                string sqlText;
                string sqlFile = path + "DefaultData.sql";
                if (File.Exists(sqlFile))
                {
                    sqlText = new StreamReader(sqlFile).ReadToEnd();
                }
                else
                {
                    sqlText = InitSql();
                }
                SQLiteCommand cmd = new SQLiteCommand(sqlText, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        private static string InitSql()
        {
            string sql = "";
            return sql;
        }
    }
}