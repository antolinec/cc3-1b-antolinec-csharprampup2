namespace cc3_1b_antolinec_csharprampup2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight;
            Console.Write("Weight(lbs): ");
            weight = Convert.ToDouble(Console.ReadLine());
            double lbstokg = weight / 2.205f;
            Console.WriteLine("Weight in Kilograms: {0} kg", lbstokg);
            Console.WriteLine("==========================");

            double length;
            Console.Write("Length(mi): ");
            length = Convert.ToDouble(Console.ReadLine());
            double mitokm = length * 1.609344f;
            Console.WriteLine("Length in Kilometer: {0} km", mitokm);
            Console.WriteLine("==========================");

            double temperature;
            Console.Write("Temperature(°F): ");
            temperature = Convert.ToDouble(Console.ReadLine());
            double FtoC = (temperature - 32) * 5 / 9;
            Console.WriteLine("Temperature in Celsius: {0} C°", FtoC);
            Console.WriteLine("==========================");

            Console.WriteLine("Age of 10 Students:");
            double age1, age2, age3, age4, age5, age6, age7, age8, age9, age10;
            Console.Write("Student 1 Age: ");
            age1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Student 2 Age: ");
            age2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Student 3 Age: ");
            age3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Student 4 Age: ");
            age4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Student 5 Age: ");
            age5 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Student 6 Age: ");
            age6 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Student 7 Age: ");
            age7 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Student 8 Age: ");
            age8 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Student 9 Age: ");
            age9 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Student 10 Age: ");
            age10 = Convert.ToDouble(Console.ReadLine());

            double average = (age1 + age2 + age3 + age4 + age5 + age6 + age7 + age8 + age9 + age10) / 10;
            Console.WriteLine("Average age of Students is = {0}", average);
            Console.WriteLine("==========================");
            Console.WriteLine("");
            string character = "<Mikael>";
            string character1 = "<Claris the Healer>";
            string character2 = "<Joseph the Warrior>";
            string character3 = "<Anne the Mage>";
            string character4 = "<Mist the Assasin>";

            string equipment = "[Divine Sword]";
            string equipment1 = "[Staff of Life]";
            string equipment2 = "[Hammer of Minos]";
            string equipment3 = "[Merlin's Mantle]";
            string equipment4 = "[Serpent's Fangs]";

            string item = "-Health Potion-";
            string item1 = "-Mana Potion-";
            string item2 = "-Holy Water-";
            string item3 = "-Teleportation Crystal-";
            string item4 = "-Delicious Meat-";

            string abilities = "^Divine Justice^";
            string abilities1 = "^Greater Healing^";
            string abilities2 = "^Banishing Strike^";
            string abilities3 = "^Ultimate Art^";
            string abilities4 = "^Advance Art^";

            Console.WriteLine($"Once upon a time, in a world where magic flowed like a river and mythical creatures roamed freely,");
            Console.WriteLine($"there lived a ypung boy named {character} which soon will be known as {character} the Hero. {character} is a lively,");
            Console.WriteLine($"happy and has a strong justice. Suddenly one day, the demons army attack his village and burn down everything");
            Console.WriteLine($"in their way. After being attacked he becomes the only survivor of their village ever since {character}");
            Console.WriteLine($"never forget what happen in that day and made a promise to himself that no more village should suffer");
            Console.WriteLine($"just like what happened to their village. To achieve his goal he need to get stronger, so then he");
            Console.WriteLine($"set himself on a journey. On his 10 years of journey to become stronger he met 4 strong allies:");
            Console.WriteLine($"{character1}, {character2}, {character3}, {character4}. On their journey the have obtain");
            Console.WriteLine($"several equipments which made them stronger. {equipment} for {character}, {equipment1} for {character1},");
            Console.WriteLine($"{equipment2} for {character2}, {equipment3} for {character3}, {equipment4} for {character4}.");
            Console.WriteLine($"Everything is ready and it's time to defeat the one and only Demon Lord so they use {item3}");
            Console.WriteLine($"to go on the Demon Continent. On this journey they prepared several items in bountiful amount like");
            Console.WriteLine($"{item} for emergency heal, {item1} for mana, {item2} for status ailment, and {item4} for food." +
            $"The party fought various demons and managed to reach the demon castle using {character3}'s {abilities4} taking care of a lot of demons.");
            Console.WriteLine($"In the demon castle lived 3 strong commanders they managed to breakthrough " +
            $"those 3 by combining their different abilities like {abilities}, {abilities2} and {abilities4}. " +
            $"Before going to fight the Demon Lord {character1} used {abilities1} to heal the party injuries. " +
            $"Fighting the demon lord was tough and everyone are close to despair. All of them spammed each of their " +
            $"strongest abilities; {character4} used {abilities2}, {character3} cast her {abilities4} and {abilities3}, " +
            $"{character1} used {abilities1} for heals, {character2} swing his hammer as hard as he can while protecting " +
            $"the party and lasty {character} swings his sword and used {abilities} for the final blow. They managed to defeat " +
            $"the Demon Lord and the world became peaceful and that's how he became known as {character} the Hero.");

            Console.WriteLine("=================================");
            Console.WriteLine("Pattern 1 Enter a Number");
            int pat1 = Convert.ToInt32(Console.ReadLine());
            if (pat1 <= 0)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                for (int row = 1; row <= pat1; row++)
                {
                    for (int col = 1; col <= row; col++)
                    {
                        Console.Write(col + " ");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("=================================");
            Console.WriteLine("Pattern 2 Enter a Number");
            int pat2 = Convert.ToInt32(Console.ReadLine());
            if (pat2 <= 0)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                int result = 0;
                for (int a = 1; a <= pat2; a++)
                {
                    result += a;
                }
                Console.WriteLine("The sum of numbers from 1 to " + pat2 + " is " + result + " .");
            }
            Console.WriteLine("=================================");
            Console.WriteLine("Pattern 3 Enter a Number");
            int pat3 = Convert.ToInt32(Console.ReadLine());
            if (pat3 <= 0)
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                for (int row = pat3; row >= 0; row--)
                {
                    for (int col = 1; col <= row; col++)
                    {
                        Console.Write(col + " ");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine("=================================");
        }
    }
}
