using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tpd.MultiLanguage
{
    public class ResourceService : IResourceService
    {
        private readonly RpcClient _rpcClient;
        public ResourceService(RpcClient RpcClient)
        {
            _rpcClient = RpcClient;
        }

        private async Task<List<ResourceEntry>> GetResources(string application, string language)
        {
            return await _rpcClient.CallAsync(application, "", language);
        }

        public Task<List<ResourceEntry>> GetAppResource()
        {
            return GetResources("EX", string.Empty);
        }

        public Task<List<ResourceEntry>> GetAppResourceDefault()
        {
            return GetResources("EX", "default");
        }

        public Task<List<ResourceEntry>> GetResourceCore()
        {
            return GetResources("Core", string.Empty);
        }

        public Task<List<ResourceEntry>> GetResourceCoreDefault()
        {
            return GetResources("Core", "default");
        }
    }
}
