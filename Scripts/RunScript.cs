using System.Diagnostics;

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

    }
}