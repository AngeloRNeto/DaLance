(function (angular) {

    'use strict';

    angular.module('app.business').factory('UsuarioBusiness', UsuarioBusiness);

    UsuarioBusiness.$inject = ['UsuarioRepository'];

    function UsuarioBusiness(repository) {

        this.validate = function (model) {
            if (!model) {
                alert("Preencha os dados para o cadastro");
                return false;
            }
            if (!model.nome || model.nome == "") {
                alert("Nome é obrigatório para o cadastro!");
                return false;
            }

            if (!model.idade || model.idade == "") {
                alert("Idade é obrigatório para o cadastro!");
                return false;
            }

            return true;
        }

        this.Create = function (user, _callback) {
            repository.Create(user,function (res) {
                if(res)
                _callback && _callback(res);
            });
        }

        return this;
    }
    
})(angular);