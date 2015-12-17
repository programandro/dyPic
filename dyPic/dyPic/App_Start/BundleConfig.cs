using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Optimization;

namespace dyPic
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/angular2")
                .Include("https://code.angularjs.org/2.0.0-beta.0/angular2-polyfills.js")
                .Include("https://code.angularjs.org/tools/system.js")
                .Include("https://code.angularjs.org/tools/typescript.js")
                .Include("https://code.angularjs.org/2.0.0-beta.0/Rx.js")
                .Include("https://code.angularjs.org/2.0.0-beta.0/angular2.dev.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery")
                .Include("~/Scripts/jquery-{version}.js"));

            bundles.Add(new StyleBundle("~/bundles/boostrap")
                .Include("~/Content/bootstrap*"));

            bundles.Add(new StyleBundle("~/bundles/dy")
                .Include("~/Content/dy*"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
