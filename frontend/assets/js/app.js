let app = angular.module('app', []);
app.run(function($rootScope){
    $rootScope.title = "Pitagorátor"
    $rootScope.madeIn = new Date().getFullYear();
    $rootScope.company = "KoZiGi";
})