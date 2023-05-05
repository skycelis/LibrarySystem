using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace LibrarySystem.Web.Views
{
    public abstract class LibrarySystemRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected LibrarySystemRazorPage()
        {
            LocalizationSourceName = LibrarySystemConsts.LocalizationSourceName;
        }
    }
}
