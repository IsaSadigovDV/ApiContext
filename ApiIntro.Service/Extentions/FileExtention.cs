using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiIntro.Service.Extentions
{
    public static class FileExtention
    {
        public static bool IsImage(this IFormFile file)
        {
            return file.ContentType.Contains("Image");
        }
        public static bool IsSizeOk(this IFormFile file, int mb)
        {
            return file.Length /1024 /1024 <= mb;
        }
    }
}
