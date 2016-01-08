angular.module('tasklist').controller('dashboardController', ['$scope', 'dashboardService', 'projectService', function ($scope, dashboardService, projectService) {
    $scope.pagename = 'dashboard';
    $scope.projects = [];
        $scope.selectedProject = '';
    $scope.tasks = [];
        $scope.loadTasks = function(p) {
            $scope.selectedProject = p;
            $scope.tasks = [];
        
            
        };


        $scope.loadProjects = function () {
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
                $scope.loadProjects();
            }
            init();

        
    }]);