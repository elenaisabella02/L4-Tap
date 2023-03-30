
public class Car{
	int Id;
	string Brand;
	string Model;
	bool IsElectric;
	int MaxSpeedKmh;
	int AutonomyKm;
}
List<Car> carList = new List<Car> {
new Car
{
	Id = 1,
	Brand = "Dacia",
	Model = "Spring",
	IsElectric = true,
	Autonomy = 300,
	MaxSpeedKmh = 120
},
new Car
{
	Id = 2,
	Brand = "VW",
	Model = "Polo",
	IsElectric = false,
	Autonomy = 850,
	MaxSpeedKmh = 180
},
new Car
{
	Id = 3,
	Brand = "Ford",
	Model = "Focus",
	IsElectric = false,
	Autonomy = 950,
	MaxSpeedKmh = 210
},
new Car
{
	Id = 4,
	Brand = "Tesla",
	Model = "Model 3",
	IsElectric = true,
	Autonomy =
500,
	MaxSpeedKmh = 260
},
new Car
{
	Id = 5,
	Brand = "Opel",
	Model = "Astra",
	IsElectric = false,
	Autonomy = 1010,
	MaxSpeedKmh = 190
}
}
public class CarRepository GetAll()
{
    public static List<Car> GetAll()
    {
        return new List<Car>
        {
            new Car 
            { 
                Id = 1, 
                Brand = "Dacia", 
                Model = "Spring", 
                IsElectric = true, 
                AutonomyKm = 300, 
                MaxSpeedKmh = 120 
            },
            new Car 
            { 
                Id = 2, 
                Brand = "VW", 
                Model = "Polo", 
                IsElectric = false, 
                AutonomyKm = 850, 
                MaxSpeedKmh = 180 },
            new Car 
            { 
                Id = 3, 
                Brand = "Ford", 
                Model = "Focus", 
                IsElectric = false, 
                AutonomyKm = 950, 
                MaxSpeedKmh = 210 
            },
            new Car 
            { 
                Id = 4, 
                Brand = "Tesla", 
                Model = "Model 3", 
                IsElectric = true, 
                AutonomyKm = 500, 
                MaxSpeedKmh = 260 
            },
            new Car 
            { 
                Id = 5, 
                Brand = "Opel", 
                Model = "Astra", 
                IsElectric = false, 
                AutonomyKm = 1010, 
                MaxSpeedKmh = 190 
            }

        };
    }
}

public class CarService: CarRepository
{
    private CarRepository carRepository;

    public CarService(CarRepository carRepository)
    {
        this.carRepository = carRepository;
    }


    public List<Car> GetHighSpeedCars()
    {
        List<Car> allCars = CarRepository.GetAll();

        return allCars.Where(c => c.MaxSpeedKmh > 180).ToList();
    }
}









