using FluentValidation.Results;

namespace Tpd.Core.Domain.FluentValidationCore
{
    public interface IValidationService
    {
        ValidationResult Validate<TEntity>(TEntity entity) where TEntity : class;
    }
}
