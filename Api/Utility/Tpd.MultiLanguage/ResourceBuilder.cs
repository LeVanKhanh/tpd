using System.Threading.Tasks;

namespace Tpd.MultiLanguage
{
    public class ResourceBuilder
    {
        private IResourceStore _resourceStore;
        private IResourceService _serivce;

        public ResourceBuilder(IResourceStore resourceStore, IResourceService serivce)
        {
            _resourceStore = resourceStore;
            _serivce = serivce;
        }

        public void CreateCache()
        {
            var taskGetResource = GetAppResource();
            var taskGetAppResourceDefault = GetAppResourceDefault();
            var taskGetResourceCore = GetResourceCore();
            var taskGetResourceCoreDefault = GetResourceCoreDefault();
            Task.WaitAll(taskGetResource, taskGetAppResourceDefault, taskGetResourceCore, taskGetResourceCoreDefault);
        }

        private async Task GetAppResource()
        {
            var result = await _serivce.GetAppResource();
            _resourceStore.AddToStore(result);
        }

        private async Task GetAppResourceDefault()
        {
            var result = await _serivce.GetAppResourceDefault();
            _resourceStore.AddToStore(result);
        }

        private async Task GetResourceCore()
        {
            var result = await _serivce.GetResourceCore();
            _resourceStore.AddToStore(result);
        }

        private async Task GetResourceCoreDefault()
        {
            var result = await _serivce.GetResourceCoreDefault();
            _resourceStore.AddToStore(result);
        }
    }
}
