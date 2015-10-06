var corpSiteControllers = angular.module('corpSiteControllers', []);

corpSiteControllers.controller("aboutCtrl", ["$scope", function ($scope) {
    $scope.mattFoo = "Hello, this text came from the 'about' controller in angular!";
}]);


corpSiteControllers.controller("navSettingsCtrl", ["$scope", "$location", function ($scope, $location) {

    var url = $location.absUrl();
    var siteSection = url.split('/').pop()
    $scope.pageTitle = siteSection

    //mjh: This is wonky.  Will fix title later.  ng-attr seems more appropriate, but little issues like this is where you 
    //      can get bogged down.
    $scope.companyHome = "no";
    $scope.about = "no";
    $scope.news = "no";
    $scope.contact = "no";
    switch (siteSection.toLowerCase()) {
        case "company":
            $scope.companyHome = "current";
            break;
        case "about":
            $scope.about = "current";
            break;
        case "news":
            $scope.news = "current";
            break;
        case "contact":
            $scope.contact = "current";
            break;
        default:
            $scope.companyHome = "no";
            $scope.about = "no";
            $scope.news = "no";
            $scope.contact = "no";
            break;
    }
    $scope.siteSection = siteSection.toLowerCase();

}]);
