using AutoMapper;
using Tpd.Language.Data.Entities;
using Tpd.Language.Domain.ApplicationDomain.Model;
using Tpd.Language.Domain.CultureDomain.Model;

namespace Tpd.Language.Domain
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Application, ApplicationModel>().ReverseMap();
            CreateMap<Culture, CultureModel>().ReverseMap();
        }
    }
}
