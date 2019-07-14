using FluentValidation;
using Tpd.Example.Data.Write.Entities;

namespace Tpd.Example.Data.Write.Validator
{
    public class MasterDataCategoryValidator: AbstractValidator<MasterDataCategory>
    {
        public MasterDataCategoryValidator()
        {
            RuleFor(x => x.Name).Length(0, 200);
            RuleFor(x => x.Description).Length(0, 1000);
        }
    }
}
