angular.module('tasklist').controller('createTaskcontroller', ['$scope', 'taskService', 'projectService', function ($scope, taskService, projectService) {
    $scope.task = {project : null};
    $scope.projects = [];
    $scope.save = function () {
        $scope.task.projectId = $scope.task.project.Id;
        console.log($scope.task);
        //taskService.save($scope.task).then(function (response) {
        //    console.log(response);
        //    $scope.task = {};
        //}, function(error) {
        //    alert(error);
        //});
    };
    var loadProjects = function () {
        projectService.getAll().then(function (response) {
            console.log(response);
            if (response.IsSuccess) {
                $scope.projects = response.Data;
            } else {
                alert(response.message);
            }
        }, function (error) {
            console.log(error);
        });
    }
    function init() {
        loadProjects();
    }
    init();
}]);