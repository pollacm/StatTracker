var testController = angular.module('testController', []);

testController.controller('testController', ['$scope', function ($scope) {
        $scope.tests = [{ FirstName: "Curtis" }, { FirstName: "Ray" }];
    }]);