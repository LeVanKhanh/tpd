using System.Linq;
using System.Threading.Tasks;
using Tpd.Core.Data;
using Tpd.Core.Handler.FluentValidationCore;
using Tpd.Language.Data;
using Tpd.Language.Domain.HandlerBase.QueryHandlerBase;
using Tpd.Language.Domain.TranslationDomain.Request;
using Tpd.Language.Domain.TranslationDomain.Result;

namespace Tpd.Language.Domain.TranslationDomain.Handler
{
    public class GetTranslationsHandler : QueryListHandlerBase<GetTranslationsQuery, ResoureEntryModel>
    {
        public GetTranslationsHandler(DatabaseContext data, IValidationService validationService)
            : base(data, validationService)
        {

        }

        protected override async Task<IQueryable<ResoureEntryModel>> BuildQueryAsync(GetTranslationsQuery query, RequestContextCore context)
        {

            if (string.IsNullOrEmpty(query.Application))
            {
                return null;
            }

            var moduleMapLanguage = Data.ModuleResource.AsQueryable();

            if (!string.IsNullOrEmpty(query.Module))
            {
                var moduleId = Data.Module.Where(w => w.Application.ShortName == query.Application
               && w.Name == query.Module).Select(s => s.Id).FirstOrDefault();

                moduleMapLanguage = moduleMapLanguage.Where(w => w.ModuleId == moduleId);
            }
            else
            {
                var applicationId = Data.Application.Where(w => w.ShortName == query.Application)
                    .Select(s => s.Id).FirstOrDefault();

                moduleMapLanguage = moduleMapLanguage.Where(w => w.Module.ApplicationId == applicationId);
            }

            var translation = Data.Translation.AsQueryable();

            if (!string.IsNullOrEmpty(query.Culture))
            {
                var languageId = Data.Culture.Where(w => w.Code == query.Culture).Select(s => s.Id).FirstOrDefault();
                translation = translation.Where(w => w.CultureId == languageId);
            }

            var dataQuery = from map in moduleMapLanguage
                            join tran in translation
                            on map.Baseline.Id equals tran.ResourceDefault.Id into tmpBaseline
                            from trans in tmpBaseline.DefaultIfEmpty()
                            select new ResoureEntryModel
                            {
                                Name = map.Baseline.Name,
                                Value = trans == null ? map.Baseline.Value : trans.Display,
                                Culture = trans == null ? "default" : trans.Culture.Code
                            };

            return dataQuery;
        }
    }
}
