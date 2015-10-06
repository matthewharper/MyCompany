
/*mjh:  I don't think I want to mix the routing metaphors at the same time.  
        RoutConfig.cs in MVC vs. Angular's routeProvider.

        For the Corp site, I'll stick with .NET MVC routing and controllers.

        When I get deep into an Angular app, I'll add a Single Page App outside of .NET MVC routing to house that 
        angular application.  Then Angular views and routing will be used for the SPA.  
        I may load that SPA inside of an MVC layout just to keep the Nav, Headers, Styling consisten.  
        But the routing will be Angular routing, the views will be Angular views and I will serve the data via Web.API
*/

var corpSiteApp = angular.module("corpSiteApp", [
    //'ngRoute',
    'corpSiteControllers'
]);


//corpSiteApp.config(['$routeProvider',
//  function ($routeProvider) {
//      $routeProvider.
//        when('/phones', {
//            templateUrl: 'http://localhost:56863/Company/About'//,
//            //controller: 'PhoneListCtrl'
//        });
//  }]);

