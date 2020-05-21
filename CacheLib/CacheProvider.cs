using Microsoft.Extensions.Caching.Memory;

namespace CacheLib
{
    public class CacheProvider
    {
        private readonly IMemoryCache _cache;
        private const string CacheKey = "cachekey";
        public CacheProvider(IMemoryCache cache)
        {
            _cache = cache;
        }

        public void AddCacheValue(string value)
        {
            _cache.Set(CacheKey, value);
        }

        public string GetCachedValue()
        {
            return _cache.Get<string>(CacheKey);
        }
    }
}
