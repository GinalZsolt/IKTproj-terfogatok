app.controller('tableData', function ($scope, $http){
    $scope.rows = [];
    $http.get('http://localhost:5500/frontend/assets/js/controllers/MOCK_DATA.json').then(r=>{
        if (r.data!=null) $scope.rows = r.data;
        console.log($scope.rows)
    });
    $scope.Delete = function(index){
        //TODO: Backend delete api path
        $http.delete(`http://localhost:3000/api/delete`, {data:index}).then(r=>console.log(r.status));
    }
    $scope.Mailto = function(index){
        window.location.href = `mailto:${$scope.rows[$scope.rows.findIndex(e=>e.id==index)].email}`
    }
});