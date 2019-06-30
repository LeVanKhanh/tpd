using MediatR;
using Tpd.Core.Domain.RequestCore.CommandCore;
using Tpd.Example.Domain.MasterDataCategoryDomain.Model;

namespace Tpd.Example.Domain.Request.MasterDataCategoryRequest
{
    public class CreateMasterDataCategoryCommand : CommandCreateCore<MasterDataCategoryModel>
    {

    }
}
