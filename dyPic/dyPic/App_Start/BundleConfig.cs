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
