(function (angular) {

    'use strict';

    angular.module('app.controllers').controller('HomeController', HomeController);

    HomeController.$inject = ['$scope', 'HomeBusiness'];

    function HomeController($scope, homeBO) {

        $scope.newProduct = function () {
            window.location.href = "/Produto/Create";
        };

       $scope.newUser = function () {
            window.location.href = "/Usuario/Create";
        };

        $scope.listLances = function () {
            window.location.href = "/Lance/List";
        };

    }

})(angular);