using FluentValidation;
using FluentValidation.Results;

namespace Tpd.Core.Domain.FluentValidationCore
{
    public class FluentValidationService : IValidationService
    {
        private readonly IValidatorFactory _validatorFactory;

        public FluentValidationService(IValidatorFactory validatorFactory)
        {
            this._validatorFactory = validatorFactory;
        }

        public ValidationResult Validate<TEntity>(TEntity entity) where TEntity : class
        {
            var validator = _validatorFactory.GetValidator(entity.GetType());
            if (validator != null)
            {
                var result = validator.Validate(entity);
                return result;
            }
            return new ValidationResult();
        }
    }
}
