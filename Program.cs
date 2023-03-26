namespace CarsProject;
class Program //you want to have file name and class the same but it don't give errors for compilator, it will run
{
    //string color = "red"; ---mmoving to car.cs

    //Car carObj = new Car(); //this is not the best way as we want to do this inside the MAIN method!!

    static void Main(string[] args)
    {
        Car carObj1 = new Car("red", "Audi", 2020); //you can create this instance(object) multiple times, 
        //each time represents a new object, name needs to be different though
        Car carObj2 = new Car("silver", "BMW", 2021);
        Car carObj3 = new Car("black", "Volkswagen", 2019);
        Car carObj4 = new Car(); //since we gave no value, it will give our default values from car.cs

        carObj1.buyCar();

        Console.WriteLine($"Car color: {carObj1.color} model, car name: {carObj1.model}");
        Console.WriteLine(carObj2.color);
        Console.WriteLine(carObj3.color);
        Console.WriteLine($"Car color: {carObj4.color} model, car name: {carObj4.model}");
    }
}
