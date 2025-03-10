////=========================1 vazifa //=========================


class Vehicle
{
    public int wheelAmount;
    public void getWheel()
    {
        Console.WriteLine($"transport has  {wheelAmount} wheel(s)");
        
    }
}
class Car : Vehicle
{
    public Car(int wheelAmount) {
        this.wheelAmount = wheelAmount;
    
    }
    public void NumberOfDoors(int doorsCount)
    {
        Console.WriteLine($"thats doors count:{doorsCount}");
    }

}
class Bicycle : Vehicle {
    bool hasBasket;
    public Bicycle(bool HasBasket) {
        hasBasket = HasBasket;

    }
    public void Basket()
    {
        if (hasBasket==true) {
            Console.WriteLine("Has basket");
        
        }
        else
        {
            Console.WriteLine("hasnt basket");
        }
    }



}
////=========================//=========================
////=========================2 vazifa//=========================

class Employee 
{
    public int salary;
    public bool isWorked;
    public void getSalary()
    {
        if (isWorked == true)
        {
            Console.WriteLine($"worker will get {salary} for this month");
        }
        else
        {
            Console.WriteLine("we cant give money to worker who not worked");
        }
    }

}
class Developer : Employee
{

    public void ProgrammingLanguage(string pl)
    {
        Console.WriteLine("Programming lang is {0}",pl);
    }
}
class Manager : Employee
{ 
    public Manager(bool isWorked,int salary) {

        this.salary = salary;
        this.isWorked= isWorked; 
    
    }
    
    public void Bonus(int bonus)
    {
        if (bonus == 0)
        {
            Console.WriteLine("Nothing changed");
        }
        else if (bonus > 0)
        {
            Console.WriteLine($"{bonus}$ salary added to Developer");
        }
        else
        {
            Console.WriteLine("do u think writing code with OOP is easy?;|");

        }
        
    }
}


/////=========================//=========================
//3 vazifa
class Person
{
    protected bool isAlive;
    public void liveStatus()
    {
        if (isAlive==true) {
            Console.WriteLine($"Person Alive");
        
        }
        else {

            Console.WriteLine("Died person nothing can do");

        }
    }

}
class Student : Person { 
   public Student(bool isAlive)
   {
        this.isAlive = isAlive;
   }
    public void GPA(int gpa)
    {
        if (isAlive== false)
        {
            Console.WriteLine("Sorry our system cant show died students GPA");

        }
        else
        {
            Random rnd = new Random();
            Console.WriteLine($"Students GPA:{gpa},student is {rnd.Next(18,22)}");
        }
    }

}
class Teacher : Person
{
    public Teacher(bool isAlive)
    {
        this.isAlive = isAlive;
    }
    public void Subject(string subject)
    {
        if (isAlive == false)
        {
            Console.WriteLine("Sorry our system cant show died teachers subject");

        }
        else
        {
            Random rnd = new Random();
            Console.WriteLine($"Teacher subject:{subject},teacher is {rnd.Next(30, 60)}");
        }
    }

}

//=========================4 vazifa =========================





//===========================================================================
////=========================5 vazifa =========================
