'use strict';


//var customers = angular.module('CustomerAngularClient.Customer', ['ngRoute','kendo.directives','$http'])


customerApp.controller('CustomerListController', function ($scope, customerDataService,helperUtils) {

    $scope.data = {
        Customers: [],
        Element: {}
    }


    //controller functionality
    
    
    function rebindList() {
        customerDataService.getCustomers(function (data) {
                $scope.data.Customers = data;
            }
        );
    }

    //switches popup mode, opens or closes
    function showHideEditModal(show,title) {
        $scope.showModal = typeof (show) == "boolean" ? show : false;
        $scope.popupTitle = title;
    }

    //resets lists data
    function resetElement() {
        $scope.data.Element = {};
    }

    //switches edit mode
    function switchPopupMode(isEditMode) {
        $scope.isEditMode = isEditMode == null || isEditMode;
    }

    $scope.IsEditMode = function() {
        return $scope.isEditMode;
    }

    //end controller functionality

    rebindList();


    //actions


    $scope.Edit = function (id) {
        showHideEditModal(true, "Edit Customer");
        switchPopupMode();
        customerDataService.getCustomer(id, function (data) {
            $scope.data.Element = data;
        });


    }

    $scope.Add = function () {
        
        showHideEditModal(true, "New Customer");
        switchPopupMode();
        resetElement();
     }

    $scope.SaveChanges = function () {
           customerDataService.upsertCustomer($scope.data.Element, function() {
                resetElement();
                showHideEditModal(false);
                rebindList();

            });
    }


    $scope.Details = function(id) {
        window.setTimeout(function () {
            showHideEditModal(true, "Customer Details");
            switchPopupMode(false);
            customerDataService.getCustomer(id, function (data) {
                $scope.data.Element = data;
            });
        });

    };


    $scope.Delete = function (id) {
        customerDataService.deleteCustomer(id, function (data) {
            if (data.Success) {
                rebindList();
            }
        });
    }

    //end actions
});


