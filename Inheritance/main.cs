using NAudio.Utils;

class App
{
    static void Main()
    {
        //=========================1 vazifa =========================

        //Car Natsuki = new Car(4);
        //Natsuki.getWheel();
        //Natsuki.NumberOfDoors(23);
        //======================================================================
        //2 vazifa 
        //=========================3 vazifa=========================
        Teacher BehruzAka = new Teacher(false);
        Student Alisher = new Student(true);
        Alisher.GPA(2323);
        Alisher.liveStatus();
        BehruzAka.Subject("biology");
        BehruzAka.liveStatus();
        ////====================================================================
    }
}
