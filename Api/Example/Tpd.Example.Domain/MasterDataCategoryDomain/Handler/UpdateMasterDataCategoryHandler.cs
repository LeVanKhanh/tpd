using AutoMapper;
using Tpd.Example.Data.Write;
using Tpd.Example.Data.Write.Entities;
using Tpd.Example.Domain.HandlerBase.CommandHandlerBase;
using Tpd.Example.Domain.MasterDataCategoryDomain.Model;
using Tpd.Example.Domain.MasterDataCategoryDomain.Request;

namespace Tpd.Example.Domain.MasterDataCategoryDomain.Handler
{
    public class UpdateMasterDataCategoryHandler : CommandUpdateHandlerBase<UpdateMasterDataCategoryCommand, MasterDataCategory, MasterDataCategoryModel>
    {
        public UpdateMasterDataCategoryHandler(DatabaseWriteContext data, IMapper mapper)
            : base(data, mapper)
        {
        }
    }
}
