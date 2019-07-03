using System.Collections.Generic;

namespace Tpd.MultiLanguage
{
    public interface IResourceStore
    {
        string this[string culture, string name] { get; set; }
        string this[string name] { get; set; }
        void CreateStore(List<ResourceEntry> resources);
        void AddToStore(List<ResourceEntry> resources);
        void Remove(string name);
    }
}
