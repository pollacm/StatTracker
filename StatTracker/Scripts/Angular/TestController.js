var testController = angular.module("testController", []);

testController.controller("testController", function($scope, $http) {
        $http.get('api/testapi/all').success(function (data, status, headers, config) {
            $scope.tests = data;
        }).error(function (data, status, headers, config) {
            $scope.title = "Oops... something went wrong";
            $scope.working = false;
        });

        $scope.gridOptions = {
            data: "tests",
            plugins: [new NgGridFlexibleHeightPlugin()]
        };
    }
);

