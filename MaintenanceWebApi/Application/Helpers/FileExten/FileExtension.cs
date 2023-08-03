using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Helpers.FileExten
{
    public static partial class FileExtension
    {
        public static bool CheckFileLenght(this IFormFile file, int size)
        {
            return file.Length < size;
        }

        public static bool CheckFileType(this IFormFile file)
        {
            return file.ContentType.Contains("image");
        }

        public static bool CheckIsFileUploaded(this IFormFile file)
        {
            return file == null;
        }

        public static void DeleteFile(string filePath)
        {
            if (System.IO.File.Exists(filePath)) // checking whether path exist
            {
                System.IO.File.Delete(filePath); // deleting file from the path
            }
        }

        public static string SaveFile(this IFormFile file, IWebHostEnvironment _webHostEnvironment, string folderName)
        {
            string fileName = Guid.NewGuid() + file.FileName; // this is generating new random name 
            string path = Path.Combine(_webHostEnvironment.WebRootPath, folderName, fileName);

            using (FileStream stream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            return fileName;
        }

    }
}
