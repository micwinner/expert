app.service("ExpertRecordsService", function($http) {
    this.delUrl = "/home/delrecords/",
        this.addUrl = "/home/addrecords/",
        this.delete = function(id) {
            return $http.delete(this.delUrl + id);
        },
        this.list = function(postData) {
            return $http.post("/home/GetRecordsList", postData);
        };
});