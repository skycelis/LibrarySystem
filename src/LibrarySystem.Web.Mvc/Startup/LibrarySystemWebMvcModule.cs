using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LibrarySystem.Configuration;

namespace LibrarySystem.Web.Startup
{
    [DependsOn(typeof(LibrarySystemWebCoreModule))]
    public class LibrarySystemWebMvcModule : AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public LibrarySystemWebMvcModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<LibrarySystemNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LibrarySystemWebMvcModule).GetAssembly());
        }
    }
}
