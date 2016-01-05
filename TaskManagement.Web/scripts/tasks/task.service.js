angular.module('tasklist').service('taskService', ['$resource', '$q', function ($resource, $q) {
    var baseUrl = 'http://localhost:57793/api/';

    var save = function (project) {
        var defer = $q.defer();
        var resource = $resource(baseUrl + 'Task');
        resource.save(project, function (response) {
            return defer.resolve(response);
        }, function (error) {
            return defer.reject(error);
        });
        return defer.promise;
    };
    return {
        save: save
};
}]);