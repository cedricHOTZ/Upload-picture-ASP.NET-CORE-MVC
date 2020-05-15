using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UploadPicture.Models
{
    public class Movie
    {
        

        [Key]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Le nom est obligatoire")]
        [Display (Name="Nom") ]
        public string Name { get; set; }

        [Display(Name = "Jaquette")]
        public string ProfileImage { get; set; }
    }
}
