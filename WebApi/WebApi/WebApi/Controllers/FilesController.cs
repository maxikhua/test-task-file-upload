using System;
using System.Threading.Tasks;
using Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace WebApi.Controllers
{
    [Route("api/files")]
    public class FilesController : Controller
    {
        [Route("upload")]
        [HttpPost]
        public async Task UploadFile([FromForm] IFormFile file)
        {
            var theUser = new User
            {
                Id = Guid.NewGuid(),
                FirstName = "Example First Name",
                LastName = "Example Last Name",
                Age = 23,
                DateCreated = DateTime.UtcNow,
                DateModified = DateTime.UtcNow,
                Image = Converter.Convert(file),
            };
            Console.WriteLine(theUser);
        }
    }
}