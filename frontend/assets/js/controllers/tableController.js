app.controller('tableData', function ($scope, $http){
    $scope.rows = [];
    
    $scope.getRows = function(){
        $http.get('http://localhost:8080/api/tickets').then(r=>{
            if (r.data!=null) $scope.rows = r.data;
        });
    }
    $scope.getRows();
    $scope.Delete = function(index){
        //TODO: Backend delete api path
        let auth = prompt('Kérem az authorizációs kulcsot!');
        $http.delete(`http://localhost:8080/api/delete-ticket/${index}`, {headers:{'Authorization':'Basic'+auth.toString()}}).then(function Success(res){
            alert("Sikeres törlés!");
            $scope.rows = [];
            $scope.getRows();
        }, function Fail(res){
            alert(res.data);
        });
    }
    $scope.Mailto = function(index){
        window.location.href = `mailto:${$scope.rows[$scope.rows.findIndex(e=>e.id==index)].email}`
    }
});