
using System;

class Vehicle
{
    public string Brand;
    public int Year;

    public Vehicle(string brand, int year)
    {
        Brand = brand;
        Year = year;
    }

    public void Start()
    {
        Console.WriteLine(Brand + " is starting");
    }
}

class Car : Vehicle
{
    public int NumberOfDoors;

    public Car(string brand, int year, int doors)
        : base(brand, year)
    {
        NumberOfDoors = doors;
    }
}

class Bus : Vehicle
{
    public int Capacity;

    public Bus(string brand, int year, int capacity)
        : base(brand, year)
    {
        Capacity = capacity;
    }
}

class Motorcycle : Vehicle
{
    public bool HasSidecar;

    public Motorcycle(string brand, int year, bool sidecar)
        : base(brand, year)
    {
        HasSidecar = sidecar;
    }
}

class Program
{
    static void Main()
    {
        Car car = new Car("Toyota", 2020, 4);
        Bus bus = new Bus("Mercedes", 2022, 50);
        Motorcycle motorcycle =
            new Motorcycle("Honda", 2023, true);

        car.Start();
        bus.Start();
        motorcycle.Start();
    }
}
