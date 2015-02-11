var testController = angular.module("testController", []);

testController.controller("testController", [
    "$scope", function($scope) {
        $scope.tests = [
            {
                FirstName: "Curtis",
                LastName: "Lofton",
                Number: 50,
                StartDate: new Date(2012, 1, 5)
            },
            {
                FirstName: "Ed",
                LastName: "Reed",
                Number: 38,
                StartDate: new Date(2013, 4, 8)
            },
            {
                FirstName: "Ray",
                LastName: "Lewis",
                Number: 52,
                StartDate: new Date(2001, 11, 18)
            },
            {
                FirstName : "Richard",
                LastName : "Sherman",
                Number : 19,
                StartDate : new Date(2010, 10, 15)
            },
            {
                FirstName : "Tim",
                LastName : "Jennings",
                Number : 27,
                StartDate : new Date(2004, 12, 10)
            },
            {
                FirstName : "J.J.",
                LastName : "Watt",
                Number : 78,
                StartDate : new Date(2011, 5, 9)
            },
            {
                FirstName : "Barry",
                LastName : "Church",
                Number : 27,
                StartDate : new Date(2013, 5, 14)
            },
            {
                FirstName : "Nick",
                LastName : "Roach",
                Number : 50,
                StartDate : new Date(2006, 8, 22)
            }
        ];

        $scope.gridOptions = { data: "tests" };
    }
]);