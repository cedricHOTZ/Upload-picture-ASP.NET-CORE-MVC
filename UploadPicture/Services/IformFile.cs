using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UploadPicture.Models;

namespace UploadPicture.Services
{
    public interface IFormFile
    {
        string ContentType { get; set; }
        string ContentDisposition { get; set; }
        IHeaderDictionary Headers { get; set; }
        long Length { get; set; }
        string Name { get; set; }
        string FileName { get; set; }

        Stream OpenReadStream { get; set; }

        void CopyTo(Stream target);
        Task CopyToAsync(Stream target, System.Threading.CancellationToken cancellationToken);

       

    }
}
