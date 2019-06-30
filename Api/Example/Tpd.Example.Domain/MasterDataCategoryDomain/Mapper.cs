using AutoMapper;
using Tpd.Example.Data.Write.Entities;
using Tpd.Example.Domain.MasterDataCategoryDomain.Model;

namespace Tpd.Example.Domain.MasterDataCategoryDomain
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<MasterDataCategory, MasterDataCategoryModel>().ReverseMap() ;
        }
    }
}
