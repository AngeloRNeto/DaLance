(function (angular) {

    'use strict';

    angular.module('app.business').factory('HomeBusiness', HomeBusiness);

    HomeBusiness.$inject = ['HomeRepository'];

    function HomeBusiness(repository) {

  
        this.getParameters = function (_callback) {
            repository.GetAll(function (res) {
                if(res)
                _callback && _callback(res);
            });
        }

        this.saveUser = function (user, _callback) {
            repository.SaveUser(user,function (res) {
                if(res)
                _callback && _callback(res);
            });
        }

        return this;
    }



})(angular);