using System.Diagnostics;
using ExcelDataReader;
using OfficeOpenXml;

namespace Job_Portal_Project.Scripts
{
    public static class RunScript
    {
        public static void Run()
        {
            // Python betiğinin tam dosya yolu
            string pythonScriptPath = @"C:\Users\tahat\asp.net-workspace\Job-Portal-Project\Scripts\python.py";

            // Python komutunu çalıştırmak için bir süreç oluştur
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "python",
                Arguments = pythonScriptPath,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = new Process { StartInfo = startInfo })
            {
                process.Start();

                // Python çıktısını okuma
                string result = process.StandardOutput.ReadToEnd();

                // Python sürecinin tamamlanmasını bekleyin
                process.WaitForExit();

                // Çıktıyı görüntüle
                Console.WriteLine(result);
            }
        }
        public static List<string> ReadExcelColumn(string filePath, string columnName)
        {
            List<string> columnData = new List<string>();

            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    // İlk satırı oku (başlık satırı)
                    reader.Read();

                    // Sütun indeksini bul
                    int columnIndex = -1;
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        if (reader.GetValue(i).ToString().Equals(columnName, StringComparison.OrdinalIgnoreCase))
                        {
                            columnIndex = i;
                            break;
                        }
                    }

                    if (columnIndex == -1)
                    {
                        Console.WriteLine("Belirtilen sütun adı bulunamadı.");
                        return columnData;
                    }

                    // Sütundaki verileri oku
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(columnIndex))
                        {
                            string data = reader.GetString(columnIndex);
                            columnData.Add(data);
                        }
                    }
                }
            }

            return columnData;
        }

        public static string GetTextByAuthor(string filePath, string authorToSearch)
    {
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        using (var package = new ExcelPackage(new FileInfo(filePath)))
        {
            var workbook = package.Workbook;
            var worksheet = workbook.Worksheets.FirstOrDefault();

            if (worksheet != null)
            {
                int authorColumnIndex = GetColumnIndexByName(worksheet, "author");
                int textColumnIndex = GetColumnIndexByName(worksheet, "text");

                for (int row = 2; row <= worksheet.Dimension.Rows; row++) // Assuming the header is in the first row
                {
                    if (worksheet.Cells[row, authorColumnIndex].Text.Equals(authorToSearch, StringComparison.OrdinalIgnoreCase))
                    {
                        return worksheet.Cells[row, textColumnIndex].Text;
                    }
                }
            }

            return null; // Author not found or worksheet is empty
        }
    }
        public static int GetColumnIndexByName(ExcelWorksheet worksheet, string columnName)
        {
            for (int i = 1; i <= worksheet.Dimension.Columns; i++)
            {
                if (worksheet.Cells[1, i].Text.Equals(columnName, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }
            return -1; // Column not found
        }

    }
}