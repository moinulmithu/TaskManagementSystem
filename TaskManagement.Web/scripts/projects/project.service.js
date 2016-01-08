angular.module('tasklist').service('projectService', ['$resource', '$q', function ($resource, $q) {
    var baseUrl = 'http://localhost:57793/api/';

    var save = function(project) {
        var defer = $q.defer();
        var resource = $resource(baseUrl + 'Project');
        resource.save(project,function (response) {
            return defer.resolve(response);
        }, function (error) {
            return defer.reject(error);
        });
        return defer.promise;
    };
    var getAll = function() {
        var defer = $q.defer();
        var resource = $resource(baseUrl + 'Project');
        resource.get(function(response) {
            return defer.resolve(response);
        }, function(error) {
            return defer.reject(error);
        });
        return defer.promise;
    };
    return {
        save: save,
        getAll: getAll
    };
}]);