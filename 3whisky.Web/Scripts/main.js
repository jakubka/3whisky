(function (ng) {
    'use strict';

    var ProductDetailController = ['$scope', function ($scope) {
        $scope.order = {};
        $scope.personalPaymentMethodText = "Dobírka";
        $scope.personalPaymentMethodValue = 'Dobirka';
        $scope.showShippingAddressInput = true;
        
        $scope.totalPrice = productPrice;

        $scope.shipmentMethodChanged = function (currentShipmentMethod, priceForShipment) {
            if (currentShipmentMethod === 'CeskaPosta') {
                $scope.personalPaymentMethodText = "Dobírka";
                $scope.personalPaymentMethodValue = 'Dobirka';
                $scope.showShippingAddressInput = true;
            } else {
                $scope.personalPaymentMethodText = "Hotově při odběru";
                $scope.personalPaymentMethodValue = 'PriPrevzeti';
                $scope.showShippingAddressInput = false;
            }

            $scope.totalPrice = productPrice + priceForShipment;
        }
    }];

    ng.module('3whisky', [])
        .controller('ProductDetailController', ProductDetailController);

    ng.bootstrap(window.document, ['3whisky']);

}(window.angular));