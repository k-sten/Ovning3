using System;

namespace Ovning3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person kalle = new Person();
            //kalle.Age = 12;
                        
            PersonHandler personHandler = new PersonHandler();

            Person Anders = personHandler.CreatePerson(20, "Anders", "Andersson", 180, 70);
            Person Sara = personHandler.CreatePerson(14, "Sara", "Nilsson", 155, 45);
            Person Johan = personHandler.CreatePerson(60, "Johan", "Mört", 175, 68);

            personHandler.SetAge(Sara, 15);
            personHandler.SetWeight(Johan, 72);
            personHandler.SetLName(Anders, "Karlsson");
            
        }
    }
}