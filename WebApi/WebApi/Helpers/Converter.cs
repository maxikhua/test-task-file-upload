using System.IO;
using Microsoft.AspNetCore.Http;

namespace Helpers
{
    public class Converter
    {
        public static string Convert(IFormFile file)
        {
            string s = default(string);

            if (file.Length > 0)
            {
                using (var theStream = new MemoryStream())
                {
                    file.CopyTo(theStream);
                    var fileBytes = theStream.ToArray();
                   s = System.Convert.ToBase64String(fileBytes);
                }
            }
            return s;
        }
    }
}