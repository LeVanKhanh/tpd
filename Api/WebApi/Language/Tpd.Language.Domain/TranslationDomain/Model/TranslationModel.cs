using System;
using Tpd.Core.Domain.ModelCore;

namespace Tpd.Language.Domain.TranslationDomain.Model
{
    public class TranslationModel : IEntityModel
    {
        public Guid Id { get; set; }
        public Guid ResourceDefaultId { get; set; }
        public Guid CultureId { get; set; }
        public string Display { get; set; }
    }
}
