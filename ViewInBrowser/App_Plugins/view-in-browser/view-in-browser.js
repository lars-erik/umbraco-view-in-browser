(function () {

    angular.module("umbraco").service("vib-viewInBrowserService", [
        "contentResource",
        function (contentResource) {
            function viewInBrowser(args) {
                contentResource.getNiceUrl(args.entity.id)
                    .then(function (url) {
                        window.open(url);
                    });
            };

            return {
                view: viewInBrowser
            }
        }
    ]);

}())