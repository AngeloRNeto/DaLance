(function () {

    'use strict';

    angular.module('app.repositories').factory('ProdutoRepository', ProdutoRepository);

    function ProdutoRepository() {

        this.GetList = function (_callback) {

            $.ajax({
                type: "GET",
                url: "/Produto/GetList",
                success: function (result) {
                    if (result)
                        _callback && _callback(result);
                }
            });
        };

        this.Create = function (data, _callback) {

            $.ajax({
                type: "POST",
                url: "/Produto/CreateProduto",
                data: data,
                success: function (result) {
                    if (result)
                        _callback && _callback(result);
                },
                async: true
            });
        };

        return this;
    }

})();