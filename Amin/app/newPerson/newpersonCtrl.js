app.controller('NewPersonCtrl', function ($scope, $location, $routeParams, $timeout) {

    $scope.addPerson = function () {

        //if ($scope.newPerson.firstName != "" && $scope.newPerson.lastName != "" &&
        //        $scope.newPerson.mother != "" && $scope.newPerson.gender != "") {
        //    var newPerson = {
        //        username: $scope.newPerson.username,
        //        password: $scope.newPerson.password,
        //        email: $scope.newPerson.email,
        //        phone: $scope.newPerson.phone
        //    };

        //    SignupService.register(newPerson)
        //        .then(
        //            loadRemoteData,
        //            function (errorMessage) {
        //                console.warn(errorMessage);
        //            }
        //        );
        //}
        //else {
        //    alert('נא מלא את כל הפרטים');
        //}
    };

    //// I load the remote data from the server.

    //function loadRemoteData(data) {
    //    if (data != null && data.User != null) {
    //        $scope.username = data.User.Username;

    //        $scope.user.username = data.User.Username;
    //        $scope.user.CID = data.User.CID;

    //        userDataService.save();

    //        $scope.isAlertSuccess = true;
    //        $timeout(function () { $scope.alertTimeout(); }, 1500);
    //    }
    //    else {
    //        $scope.isAlertDanger = true;
    //        $timeout(function () { $scope.alertDangrTimeout(); }, 2500);
    //    }
    //};

    //$scope.alertTimeout = function () {
    //    $location.url('/');
    //};

    //$scope.alertDangrTimeout = function () {
    //    $scope.isAlertDanger = false;
    //};

    //$scope.isAlertSuccess = false;
    //$scope.isAlertDanger = false;

    $scope.newPerson = {};
    $scope.newPerson.firstName = "";
    $scope.newPerson.lastName = "";
    $scope.newPerson.mother = "";
    $scope.newPerson.gender = "";

   // $scope.user = userDataService.getUserData();

});
