(function (ng) {
    'use strict';

    var ProductDetailController = ['$scope', function ($scope) {
        $scope.order = {};
        $scope.personalPaymentMethodText = "Dobírka";
        $scope.showShippingAddressInput = true;

        $scope.shipmentMethodChanged = function (currentShipmentMethod) {
            if (currentShipmentMethod === 'CeskaPosta') {
                $scope.personalPaymentMethodText = "Dobírka";
                $scope.showShippingAddressInput = true;
            } else {
                $scope.personalPaymentMethodText = "Hotově při odběru";
                $scope.showShippingAddressInput = false;
            }
        }
    }];

    ng.module('3whisky', [])
        .controller('ProductDetailController', ProductDetailController);

    ng.bootstrap(window.document, ['3whisky']);

}(window.angular));