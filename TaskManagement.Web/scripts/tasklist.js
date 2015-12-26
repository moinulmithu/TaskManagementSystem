
angular.module('tasklist', ['ngRoute', 'ngResource'])
    .config(['$routeProvider', function ($routeProvider) {
        $routeProvider.when('/', { templateUrl: 'views/dashboard/dashboard.tpl.html', controller: 'dashboardController' })
        .when('/dashboard', { templateUrl: 'views/dashboard/dashboard.tpl.html', controller: 'dashboardController' })
        .when('/projects', { templateUrl: 'views/projects/project.tpl.html', controller: 'projectcontroller' })
        .when('/projectdetail/:id', { templateUrl: 'views/projects/projectdetail.tpl.html', controller: 'projectdetailcontroller' })
        
        .when('/tasks', { templateUrl: 'views/tasks/task.tpl.html', controller: 'taskController' })
        .when('/taskdetail/:id', { templateUrl: 'views/tasks/taskDetail.tpl.html', controller: 'taskdetailController' })
         .otherwise({ redirecTo: '/' });
    }]);
    

