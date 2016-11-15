using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Human h1 = new Human(Human.Gender.Female, Human.EyeColor.Brown, Human.HairColor.Black, Human.Height.Averege);
            Human h2 = new Human(Human.Gender.Male, Human.EyeColor.Blue, Human.HairColor.Blond, Human.Height.High);
            Human h3 = new Human(Human.Gender.Female, Human.EyeColor.Green, Human.HairColor.Purple, Human.Height.Short);

            Console.WriteLine(h1.GetDescription());
            Console.WriteLine(h2.GetDescription());
            Console.WriteLine(h3.GetDescription());


            // The LAST line of code should be ABOVE this line
        }
    }
}
