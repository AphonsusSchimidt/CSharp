using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using DataReaderMVC.Models;
namespace DataReaderMVC.Helper
{
    public abstract class ClassBase
    {


    }
    class ReadPdf
    {
        public static List<HS> GetDataByPdf(string path, List<string> type, params string[] stringAppearing)
        {
            PdfReader reader = new PdfReader(@path);
            int intPageNum = reader.NumberOfPages;
            List<string> lstLine = new List<string>();
            string text;
            List<HS> lst = new List<HS>();
            List<object> lstS = new List<object>();
            lstS.AddRange(stringAppearing);
            List<object> lstType = new List<object>();
            for (int i = 1; i <= intPageNum; i++)
            {
                Rules r = new Rules();
                r.RName = "Rules Check string Appearing";
                text = PdfTextExtractor.GetTextFromPage(reader, i);
                lstLine = text.Split('\n').ToList();
                r.AddRuleParam(text);
                stringAppearing.ToList().ForEach(u => r.AddRuleParam(u));

                r.AddCheckingMethod(new StringAppearing());
                bool b = r.IsValid;
                if (b)
                {
                    Rules r2 = new Rules();
                    r2.RName = "Rules Check string Appearing";
                    HS hs1 = new HS();
                    hs1 = (ChietXuatDuLieu.GetData(lstLine, stringAppearing));
                    r2.AddCheckingMethod(new TypeData());
                    r2.AddRuleParam(type, hs1.name, hs1.Place, hs1.Result, hs1.Score, hs1.Level);
                    bool br2 = r2.IsValid;
                    if (br2)
                    {
                        hs1.name = hs1.name.Remove(0, 2);
                        hs1.Place = hs1.Place.Remove(0, 2);
                        hs1.Result = hs1.Result.Remove(0, 2);
                        hs1.Score = hs1.Score.Remove(0, 2);
                        hs1.Level = hs1.Level.Remove(0, 2);
                        lst.Add(hs1);
                    }

                }


            }
            reader.Dispose();
            return lst;
        }

    }
}
