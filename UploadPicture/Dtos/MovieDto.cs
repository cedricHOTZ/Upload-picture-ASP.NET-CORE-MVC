using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UploadPicture.Dtos
{
    public class MovieDto
    {



        public int Id { get; set; }


        public string Name { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date de sortie")]

        public DateTime? DateDeSortie { get; set; }


        public IFormFile Photo { get; set; }




    }
}
