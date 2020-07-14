﻿using ACE.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WeenieFab
{
    public class TableToSql
    {
        public static string ConvertTriValueTable(DataTable dt, string wcid, string header)
        {
            string sqltext = "";
            
            int counter = 1;
            int rowcount = dt.Rows.Count;

            if (rowcount > 0)
            {
                sqltext = header + $"\nVALUES";
                foreach (DataRow row in dt.Rows)
                {
                    if (counter == 1 && counter == rowcount)
                        sqltext += $" ({wcid},{row[0],4},{row[1],11}) /* {row[2]} */;\n";
                    else if (counter == 1)
                        sqltext += $" ({wcid},{row[0],4},{row[1],11}) /* {row[2]} */\n";
                    else
                    {
                        if (counter == rowcount)
                            sqltext += $"     , ({wcid},{row[0],4},{row[1],11}) /* {row[2]} */;\n";
                        else
                            sqltext += $"     , ({wcid},{row[0],4},{row[1],11}) /* {row[2]} */\n";
                    }
                    counter++;
                }
            }
            if (rowcount > 0)
                sqltext += $"\n";
            else
            {
            }
            return sqltext;
        }

        public static string ConvertBooleanTable(DataTable dt, string wcid, string header)
        {
            string sqltext = "";

            int counter = 1;
            int rowcount = dt.Rows.Count;

            

            if (rowcount > 0)
            {
                sqltext = header + $"\nVALUES";
                foreach (DataRow row in dt.Rows)
                {
                    string tempTrueFalse = row[1].ToString();
                    int padRight = 20 - tempTrueFalse.Length;
                    // string finalTrueFalse = tempTrueFalse.PadRight(6).PadLeft(6);
                    tempTrueFalse = tempTrueFalse.PadRight(5).PadLeft(6);

                    if (counter == 1 && counter == rowcount)
                        sqltext += $" ({wcid},{row[0],4},{tempTrueFalse}) /* {row[2]} */;\n";
                    else if (counter == 1)
                        sqltext += $" ({wcid},{row[0],4},{tempTrueFalse}) /* {row[2]} */\n";
                    else
                    {
                        if (counter == rowcount)
                            sqltext += $"     , ({wcid},{row[0],4},{tempTrueFalse}) /* {row[2]} */;\n";
                        else
                            sqltext += $"     , ({wcid},{row[0],4},{tempTrueFalse}) /* {row[2]} */\n";
                    }
                    counter++;
                }
            }
            if (rowcount > 0)
                sqltext += $"\n";
            else
            {
            }
            return sqltext;
        }

        public static string ConvertFloatTable(DataTable dt, string wcid, string header)
        {
            string sqltext = "";

            int counter = 1;
            int rowcount = dt.Rows.Count;

            if (rowcount > 0)
            {
                sqltext = header + $"\nVALUES";
                foreach (DataRow row in dt.Rows)
                {
                    if (counter == 1 && counter == rowcount)
                        sqltext += $" ({wcid},{row[0],4},{row[1],8}) /* {row[2]} */;\n";
                    else if (counter == 1)
                        sqltext += $" ({wcid},{row[0],4},{row[1],8}) /* {row[2]} */\n";
                    else
                    {
                        if (counter == rowcount)
                            sqltext += $"     , ({wcid},{row[0],4},{row[1],8}) /* {row[2]} */;\n";
                        else
                            sqltext += $"     , ({wcid},{row[0],4},{row[1],8}) /* {row[2]} */\n";
                    }
                    counter++;
                }
            }
            if (rowcount > 0)
                sqltext += $"\n";
            else
            {
            }
            return sqltext;
        }

        public static string ConvertStringTable(DataTable dt, string wcid, string header)
        {
            string sqltext = "";

            int counter = 1;
            int rowcount = dt.Rows.Count;

            if (rowcount > 0)
            {
                sqltext = header + $"\nVALUES";
                foreach (DataRow row in dt.Rows)
                {
                    string sValue = "'" + row[1] + "'";
                    if (counter == 1 && counter == rowcount)
                        sqltext += $" ({wcid},{row[0],4}, {sValue,1}) /* {row[2]} */;\n";
                    else if (counter == 1)
                        sqltext += $" ({wcid},{row[0],4}, {sValue,1}) /* {row[2]} */\n";
                    else
                    {
                        if (counter == rowcount)
                            sqltext += $"     , ({wcid},{row[0],4}, {sValue,1}) /* {row[2]} */;\n";
                        else
                            sqltext += $"     , ({wcid},{row[0],4}, {sValue,1}) /* {row[2]} */\n";
                    }
                    counter++;
                }
            }
            if (rowcount > 0)
                sqltext += $"\n";
            else
            {
            }
            return sqltext;
        }

        public static string ConvertAttributeTable(DataTable dt, string wcid, string header)
        {
            string sqltext = "";

            int counter = 1;
            int rowcount = dt.Rows.Count;

            if (rowcount > 0)
            {
                sqltext = header + $"\nVALUES";
                foreach (DataRow row in dt.Rows)
                {
                    if (counter == 1)
                        sqltext += $" ({wcid},{row[0],4},{row[1],4},{row[2],2},{row[3],2}) /* {row[4]} */\n";
                    else
                    {
                        if (counter == rowcount)
                            sqltext += $"     , ({wcid},{row[0],4},{row[1],4},{row[2],2},{row[3],2}) /* {row[4]} */;\n";
                        else
                            sqltext += $"     , ({wcid},{row[0],4},{row[1],4},{row[2],2},{row[3],2}) /* {row[4]} */\n";

                    }
                    counter++;
                }
            }
            if (rowcount > 0)
                sqltext += $"\n";
            else
            {
            }
            return sqltext;
        }

        //  Attrib2 - Health, Stamina, Mana
        public static string ConvertAttribute2Table(DataTable dt, string wcid, string header)
        {
            string sqltext = "";

            int counter = 1;
            int rowcount = dt.Rows.Count;

            if (rowcount > 0)
            {
                sqltext = header + $"\nVALUES";
                foreach (DataRow row in dt.Rows)
                {
                    if (counter == 1)
                        sqltext += $" ({wcid},{row[0],4},{row[1],6},{row[2],2},{row[3],2},{row[4],5}) /* {row[5]} */\n";                    
                    else
                    {
                        if (counter == rowcount)
                            sqltext += $"     , ({wcid},{row[0],4},{row[1],6},{row[2],2},{row[3],2},{row[4],5}) /* {row[5]} */;\n";
                        else
                            sqltext += $"     , ({wcid},{row[0],4},{row[1],6},{row[2],2},{row[3],2},{row[4],5}) /* {row[5]} */\n";

                    }
                    counter++;
                }
            }
            if (rowcount > 0)
                sqltext += $"\n";
            else
            {
            }
            return sqltext;
        }

        public static string ConvertSkillsTable(DataTable dt, string wcid, string header)
        {
            string sqltext = "";

            int counter = 1;
            int rowcount = dt.Rows.Count;

            if (rowcount > 0)
            {
                sqltext = header + $"\nVALUES";
                foreach (DataRow row in dt.Rows)
                {
                    if (counter == 1)
                        sqltext += $" ({wcid},{row[0],3},{row[1],2},{row[2],2},{row[3],2},{row[4],4},{row[5],2},{row[6],2}) /* {row[7]} */\n";
                    else
                    {
                        if (counter == rowcount)
                            sqltext += $"     , ({wcid},{row[0],3},{row[1],2},{row[2],2},{row[3],2},{row[4],4},{row[5],2},{row[6],2}) /* {row[7]} */;\n";
                        else
                            sqltext += $"     , ({wcid},{row[0],3},{row[1],2},{row[2],2},{row[3],2},{row[4],4},{row[5],2},{row[6],2}) /* {row[7]} */\n";

                    }
                    counter++;
                }
            }
            if (rowcount > 0)
                sqltext += $"\n";
            else
            {
            }
            return sqltext;
        }
        public static string ConvertBodyTable(string bodyparts, string wcid, string header)
        {
            int counter = 0;
            string sqltext = header + $"\nVALUES";

            foreach (var blobLine in bodyparts.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (counter == 0)
                    sqltext += $" {blobLine}\n";
                else
                    sqltext += $"     , {blobLine}\n";
                counter++;
            }
            sqltext += $"\n";
            return sqltext;
        }
        public static string ConvertSpellTable(DataTable dt, string wcid, string header)
        {
            string sqltext = "";

            int counter = 1;
            int rowcount = dt.Rows.Count;

            if (rowcount > 0)
            {
                sqltext = header + $"\nVALUES";
                foreach (DataRow row in dt.Rows)
                {
                    if (counter == 1 && counter == rowcount)
                        sqltext += $" ({wcid},{row[0],6},{row[1],7}) /* {row[2]} */;\n";
                    else if (counter == 1)
                        sqltext += $" ({wcid},{row[0],6},{row[1],7}) /* {row[2]} */\n";
                    else
                    {
                        if (counter == rowcount)
                            sqltext += $"     , ({wcid},{row[0],6},{row[1],7}) /* {row[2]} */;\n";
                        else
                            sqltext += $"     , ({wcid},{row[0],6},{row[1],7}) /* {row[2]} */\n";
                    }
                    counter++;
                }
            }
            if (rowcount > 0)
                sqltext += $"\n";

            return sqltext;
        }
        public static string ConvertCreateItemsTable(DataTable dt, string wcid, string header)
        {            
            string sqltext = "";

            int counter = 1;
            int rowcount = dt.Rows.Count;

            if (rowcount > 0)
            {
                sqltext = header + $"\nVALUES";
                foreach (DataRow row in dt.Rows)
                {
                    if (counter == 1 && counter == rowcount)
                        sqltext += $" ({wcid},{row[0],2},{row[1],6},{row[2],3},{row[3],2},{row[4],5},{row[5],6}) /* {row[6]} */;\n";
                    else if (counter == 1)
                        sqltext += $" ({wcid},{row[0],2},{row[1],6},{row[2],3},{row[3],2},{row[4],5},{row[5],6}) /* {row[6]} */\n";
                    else
                    {
                        if (counter == rowcount)
                            sqltext += $"     , ({wcid},{row[0],2},{row[1],6},{row[2],3},{row[3],2},{row[4],5},{row[5],6}) /* {row[6]} */;\n";
                        else
                            sqltext += $"     , ({wcid},{row[0],2},{row[1],6},{row[2],3},{row[3],2},{row[4],5},{row[5],6}) /* {row[6]} */\n";
                    }
                    counter++;
                }
            }
            //if (rowcount > 0)
            //    sqltext += $"\n";

            return sqltext;
        }
        public static string ConvertBodyPart(DataTable dt, string wcid, string header)
        {
            

            string sqltext = "";

            int counter = 1;
            int rowcount = dt.Rows.Count;

            int avse = 200; // armor vs element
            int avsnether = 0;
            if (rowcount > 0)
            {
                sqltext = header + $"\nVALUES";
                foreach (DataRow row in dt.Rows)
                {
                    avse = MainWindow.ConvertToInteger(row[4].ToString()) / 2;
                    if (counter == 1)
                        sqltext += $" ({wcid},{row[0],3},{row[1],3},{row[2],3},{row[3],5},{row[4],5}," +   // 6 fields
                                   $"{avse,5},{avse,5},{avse,5},{avse,5},{avse,5},{avse,5},{avse,5},{avsnether,5}," +   // 8 fields
                                   $"{row[5],2}," +
                                   $"{row[6],5},{row[7],5},{row[8],5},{row[9],5},{row[10],5},{row[11],5}," + 
                                   $"{row[12],5},{row[13],5},{row[14],5},{row[15],5},{row[16],5},{row[17],5})" +
                                   $" /* {row[18]} */\n";
                    else
                    {
                        if (counter == rowcount)
                            sqltext += $"     , ({wcid},{row[0],3},{row[1],3},{row[2],3},{row[3],5},{row[4],5}," +   // 6 fields
                                       $"{avse,5},{avse,5},{avse,5},{avse,5},{avse,5},{avse,5},{avse,5},{avsnether,5}," +   // 8 fields
                                       $"{row[5],2}," +
                                       $"{row[6],5},{row[7],5},{row[8],5},{row[9],5},{row[10],5},{row[11],5}," +
                                       $"{row[12],5},{row[13],5},{row[14],5},{row[15],5},{row[16],5},{row[17],5})" +
                                       $" /* {row[18]} */;\n";

                        else
                            sqltext += $"     , ({wcid},{row[0],3},{row[1],3},{row[2],3},{row[3],5},{row[4],5}," +   // 6 fields
                                   $"{avse,5},{avse,5},{avse,5},{avse,5},{avse,5},{avse,5},{avse,5},{avsnether,5}," +   // 8 fields
                                   $"{row[5],2}," +
                                   $"{row[6],5},{row[7],5},{row[8],5},{row[9],5},{row[10],5},{row[11],5}," +
                                   $"{row[12],5},{row[13],5},{row[14],5},{row[15],5},{row[16],5},{row[17],5})" +
                                   $" /* {row[18]} */\n";

                    }
                    counter++;
                }
            }
            if (rowcount > 0)
                sqltext += $"\n";
            else
            {
            }
            return sqltext;


        }
    }
}
