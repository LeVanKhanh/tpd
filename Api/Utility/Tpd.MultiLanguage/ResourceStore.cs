using System.Collections.Generic;
using System.Linq;

namespace Tpd.MultiLanguage
{
    public class ResourceStore : IResourceStore
    {
        private static Dictionary<string, string> Store { get; set; }
        private const string KEY_FORMAT = "{0}_{1}";
        private const string DEFAULT = "default";

        public ResourceStore()
        {
            if (Store == null)
            {
                CreateStore();
            }
        }

        public string this[string culture, string name]
        {
            get
            {
                string result;
                if (Store.TryGetValue(string.Format(KEY_FORMAT, culture, name), out result)
                    || Store.TryGetValue(string.Format(KEY_FORMAT, DEFAULT, name), out result))
                {
                    return result;
                }
                return name;
            }
            set
            {
                Store[string.Format(KEY_FORMAT, culture, name)] = value;
            }
        }

        public string this[string name]
        {
            get
            {
                string result;
                if (Store.TryGetValue(string.Format(KEY_FORMAT, DEFAULT, name), out result))
                {
                    return result;
                }
                return name;
            }
            set
            {
                Store[string.Format(KEY_FORMAT, DEFAULT, name)] = value;
            }
        }

        public void CreateStore(List<ResourceEntry> resources = null)
        {
            if (resources == null)
            {
                Store = new Dictionary<string, string>();
                return;
            }

            Store = resources.ToDictionary(key => string.Format(KEY_FORMAT, key.Culture, key.Name),
                                           value => value.Value);
        }

        public void AddToStore(List<ResourceEntry> resources)
        {
            if (resources == null)
            {
                return;
            }
            foreach (var resource in resources)
            {
                this[resource.Culture, resource.Name] = resource.Value;
            }
        }

        public void Remove(string name)
        {
            string key = string.Format("_{0}", name);
            var removeItems = Store.Where(w => w.Key.Contains(key))
                .ToList();

            foreach (var item in removeItems)
            {
                Store.Remove(item.Key);
            }
        }
    }
}
