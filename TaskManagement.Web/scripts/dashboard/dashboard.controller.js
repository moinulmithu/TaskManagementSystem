angular.module('tasklist').controller('dashboardController', ['$scope', function ($scope) {
    $scope.pagename = "Dashboard";
    $scope.projects = ['Family', 'Work'];
        $scope.selectedProject = '';
    $scope.tasks = [];
    $scope.loadTasks = function (p) {
        $scope.selectedProject = p;
        $scope.tasks = [];
        for (var i = 0; i < 5; i++) {
            $scope.tasks.push(p + i);
        }
    }
    }
]);