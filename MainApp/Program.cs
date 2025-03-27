using Domain;
using Infra;

// Computer computer = new Computer(8, 256, "Безпроводная клавиатура");
// computer.AddRam(8);
// computer.AddStorage(256);


// Laptop laptop = new Laptop(8, 512, "Заводская клавиатура", 1.9, 25);
// laptop.WeightCheck();
// laptop.SizeCheck();


// SmartPhone smartPhone = new SmartPhone(8, 256, "Проводная клавиатура", 100, "Readmi not 13 pro plus");
// smartPhone.TakeSelfies(22);
// System.Console.WriteLine("Модель телефона: " + smartPhone.ModelInfo());





// 2

Car car = new Car(4, "Black", 250, 56000);
car.AddMileage(34000);
car.MaxKmH(300);
car.GetInfo();


Airplane airplane = new Airplane(2, "White", 450, 200);
airplane.MaxKmH(500);
airplane.GetInfo();


Train train = new Train(24, "Brown", 200, 100);
train.MaxKmH(250);
train.GetInfo();


PassengerCar passengerCar = new PassengerCar(4, "Blue", 300, 56000, "Спойлер");
passengerCar.AddTuning();

CargoCar cargoCar = new CargoCar(12, "Grey", 120, 120000, 1000);