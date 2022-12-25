///<reference path = "angular.min.js" />
var MyApp = angular
    .module("myModule", [])
    .controller("myController", function ($scope) {

        var countries = [
            {
                name:"Uk", 
                cities: [
                    { name: "Lodon" },
                    {name:"Birmingham"},
                    {name:"Manchester"}
                    ]
            },
            {
                name: "USA",
                cities: [
                    { name: "Los Angeles" },
                    { name: "Chicago" },
                    {name:"Houston"}
                    ]
            },
            {
                name: "India",
                cities: [
                    {name:"Hyderabad"},
                    {name:"Chennai"},
                    {name:"Mumbai"}
                    ]

            }
        ];

        $scope.countries = countries;
    });


