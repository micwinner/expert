app.service("ExpertInputService", function($http) {
    this.getCountryList = function() {
            return $http.get("/home/getcountrylist");
        },
        this.getpro = function(id) {
            return $http.get("/home/getpro/" + id);
        },
        this.getCity = function(id) {
            return $http.get("/home/getcity/" + id);
        },
        this.insert = function(postData) {
            return $http.post("/home/expertinput/", postData);
        };
});