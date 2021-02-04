(function (angular) {

    'use strict';

    angular.module('app.controllers').controller('UsuarioController', UsuarioController);

    UsuarioController.$inject = ['$scope', 'UsuarioBusiness'];

    function UsuarioController($scope, usuarioBO) {

        $scope.saveUser = function () {
            if (usuarioBO.validate($scope.usuario)) {

                usuarioBO.Create($scope.usuario, function (res) {
                    alert("Usuário Cadastrado!");
                    window.location.href = '/Home';
                });
            }

        };

    }

})(angular);