

customerApp.directive('modal', function () {



    return {
        templateUrl: "/App/Directives/PopupDirective/PopupDirective.html",
        restrict: 'E',
        transclude: true,
        replace: true,
        scope: true,
        link: function (scope, element, attrs) {
            scope.title = attrs.title;

            scope.$watch(attrs.showmodal, function (value) {
                if (value===true) {
                    $(element).modal("show");
                } else {
                    $(element).modal("hide");
                }
            });

            $(element).on("shown.bs.modal", function () {
                scope.$apply(function () {
                    scope.$parent[attrs.showmodal] = true;
                });
            });

            $(element).on("hidden.bs.modal", function () {
                scope.$apply(function () {
                    scope.$parent[attrs.showmodal] = false;
                });
            });
        }
    };
});