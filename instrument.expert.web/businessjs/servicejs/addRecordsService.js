app.service("AddRecordsService", function($http) {
    this.savetodb = function(postData) {
            return $http.post("/home/addsaverecords", postData);
        },
        this.gettwo = function(id) {
            return $http.get("/home/gettwotree/" + id);
        };
    this.back = function($scope) {
        location.href = "/home/expertrecords/" + $scope.model.expertid;
    };
});