using AutoMapper;
using Restauracja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restauracja
{
    public class KlientMappingProfile: Profile
    {
        public KlientMappingProfile()
        {
            CreateMap<Klient, KlientDto>();
        }   

    }
}
