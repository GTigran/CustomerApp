



customerApp.service("helperUtils", function ($http) {


    var helpers = {
        ConfimDialog: function(confirmCallback,confirmText) {

            //will be replaced with bootstyrap popup
            if (confirm(confirmText)) {
                confirmCallback();
            }

        }

    };


    return helpers;


});