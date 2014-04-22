angular.module("sportsStore")
    .controller("sportsStoreCtrl", function($scope, $http) {
    $http.get('/sportsstore/api/products').then(function(resp) {
        $scope.data = {
            products: resp.data
        };
    });
});