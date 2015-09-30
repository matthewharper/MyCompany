
var corpSite = angular.module("corpSite", []);


corpSite.controller("corpHome", ["$scope", function ($scope) {
    $scope.mattFoo = "Hello, this text came from your corpSite module and corpHome controller in Angular!";
}]);
    
corpSite.controller("navSettings", ["$scope", "$location", function ($scope, $location) {
    //$location..$locationProvider.html5Mode(true);
    $scope.mattTitle = "$location.path()";
    var url = $location.absUrl();
    
}]);



