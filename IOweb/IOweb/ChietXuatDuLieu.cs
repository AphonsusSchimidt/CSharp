using System;
using System.Collections.Generic;

namespace IOweb
{
    class ChietXuatDuLieu
    {
        public static HS GetData(List<string> lstLine, string[] DataAppearing)
        {
            HS hsrs = new HS();
            string rsS = (DataAppearing[2] + " " + DataAppearing[3] + " " + DataAppearing[4]);
            for (int i = 0; i < lstLine.Count; i++)
            {

                if (lstLine[i].Contains(DataAppearing[0].ToString()))
                {
                    hsrs.name = "S:"+ lstLine[i + 1];
                }
                if (lstLine[i].Contains(DataAppearing[1].ToString()))
                {
                    hsrs.Place = "S:"+ lstLine[i + 1];
                }
                if (lstLine[i].Contains(rsS))
                {
                    if (lstLine[i + 3].Contains("Level A2"))
                    {
                        hsrs.Result = "S:" + lstLine[i + 1] + " " + lstLine[i + 3];
                        string[] rs = lstLine[i + 2].Split(' ');
                        hsrs.Level = "S:" + rs[rs.Length - 1];
                        int score;
                        bool ok = int.TryParse(rs[rs.Length - 2], out score);
                        if (ok){hsrs.Score = "I:"+  score.ToString();}
                        else{hsrs.Score = "I:";}
                        break;
                    }
                    else
                    {

                        string[] rs = lstLine[i + 1].Split(' ');
                        int l = rs.Length;
                        if (l == 1)
                        {
                            hsrs.Result = "S:" + lstLine[i + 1];
                            hsrs.Level = "S:" ;
                            hsrs.Score = "I:";
                            break;
                        }
                        hsrs.Level = "S:" + rs[l - 1]; l--;
                      
                        int score;
                        bool ok = int.TryParse(rs[l - 1], out score);
                        if (ok) { hsrs.Score = "I:" + score.ToString(); }
                        else{hsrs.Score = "I:";}
                        l--;
                        for (int j = 0; j < l; j++)
                        {
                            if (l == 1) hsrs.Result = rs[j];
                            else
                            hsrs.Result += rs[j] + " ";
                        }
                             
                        hsrs.Result= "S:" + hsrs.Result;
                        break;
                    }
                }

            }
            // tách chuỗi theo type đã đưa vào
            return hsrs;
        }
        public static string GetString(string str)
        {

            return str;
        }
        public static int GetNumber(string str)
        {
            int rerutl = 0;
            string[] strmin;
            strmin = str.Split(' ');
            foreach (string i in strmin)
            {
                bool ok = int.TryParse(i, out rerutl);
                if (rerutl >= 120 && ok)
                {
                    break;
                }
            }
            return rerutl;
        }
        public static DateTime GetDateTiem(string str)
        {
            DateTime date = new DateTime(); ;
            return date;

        }

    }
}
