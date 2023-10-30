using System;
abstract class Transport

{
    public abstract void Move();
    public abstract int speed { get; set; }
    public virtual void Bip()
    {
        Console.WriteLine("Bip");
    }
    int age = 1;
    public virtual int Age
    {
        get => age;
        set { if (value > 0 && value < 110) age = value; }
    }
}




abstract class Cars : Transport
{
    public override void Move()
    {
        Console.WriteLine("Машина едет");
    }
    public override int speed
    {
        get => speed;
        set => speed = value;
    }
    public virtual void Bip()
    {
        Console.WriteLine("Bip");
    }
    public override int Age
    {
        get => base.Age;
        set { if (value > 17 && value < 110) base.Age = value; }
    }
}

abstract class Ships : Transport
{
    public override void Move()
    {
        Console.WriteLine("Корабль плывет");
    }
    public virtual void Bip()
    {
        Console.WriteLine("UUooooppp");
    }
    public override int Age
    {
        get => base.Age;
        set { if (value > 17 && value < 110) base.Age = value; }
    }
}
abstract class Bikes : Transport
{
    public override void Move()
    {
        Console.WriteLine("Велосипед едет");
    }
    public virtual void Bip()
    {
        Console.WriteLine("dzdz");
    }
    public override int Age
    {
        get => base.Age;
        set { if (value > 17 && value < 110) base.Age = value; }
    }
}
abstract class Moto : Transport
{
    public override void Move()
    {
        Console.WriteLine("Мотик едет на заданем ");
    }
    public virtual void Bip()
    {
        Console.WriteLine("dzdz");
    }
    public override int Age
    {
        get => base.Age;
        set { if (value > 17 && value < 110) base.Age = value; }
    }


}
abstract class Scooter : Transport
{
    public override void Move()
    {
        Console.WriteLine("Самокат едет");
    }
    public virtual void Bip()
    {
        Console.WriteLine("dzdzing");
    }
}
