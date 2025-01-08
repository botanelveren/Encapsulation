using Encapsulation;

Car car1 = new Car("Ford", "Impala", "Black", 4);
Console.WriteLine($"Kapı sayısı: {car1.NumberOfDoors}");

Car car2 = new Car("Chevrolet", "Camaro", "Red", 3);
Console.WriteLine(car2.NumberOfDoors);