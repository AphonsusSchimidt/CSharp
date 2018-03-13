using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Collections.Generic;
using System.IO;
using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ReadDataEX
{
    class Nhanvien : Base
    {
        public string Hoten { get { return GetValueString(0); } set { SetData(0, value); } }
        public DateTime Ngaysinh { get { return GetValueDateTime(1); }  set { SetData(1,value); } }
    }
    class Base
    {
        List<string> lstFields = new List<string>();
        List<object> lstData = new List<object>();
        public void SetData(int index, object value)
        {
            lstData[index] = value;
        }
        public string GetValueString(int index)
        {
            return lstData[index] == null ? "" : lstData[index].ToString();
        }
        public DateTime GetValueDateTime(int index)
        {
            return lstData[index] == null ? new DateTime() : DateTime.Parse(lstData[index].ToString());
        }
    }
    abstract class ClassBase
    {
    }
    class ExcelController
    {
        public static void Write<T>(string path, List<T> lstObj, List<bool> fieldShow, string[] fieldname, string title, int rowstart, int columnstart) where T : ClassBase, new()
        {
            if (!System.IO.File.Exists(path))
            {
                using (ExcelPackage ExcelPkg = new ExcelPackage())
                {
                    ExcelWorksheet wsSheet1 = ExcelPkg.Workbook.Worksheets.Add("Sheet1");
                    ExcelPkg.SaveAs(new FileInfo(path));
                }
            }

            FileInfo workbook = new FileInfo(path);
            ExcelPackage myPackage = new ExcelPackage(workbook);
            ExcelWorksheet mySheet = myPackage.Workbook.Worksheets[1];

            if (rowstart < 3)
                rowstart = 3;
            mySheet.Cells[rowstart - 2, 1].Value = title;

            int columntitle = fieldname.Length;
            int row = lstObj.Count;
            object[,] alldata = new object[row + 1, columntitle];
            for (int i = 0; i < columntitle; i++)
            {
                alldata[0, i] = fieldname[i];
            }
            var range = mySheet.Cells[rowstart, columnstart, rowstart, columnstart + fieldname.Length - 1];
            range.Style.Fill.PatternType = ExcelFillStyle.Solid;
            range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.CornflowerBlue);

            if (lstObj.Count != 0)
            {

                for (int i = 1; i < lstObj.Count; i++)
                {
                    //alldata[i, 0] = lstObj[i].FullName;
                    //alldata[i, 1] = lstObj[i].YearOfBirth;
                    //alldata[i, 2] = lstObj[i].HomeTown;
                    //alldata[i, 3] = lstObj[i].Adress;
                    //alldata[i, 4] = lstObj[i].NameFather;
                    //alldata[i, 5] = lstObj[i].NameMother;
                }
            }
            mySheet.Cells[rowstart, columnstart, row + rowstart, columnstart + columntitle - 1].Value = alldata;
            myPackage.Save();
        }

        List<string> danhsachcactruong;
        List<object> dulieucuacactruong;
        public static List<T> ReadData<T>(string path) where T : Base, new()
        {
            List<T> lst = new List<T>();
            FileInfo workbook = new FileInfo(path);
            ExcelPackage myPackage = new ExcelPackage(workbook);
            ExcelWorksheet mySheet = myPackage.Workbook.Worksheets[1];
            object[,] alldata = (object[,])mySheet.Cells.Value;
            mySheet.Dispose();
            myPackage.Dispose();
            // creat List type
            List<object> lstType = new List<object>();
            Type a = typeof(System.String);
            a = typeof(T);
            // get Name type
            foreach (PropertyInfo str in a.GetProperties())
            {
                lstType.Add(str.Name);
            }
            // set Property in list T
            for (int i = 1; i < alldata.GetLength(0); i++)
            {

                T t = new T();
                int j = 0;
                foreach (PropertyInfo pr in t.GetType().GetTypeInfo().DeclaredProperties)
                {
                    string name = pr.Name;
                    int index = lstFileds.findIndex(name);
                    a = lstValue[index];
                   // pr.SetValue(t, alldata[i, j].ToString());
                }
            }
            return lst;
        }
    }
}