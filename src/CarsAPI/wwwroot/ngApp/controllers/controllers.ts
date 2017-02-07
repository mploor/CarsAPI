namespace CarsAPI.Controllers {

    export class HomeController {
        public cars;

        constructor(private $http: ng.IHttpService) {
            this.$http.get("/api/cars").then((response) => {
                this.cars = response.data;
            });
        }
    }



    export class AboutController {
        public car;

        constructor(private $stateParams: ng.ui.IStateParamsService, private $http: ng.IHttpService) {
            let carId = this.$stateParams["id"];

            this.$http.get("/api/cars/" + carId).then((response) => {
                this.car = response.data;
            });
        }
    }

}
