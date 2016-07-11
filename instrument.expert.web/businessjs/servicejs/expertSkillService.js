app.service("ExpertSkillService", function($http) {
    this.getimsortmainlist = function() {
            return $http.get("/home/getimsortmainlist");
        },
        this.getcls2byid = function(id) {
            return $http.get("/home/getcls2byid/" + id);
        },
        this.getcls3byid2 = function(id) {
            return $http.get("/home/getcls3byid2/" + id);
        },
        this.getsamplelist = function() {
            return $http.get("/home/getsamplelist");
        },
        this.getdomcls2byid = function(id) {
            return $http.get("/home/getdomcls2byid/" + id);
        },
        this.getdomcls3byid = function(id) {
            return $http.get("/home/getdomcls3byid/" + id);
        },
        this.insert = function(postData) {
            return $http.post("/home/expertskill", postData);
        };
});