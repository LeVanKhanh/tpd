using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tpd.MultiLanguage
{
    public interface IResourceService
    {
        Task<List<ResourceEntry>> GetAppResource();
        Task<List<ResourceEntry>> GetAppResourceDefault();
        Task<List<ResourceEntry>> GetResourceCore();
        Task<List<ResourceEntry>> GetResourceCoreDefault();
    }
}
