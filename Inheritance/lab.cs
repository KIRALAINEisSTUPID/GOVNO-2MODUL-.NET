//1 vazifa 

class Vehicle
{
    public int wheelAmount;
    public void getWheel()
    {
        Console.WriteLine($"{nameof(Object)} has  {wheelAmount} wheel(s)");
        
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
    public Bicycle(bool HasBasket) { }

}
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

