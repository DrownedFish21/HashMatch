using System.Security.Cryptography;
using static WuHaoHash.FrmMain;

namespace WuHaoHash
{
    public class HashDirectory
    {
        public static TheFile[]? Main(string directory)
        {
            int i = 0;
            if (Directory.Exists(directory))
            {
                var dir = new DirectoryInfo(directory);
               
                FileInfo[] files = dir.GetFiles();
                TheFile[] theFile = new TheFile[files.Length];
             
                using (SHA256 mySHA256 = SHA256.Create())
                {
                  
                    foreach (FileInfo fInfo in files)
                    {
                        
                        using (FileStream fileStream = fInfo.Open(FileMode.Open))
                        {
                            try
                            {
                              
                                fileStream.Position = 0;
                                byte[] hashValue = mySHA256.ComputeHash(fileStream);
                                theFile[i].Name = fInfo.Name;
                                theFile[i].HashValue = PrintByteArray(hashValue);
                                theFile[i].FilePath = directory + "\\" + fInfo.Name;
                            }
                            catch (IOException e)
                            {
                                Console.WriteLine($"I/O Exception: {e.Message}");
                            }
                            catch (UnauthorizedAccessException e)
                            {
                                Console.WriteLine($"Access Exception: {e.Message}");
                            }
                        }
                        i++;
                    }
                    return theFile;
                }
            }
            else
            {
                return null;
            }            
        }

   
        public static string PrintByteArray(byte[] array)
        {
            string? res = null;
            for (int i = 0; i < array.Length; i++)
            {
                res += $"{array[i]:X2}";
                //if ((i % 4) == 3)
                //    res += " ";
            }
            res += "\n";
            return res;
        }
    }
}
