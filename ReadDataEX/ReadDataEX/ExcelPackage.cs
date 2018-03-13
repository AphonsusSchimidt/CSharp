using System.IO;

namespace ReadDataEX
{
    internal class ExcelPackage
    {
        private FileInfo workbook;

        public ExcelPackage(FileInfo workbook)
        {
            this.workbook = workbook;
        }

        public object Workbook { get; internal set; }
    }
}