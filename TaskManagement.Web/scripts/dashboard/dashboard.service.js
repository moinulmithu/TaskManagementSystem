angular.module('tasklist').controller('dashboardService', ['$resource', '$q', function($resource, $q) {
    var baseUrl = 'http://localhost:57793/api/';
    var getAll = function () {
        var defer = $q.defer();
        var resource = $resource(baseUrl + 'Project');
        resource.get(function(resource) {
            return defer.resolve(response);
        }, function(error) {
            return defer.reject(error);
        });
        return defer.promise;
    }
    return {
        getAll: getAll
    };
}]);