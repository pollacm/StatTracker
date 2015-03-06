var myApp = angular.module("myApp", ["ngRoute", "ngGrid", "ngResource", "angularStart.services", "angularStart.directives"]); //Define the main module

myApp
    .config([
        "$routeProvider", function($routeProvider) {
            //Setup routes to load partial templates from server. TemplateUrl is the location for the server view (Razor .cshtml view)
            $routeProvider
                .when("/home", { templateUrl: "/home/main", controller: "HomeController" })
                .when("/test", { templateUrl: "/home/test", controller: "TestController" })
                //.when("/about", { templateUrl: "/about/index", controller: "AboutController" })
                //.when("/demo", { templateUrl: "/demo/index", controller: "DemoController" })
                //.when("/angular", { templateUrl: "/angular/index" })
                .otherwise({ redirectTo: "/home" });
        }
    ])
    .controller("RootController", [
        "$scope", "$route", "$routeParams", "$location", function($scope, $route, $routeParams, $location) {
            $scope.$on("$routeChangeSuccess", function(e, current, previous) {
                $scope.activeViewPath = $location.path();
            });
        }
    ]);
