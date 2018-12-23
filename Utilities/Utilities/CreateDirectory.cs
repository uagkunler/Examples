using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Utilities
{
    public class CreateDirectory
    {
        public void CreateFolder(string path)
        {
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteFile(string path, string fileName)
        {
            try
            {
                if (!File.Exists(path + fileName))
                {
                    File.Delete(path + fileName);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void MoveFolderToOtherLocation(string sourcePath, string targetPath)
        {
            try
            {
                if(Directory.Exists(sourcePath))
                {
                    //Use path class tomanipulate file and ditectory paths
                    string sourceFile = Path.Combine(sourcePath);
                    string destinationFile = Path.Combine(targetPath);

                    //To copy a folder's contents to a new location
                    //Create a new target folder, if necessary.
                    Directory.CreateDirectory(targetPath);
                    string[] files = Directory.GetFiles(sourcePath);
                    Directory.Move(sourcePath, targetPath + DateTime.Now.ToString("MM-dd-yyyy-(HH-mm-ss)"));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
