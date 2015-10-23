

customerApp.directive('confirmdialog', function () {



    return {
        templateUrl: "/App/Directives/ConfirmDialog/ConfirmDialog.html",
        restrict: 'E',
        replace: true,
        scope: true,
        link: function (scope, element, attrs) {


            function showHideDialog(show) {
                if (show === true) {
                    $(element).modal("show");
                } else {
                    $(element).modal("hide");
                }
            }

            scope.ConfirmText = attrs.confirmtext;

            scope.$watch(attrs.showconfirm, function (value) {
                if (value === true) {
                    $(element).modal("show");
                } else {
                    $(element).modal("hide");
                }
            });

            $(element).on("shown.bs.modal", function () {
                scope.$apply(function () {
                    scope.$parent[attrs.showconfirm] = true;
                });
            });

            $(element).on("hidden.bs.modal", function () {
                scope.$apply(function () {
                    scope.$parent[attrs.showconfirm] = false;
                });
            });


            scope.$watch(scope.$parent.showConfirm, function (value) {
                showHideDialog(value);
            });

            scope.Confirm = function () {
                window.setTimeout(function() {
                    if (scope.$parent.confirmCallBack) {
                        scope.$parent.confirmCallBack();
                        showHideDialog();
                    }
                });
            }

        }
    };
});