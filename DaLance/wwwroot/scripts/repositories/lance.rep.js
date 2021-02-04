(function () {

    'use strict';

    angular.module('app.repositories').factory('LanceRepository', LanceRepository);

    function LanceRepository() {

        this.GetList = function (_callback) {

            $.ajax({
                type: "GET",
                url: "/Lance/GetList",
                success: function (result) {
                    if (result)
                        _callback && _callback(result);
                }
            });
        };

        return this;
    }

})();