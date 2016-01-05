angular.module('tasklist').controller('createTaskcontroller', ['$scope', 'taskService', function ($scope, taskService) {
    $scope.task = {};
    $scope.save = function() {
        taskService.save($scope.task).then(function (response) {
            console.log(response);
            $scope.task = {};
        }, function(error) {
            alert(error);
        });
    };
}]);