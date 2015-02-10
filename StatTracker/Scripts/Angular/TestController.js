angular.module('myApp', [])
    .controller('testController', ['$scope', function ($scope) {
        $scope.tests = [{ FirstName: "Curtis" }, { FirstName: "Ray" }];
    }]);