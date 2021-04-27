using AutoMapper;
using NoteOrg.Core.Domain;
using NoteOrg.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteOrg.Infrastructure.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize() 
        => new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Note, NoteDto>();
        })
        .CreateMapper();
    }
}
