using System.Web;
using System.Web.Optimization;

namespace ChristmasTrees
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));
            bundles.Add(new ScriptBundle("~/bundles/ChristmasTrees")
                .IncludeDirectory("~/Scripts/Controllers", "*.js")
                .IncludeDirectory("~/Scripts/Factories", "*.js")
                .Include("~/Scripts/ChristmasTrees.js"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
