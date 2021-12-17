using System.Web;
using System.Web.Optimization;

namespace Healthy_Food
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            // Admin Layout
            bundles.Add(new StyleBundle("~/Admin/css").Include(
                      "~/Content/vendor/fontawesome-free/css/all.min.css",
                      "~/Content/css/sb-admin-2.min.css"));

            bundles.Add(new ScriptBundle("~/Admin/js").Include(
                      "~/Content/vendor/jquery/jquery.min.js",
                      "~/Content/vendor/bootstrap/js/bootstrap.bundle.min.js",
                      "~/Content/vendor/jquery-easing/jquery.easing.min.js",
                      "~/Content/js/sb-admin-2.min.js",
                      "~/Content/vendor/chart.js/Chart.min.js",
                      "~/Content/js/demo/chart-area-demo.js",
                      "~/Content/js/demo/chart-pie-demo.js"
                      ));
            // User Layout
            bundles.Add(new StyleBundle("~/User/css").Include(
                      "~/Content/User/styles/bootstrap4/bootstrap.min.css",
                      "~/Content/User/styles/shoppingcart.css",
                      "~/Content/User/plugins/font-awesome-4.7.0/css/font-awesome.min.css",
                      "~/Content/User/plugins/OwlCarousel2-2.2.1/owl.carousel.css",
                      "~/Content/User/plugins/OwlCarousel2-2.2.1/owl.theme.default.css",
                      "~/Content/User/plugins/OwlCarousel2-2.2.1/animate.css",
                      "~/Content/User/styles/main_styles.css",
                      "~/Content/User/styles/courses.css",
                      "~/Content/User/styles/about.css",
                      "~/Content/User/styles/about_responsive.css",
                      "~/Content/User/styles/register.css",
                      "~/Content/User/styles/responsive.css"
                      ));
            
            bundles.Add(new ScriptBundle("~/User/js").Include(
                      "~/Content/User/js/jquery-3.2.1.min.js",
                      "~/Content/User/styles/bootstrap4/popper.js",
                      "~/Content/User/styles/bootstrap4/bootstrap.min.js",
                      "~/Content/User/plugins/greensock/TweenMax.min.js",
                      "~/Content/User/plugins/greensock/TimelineMax.min.js",
                      "~/Content/User/plugins/scrollmagic/ScrollMagic.min.js",
                      "~/Content/User/plugins/greensock/animation.gsap.min.js",
                      "~/Content/User/plugins/greensock/ScrollToPlugin.min.js",
                      "~/Content/User/plugins/OwlCarousel2-2.2.1/owl.carousel.js",
                      "~/Content/User/plugins/parallax-js-master/parallax.min.js",
                      "~/Content/User/plugins/easing/easing.js",
                      "~/Content/User/js/custom.js"
                      ));
        }
    }
}
