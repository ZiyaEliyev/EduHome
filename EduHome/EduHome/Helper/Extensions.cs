using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Threading.Tasks;

namespace EduHome.Helper
{
    public static class Extensions
    {
        public static bool IsImage(this IFormFile file)
        {
            return file.ContentType.Contains("image/");
        }
        
        public static bool IsOlder1Mb(this IFormFile file)
        {
            return file.Length/1024 > 1024;
        }
        public static async Task<string> SaveFileAsync(this IFormFile file,string folder)
        {
            string filename = Guid.NewGuid().ToString()+file.FileName;
            string path = Path.Combine(folder, filename);
            using (FileStream fileStream=new FileStream(path,FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            return filename;
        }
    }
}
