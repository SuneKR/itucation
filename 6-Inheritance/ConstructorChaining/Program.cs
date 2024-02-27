namespace ConstructorChaining
{
    internal class Program
    {
        public class LivingObject
        {
            string sound;
            public LivingObject() 
            {
                Console.WriteLine("Parameterless constructor of LivingObject class");
            }

            public LivingObject(string sound)
            {
                this.sound = sound;
            }
        }
        
        public class Animal : LivingObject
        {
            string lyd = "";
            public Animal()
            {
                Console.WriteLine("Parameterless constrcutor of Animal class");
            }

            public Animal(string lyd) : base(lyd)
            {
                this.lyd = lyd;
                Console.WriteLine("Lyd fra constructor: " + lyd);
            }

            public virtual void MakeNoise() //virtual keyword means derived class can override method
            {
                Console.WriteLine("Make Noise Method: " + lyd);
            }
        }

        public class Cat : Animal
        {
            string sound;
            public Cat() : base("Meow") //when empty constructor have run, run the empty constructor from Animal
            {
                Console.WriteLine("Parameterles contructor of Cat class");
            }

            public Cat(string sound) : base(sound)
            {
                this.sound = sound;
            }

            public void MakeNoise()
            {
                Console.WriteLine("Cat sound");
            }
        }

        public class Horse : Animal
        {
            string sound;
            public Horse() : base("Neigh")
            {
                Console.WriteLine("Parameterless constructor of horse class");
            }
            public Horse(string sound) : base(sound)
            {
                this.sound = sound;
            }

            public override void MakeNoise() //overrides the parents class virtual method
            {
                Console.WriteLine("Horse sound");
            }
        }

        static void Main(string[] args)
        {
            //LivingObject lo = new LivingObject();
            Cat kat = new Cat("MEEEEOW!");
            //Cat kat2 = new Cat();
            Horse hest = new Horse("NEIIIGH");

            //kat.MakeNoise();
            //hest.MakeNoise();


            List<Animal> dyr = new List<Animal>() { kat, hest };
            foreach (Animal animal in dyr)
            {
                animal.MakeNoise();
            }
        }
    }
}
