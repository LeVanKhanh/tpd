using FluentValidation.Results;

namespace Tpd.Core.Handler.FluentValidationCore
{
    public interface IValidationService
    {
        ValidationResult Validate<TEntity>(TEntity entity) where TEntity : class;
    }
}
