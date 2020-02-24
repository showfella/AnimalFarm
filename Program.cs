using System;

namespace Farm
{
    class Program
    {

        static void Main(string[] args)
        {

            Horse horse = new Horse("MrErd");
            horse.Speak();
            horse.product();
            horse.House();
            horse.eat();

            Console.Write("\n");

            Cows cow = new Cows("cow", "moo");
            cow.speak();
            cow.product();
            cow.House();
            cow.eat();


            Console.Write("\n");


            Goat goat = new Goat("goat", "bleat");
            goat.speak();
            goat.product();
            goat.House();
            goat.eat();


            Console.Write("\n");


            Dog dog = new Dog("dog", "bark");
            dog.speak();
            dog.product();
            dog.House();
            dog.eat();


        }
        public class Horse
        {
            string name;
            public Horse(string name)
            {
                this.name = name;
            }
            public void Speak()
            {
                Console.WriteLine("Hello my name is {0}, and i am  a horse. I say neigh", name);
            }


            public void eat()
            {
                Console.WriteLine("{0} eat hay", name);
            }

            public void product()
            {
                Console.WriteLine("{0} are used for racing", name);
            }

            public void House()
            {
                Console.WriteLine("{0} lives in stable", name);
            }

        }
        class Goat
        {
            string name;
            string language;
            public Goat(string name, string language)
            {
                this.name = name;
                this.language = language;
            }

            public void speak()
            {
                Console.WriteLine("Hello my name is {0}. I say {1}", name, language);
            }

            public void eat()
            {
                Console.WriteLine("{0} eat grass", name);
            }

            public void product()
            {
                Console.WriteLine("{0} provides milk", name);
            }

            public void House()
            {
                Console.WriteLine("{0} lives in Pen", name);
            }
        }
        public class Dog
        {
            string name;
            string language;

            public Dog(string name, string language)
            {
                this.name = name;
                this.language = language;
            }

            public void speak()
            {
                Console.WriteLine("Hello my name is {0}. I say {1}", name, language);
            }

            public void eat()
            {
                Console.WriteLine("{0} eats bones", name);
            }

            public void product()
            {
                Console.WriteLine("{0} is man's best friend", name);
            }

            public void House()
            {
                Console.WriteLine("{0} lives in Shed", name);
            }
        }
        public class Cows
        {
            string name;
            string language;
            public Cows(string name, string language)
            {
                this.name = name;
                this.language = language;
            }

            public void speak()
            {
                Console.WriteLine("Hello my name is {0}. I say {1}", name, language);
            }

            public void eat()
            {
                Console.WriteLine("{0} eat shrubs", name);
            }

            public void product()
            {
                Console.WriteLine("{0}  provides meat, skin and diary product", name);
            }

            public void House()
            {
                Console.WriteLine("{0} lives in bans", name);
            }
        }
    }
}