using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UploadPicture.Models;

namespace UploadPicture.Dtos
{
    public class MappingProfil : Profile
    {
        public MappingProfil()
        {
            

            CreateMap<Movie, MovieDto>();
            CreateMap<MovieDto, Movie>();



          





        }

    }
}
