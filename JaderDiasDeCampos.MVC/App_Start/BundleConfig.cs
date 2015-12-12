using System.Web;
using System.Web.Optimization;

namespace JaderDiasDeCampos.MVC
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                        "~/js/jquery.min.js",
                        "~/js/bootstrap.min.js",
                        "~/js/jquery.easing.min.js",
                        "~/js/jquery.scrollTo.js",
                        "~/js/wow.min.js",
                        "~/js/custom.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/css/bootstrap.css",
                      "~/css/animate.css",
                      "~/css/style.css",
                      "~/css/bootstrap-social.css",
                      "~/color/default.css"));

             bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            BundleTable.EnableOptimizations = true;
        }
    }
}