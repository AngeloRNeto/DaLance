(function (angular) {

    'use strict';

    angular.module('app.business').factory('ProdutoBusiness', ProdutoBusiness);

    ProdutoBusiness.$inject = ['ProdutoRepository'];

    function ProdutoBusiness(repository) {

        this.validate = function (model) {
            if (!model) {
                alert("Preencha os dados para o cadastro");
                return false;
            }

            if (!model.nome || model.nome == "") {
                alert("Nome é obrigatório para o cadastro!");
                return false;
            }

            if (!model.valor || model.valor == "") {
                alert("Valor é obrigatório para o cadastro!");
                return false;
            }

            return true;
        }

        this.Create = function (product, _callback) {
            repository.Create(product,function (res) {
                if(res)
                _callback && _callback(res);
            });
        }

        return this;
    }
    
})(angular);