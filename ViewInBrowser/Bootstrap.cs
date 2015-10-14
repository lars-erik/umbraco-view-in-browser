using Umbraco.Core;
using Umbraco.Web.Models.Trees;
using Umbraco.Web.Trees;

namespace ViewInBrowser
{
    public class Bootstrap : ApplicationEventHandler
    {
        protected override void ApplicationInitialized(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            base.ApplicationInitialized(umbracoApplication, applicationContext);

            RegisterPreviewMenuItem();
        }

        private void RegisterPreviewMenuItem()
        {
            TreeControllerBase.MenuRendering += (sender, args) =>
            {
                if (sender.TreeAlias == "content")
                {
                    var menuItem = new MenuItem("view-content-in-browser", "View in new tab");
                    menuItem.AdditionalData.Add("jsAction", "vib-viewInBrowserService.view");
                    args.Menu.Items.Add(menuItem);
                }
            };
        }
    }
}
