using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace StackOverflowProject
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/scripts/bootstrap").Include("~/scripts/jquery-3.3.1.js", "~/scripts/umd/popper.js", "~/scripts/bootstrap.js"));
            bundles.Add(new StyleBundle("~/styles/bootstrap").Include("~/Content/bootstrap.css"));
            bundles.Add(new StyleBundle("~/styles/site").Include("~/Content/styles.css"));
            BundleTable.EnableOptimizations = true;
        }
    }
}