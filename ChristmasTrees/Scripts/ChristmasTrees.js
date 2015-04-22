var ChristmasTrees = angular.module('ChristmasTrees', ['ngRoute']);

ChristmasTrees.controller('LandingPageController', LandingPageController);
ChristmasTrees.controller('LoginController', LoginController);
ChristmasTrees.controller('RegistrationController', RegistrationController);

ChristmasTrees.factory('AuthHttpResponseInterceptor', AuthHttpResponseInterceptor);
ChristmasTrees.factory('LoginFactory', LoginFactory);
ChristmasTrees.factory('RegistrationFactory', RegistrationFactory)

var configFunction = function($routeProvider, $httpProvider) {
    $routeProvider
        .when('/routeOne', {
            templateUrl: 'routesDemo/one'
        })
        .when('/routeTwo/:donuts', {
            templateUrl: function(params) {
                return '/routesDemo/two?donuts=' + params.donuts;
            }
        })
        .when('/routeThree', {
            templateUrl: 'routesDemo/three'
        })
        .when('/login', {
            templateUrl: '/Account/Login',
            controller: LoginController
        })
        .when('/register', {
            templateUrl: '/Account/Register',
            controller: RegistrationController
        });

    $httpProvider.interceptors.push('AuthHttpResponseInterceptor');

}
configFunction.$inject = ['$routeProvider', '$httpProvider'];

ChristmasTrees.config(configFunction);