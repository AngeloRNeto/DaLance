(function (angular) {

    'use strict';

    angular.module('app.business').factory('LanceBusiness', LanceBusiness);

    LanceBusiness.$inject = ['LanceRepository', 'ProdutoRepository'];

    function LanceBusiness(repository, produtoRepository) {

        this.validate = function (model) {

            if (!model) {
                alert("Preencha os dados para o cadastro");
                return false;
            }

            if (!model.valor || model.valor == "") {
                alert("Valor é obrigatório para o cadastro!");
                return false;
            }

            if (!model.usuario || model.usuario == "") {
                alert("Apostador é obrigatório para o cadastro!");
                return false;
            }

            return true;
        }


        this.GetList = function (_callback) {
            produtoRepository.GetList(function (res) {
                if (res)
                    _callback && _callback(res);
            });
        }

        return this;
    }

})(angular);