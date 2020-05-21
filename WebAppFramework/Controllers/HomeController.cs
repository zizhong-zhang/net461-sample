using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CacheLib;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;

namespace WebAppFramework.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var cacheProvider = new CacheProvider(new MemoryCache(Options.Create(new MemoryCacheOptions())));
            cacheProvider.AddCacheValue("cached title");
            
            ViewBag.Title = cacheProvider.GetCachedValue();

            return View();
        }
    }
}
