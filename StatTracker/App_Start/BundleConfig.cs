﻿using System.Web.Optimization;

namespace StatTracker
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/jquery.easing.min.js",
                "~/Scripts/jquery.prettyPhoto.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/eco.bootstrap.js",
                "~/Scripts/wow.min.js",
                "~/Scripts/eco.custom.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                "~/Scripts/angular.js",
                "~/Scripts/ng-grid.js",
                "~/Scripts/ng-grid-flexible-height.js",
                "~/Scripts/angular-resource.js",
                "~/Scripts/angular-route.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                "~/Scripts/Angular/app.js",
                "~/Scripts/app/services.js",
                "~/Scripts/app/directives.js",
                "~/Scripts/app/home.js",
                "~/Scripts/app/test.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/eco.bootstrap.css",
                "~/Content/font-awesome.min.css",
                "~/Content/eco.animate.css",
                "~/Content/prettyPhoto.css",
                "~/Content/ng-grid.css",
                "~/Content/Site.css",
                "~/Content/eco.style.css"));
        }
    }
}