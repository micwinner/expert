app.service("ExitRecordsService", function($http) {
    this.update = function(postData) {
            return $http.put("/home/saverecord", postData);
        },
        this.gettwo = function(id) {
            return $http.get("/home/gettwotree/" + id);
        },
        this.back = function($scope) {
            location.href = "/home/expertrecords/" + $scope.model.expertid;
        };
});