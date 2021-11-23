/// <reference path="../lib/angular.js/angular.min.js" />
/// <reference path="../lib/angular.js/angular.js" />

var myApp = angular.module('app', []);
    var indexController = myApp.controller("DataCtrl", function ($scope,$http,$location)
    {

        $scope.myUrl = $location.path();
        console.log($scope.myUrl)
        $http({
            method: "Get",
            url: "/Home/GetDepartments"
        }).then(function sucsessCallBack(response) {
            $scope.departments = response.data;

            console.log($scope.departments);
        });

        $http({
            method: "Get",
            url: "/Home/GetTeachers"
        }).then(function sucsessCallBack(response) {
            $scope.Teachers = response.data.teachers;
            $scope.teacherCount = response.data.teachers.length;
            console.log($scope.Teachers)

        })

        $http({
            method: "Get",
            url: "/Home/GetStudents"
        }).then(function sucsessCallBack(response) {
            $scope.students = response.data.students;
            $scope.studentCount = response.data.students.length;
        })

        $http({
            method: "Get",
            url: "/Home/GetSubjects"
        }).then(function sucsessCallBack(response) {
            $scope.subjects = response.data;
            $scope.subjectCount = response.data.length;
        })

        $http({
            method: "Get",
            url: "/Home/GetSpecialities"
        }).then(function sucsessCallBack(response) {
            $scope.specialities = response.data;
            $scope.specialityCount = response.data.length;
        })

        $http({
            method: "Get",
            url: "/Home/GetGroups"
        }).then(function sucsessCallBack(response) {
            $scope.groups = response.data;
            $scope.groupCount = response.data.length;
            console.log($scope.groups)
        })
        
    })

var LinkController = myApp.controller("linkCtrl", function ($scope) {
    $scope.aboutUs = "/Home/AboutUs";
    $scope.home = "../";
    $scope.studentgrid="/Home/Students"
    $scope.studentlist = "/Home/StudentsList"
    $scope.teacherList = "/Home/Teachers"
    $scope.contact = "/Home/ContactUs"

})