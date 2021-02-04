(function () {

    'use strict';

    angular.module('app.repositories').factory('UsuarioRepository', UsuarioRepository);

    function UsuarioRepository() {


        this.Create = function (data, _callback) {
            $.ajax({
                type: "POST",
                url: "/Usuario/CreateUsuario",
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