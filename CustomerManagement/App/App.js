//creating customer module.

var customerApp = angular.module('CustomerAngularClient', ['ngRoute']);

//, 'kendo.directives'


customerApp.config(["$routeProvider", function (routeProvider) {
    
    routeProvider
        .when("/", {
            templateUrl: "/App/Customer/Customer.html",
            controller: "CustomerListController"
        })
    ;
}]);