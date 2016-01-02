angular.module('tasklist').controller('createProjectcontroller', ['$scope', 'projectService', function ($scope, projectService) {
    $scope.project = {};
    $scope.save = function() {
        projectService.save($scope.project).then(function(response) {
            console.log(response);
            $scope.project = {};
        }, function(error) {
            alert(error);
        });
    };
}]);