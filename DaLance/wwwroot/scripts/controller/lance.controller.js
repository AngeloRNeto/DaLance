(function (angular) {

    'use strict';

    angular.module('app.controllers').controller('LanceController', LanceController);

    LanceController.$inject = ['$scope', 'LanceBusiness'];

    function LanceController($scope, lanceBO) {
        lanceBO.GetList(function (res) {
            $scope.produtos = res;
            $scope.$apply();
        });

        $scope.newLance = function (id) {
            window.location.href = "/Lance/Create?id=" + id;
        };

        $scope.saveLance = function () {
            var url_string = window.location.href
            var url = new URL(url_string);
            var id = url.searchParams.get("id");

            if (id != null) {

                $scope.lance.produto_id = id;
                if (lanceBO.validate($scope.lance)) {

                    lanceBO.Create($scope.lance, function (res) {
                        alert("Lance Cadastrado!");
                        window.location.href = '/Home';
                    });
                }

            }
        };
    }

})(angular);