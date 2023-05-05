using Abp.AspNetCore.Mvc.ViewComponents;

namespace LibrarySystem.Web.Views
{
    public abstract class LibrarySystemViewComponent : AbpViewComponent
    {
        protected LibrarySystemViewComponent()
        {
            LocalizationSourceName = LibrarySystemConsts.LocalizationSourceName;
        }
    }
}
