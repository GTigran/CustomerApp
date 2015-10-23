

if (customerApp) {

    //defining customer service 
    customerApp.service("customerDataService", function ($http) {


        var customerRestUrl = "/api/CustomerInfo";

        
        var retValue = {
            //gets customers list.
            getCustomers:function(success,error) {
                $http.get(customerRestUrl).success(function (data) {
                    success(data);
                }).error(function (data) {
                    error(data);
                });


            },
            getCustomer: function (cusromerId,success,error) {
                $http.get(customerRestUrl + "/" + cusromerId).success(function(data) {
                    success(data);
                }).error(function(data) {
                    error(data);
                });
            },
            upsertCustomer: function (customer,success) {
                if (customer.ID > 0) {
                    $http.put(customerRestUrl, customer).success(function(data) {
                        success(data);
                    });
                } else {
                    $http.post(customerRestUrl, customer).success(function (data) {
                        success(data);
                    });
                }
            },
            deleteCustomer: function (customerId,successCallback) {
                $http.delete(customerRestUrl + "/" + customerId).success(successCallback);
            }
        };

        return retValue;
    });
}