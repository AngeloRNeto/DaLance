(function (angular) {

    'use strict';

    angular.module('app.controllers').controller('ProdutoController', ProdutoController);

    ProdutoController.$inject = ['$scope', 'ProdutoBusiness'];

    function ProdutoController($scope, produtoBO) {

        $scope.saveProduct = function () {
            if (produtoBO.validate($scope.produto)) {

                produtoBO.Create($scope.produto, function (res) {
                    alert("Produto Cadastrado!");
                    window.location.href = '/Home';
                });
            }

        };

    }

})(angular);