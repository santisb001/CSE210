using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Job Job1 = new Job();
        Job1._company = "Microsoft";
        Job1._jobTitle = "Software Engeneer";
        Job1._startYear = 2019;
        Job1._endYear = 2022;
        
        Job Job2 = new Job();
        Job2._company = "Apple";
        job2._jobTitle = "Junior Programmer";
        Job2._startYear = 2017;
        job2._endYear = 2018;

        Resume Resume1 = new Resume();
        Resume1._name = "Santiago Sburlati";
        Resume1._jobs.add(Job1);
        Resume1._jobs.add(Job2);

        Resume1.Display();
   
    }

     
}
