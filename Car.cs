class Car
{
    public string color; //without public wont work in program.cs
    public string model;
    public int year;

    //now we need to introduce a constructor (similar to method), usually public
    public Car(string modelColor, string modelName, int modelYear)
    {
        color = modelColor;
        model = modelName;
        year = modelYear;
    }

    public Car() //constructor without parameters we need to input default values
    {
        color = "blue";
        model = "audi";
        year = 2023;
    }
    
    public void buyCar() //this is a function, not constructor
    {
        Console.WriteLine("Car is sold");
    }

}