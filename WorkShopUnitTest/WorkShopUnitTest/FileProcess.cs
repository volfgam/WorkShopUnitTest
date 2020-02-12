using System;
using System.IO;

namespace WorkShopUnitTest
{
    public class FileProcess
    {
        public bool FileExists(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentNullException($"Invalid file name.");
            }

            return File.Exists(fileName);
        }
    }
}