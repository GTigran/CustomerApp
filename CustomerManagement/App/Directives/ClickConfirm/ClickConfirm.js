

customerApp.directive('clickconfirm', function () {

    return {
        //only attribute selector

        restrict: 'A',
        replace: false,
        scope: false,
        link: function (scope, element, attrs) {

            $(element).on("click", function (e) {

                var functionName = attrs.clickconfirm;
                var param = attrs.clickconfirmparam;

                e.preventDefault();

                scope.$apply(function() {
                    scope.$parent.showConfirm = true;
                    scope.$parent.confirmText = attrs.confirmtext;
                });

                scope.$parent.confirmCallBack = function () {
                    if (scope.$parent[functionName]) {
                        scope.$parent[functionName](param);
                    }

                }
            });
        }
    };
});