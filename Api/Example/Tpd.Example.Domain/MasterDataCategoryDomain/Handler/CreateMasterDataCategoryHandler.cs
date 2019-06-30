using AutoMapper;
using Tpd.Example.Data.Write;
using Tpd.Example.Data.Write.Entities;
using Tpd.Example.Domain.HandlerBase.CommandHandlerBase;
using Tpd.Example.Domain.MasterDataCategoryDomain.Model;
using Tpd.Example.Domain.Request.MasterDataCategoryRequest;

namespace Tpd.Example.Domain.MasterDataCategoryDomain.Handler
{
    public class CreateMasterDataCategoryHandler : CommandCreateHandlerBase<CreateMasterDataCategoryCommand, MasterDataCategory, MasterDataCategoryModel>
    {
        public CreateMasterDataCategoryHandler(DatabaseWriteContext data, IMapper mapper)
            : base(data, mapper)
        {
        }
    }
}
