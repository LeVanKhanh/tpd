﻿using AutoMapper;
using DataWriteEntities = Tpd.Example.Data.Write.Entities;
using DataReadEntities = Tpd.Example.Data.Read.Entities;
using Tpd.Example.Domain.MasterDataCategoryDomain.Model;

namespace Tpd.Example.Domain.MasterDataCategoryDomain
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<DataWriteEntities.MasterDataCategory, MasterDataCategoryModel>().ReverseMap();
            CreateMap<DataReadEntities.MasterDataCategory, MasterDataCategoryModel>().ReverseMap();
        }
    }
}
