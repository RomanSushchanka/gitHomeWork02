internal class Program
{
    static void Main(string[] args)
    {
        Zoo MinskZoo = new Zoo();
        Cat catLucy = new Cat("miao", "brown");

        MinskZoo.InsertToEnclose(catLucy);
        Cat catTima = new Cat("miao", "brown");
        MinskZoo.InsertToEnclose(catLucy);
        //
        Elephant elephantMurphy = new Elephant("ouuu", "grey", 20);
        Elephant elephantCharly = new Elephant("ouuu", "grey", 20);

        Console.WriteLine($"Are elephants eguals ? {elephantCharly.Equals(elephantMurphy)}");

        Console.ReadLine();
    }

    class Zoo
    {
        private IHerbivore[] herbivoresEnclose = new IHerbivore[10];
        private ICarnivore[] carnivoresEnclose = new ICarnivore[10];
        private int stateHerbivoresEnclose = 1;
        private int stateCarnivoresEnclose = 1;
        public void InsertToEnclose(Animal anim)
        {
            if (anim is IHerbivore)
            {
                if (stateHerbivoresEnclose == herbivoresEnclose.Length)
                {
                    Console.WriteLine("Full paddock");
                    return;
                }

              ((IHerbivore)anim).goToEnclose(herbivoresEnclose, stateHerbivoresEnclose);

            }
            else
            {
                if (stateCarnivoresEnclose == carnivoresEnclose.Length)
                {
                    Console.WriteLine("Full paddock");
                }
              ((ICarnivore)anim).goToEnclose(carnivoresEnclose, stateCarnivoresEnclose);
                stateCarnivoresEnclose++;
            }
        }


    }
    abstract class Animal
    {
        //classe completa
        protected string name = string.Empty;
        protected int numOfLegs = 0;
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName() { return name; }
        public void SetNumOfLegs(int legs)
        {
            this.numOfLegs = legs;
        }
        public int GetNumOfLegs() { return numOfLegs; }
        public abstract void DisplayAnimal();
    }
    interface ICarnivore
    {
        string TypeC { get; set; }
        string FoodC { get; set; }
        void displayEatC();

        void goToEnclose(ICarnivore[] carnEnclose, int stateEnclose);
    }

    interface IHerbivore
    {
        string TypeH { get; set; }
        string FoodH { get; set; }
        void displayEatH();
        void goToEnclose(IHerbivore[] herbEnclose, int stateEnclose);
    }
    class Cat : Animal, ICarnivore
    {
        private string sound = string.Empty;
        private string color = string.Empty;

        public Cat(string sound, string color)
        {
            this.sound = sound;
            this.color = color;
            this.SetName(GetType().Name);
            this.SetNumOfLegs(4);
        }
        public void displayEatC()
        {
            Console.WriteLine($"I am a {this.GetName()} and I am eating C");
        }
        public override void DisplayAnimal()
        {
            Console.WriteLine($"Hello I'am {this.GetName()} " +
                      $"and I have {this.GetNumOfLegs()} legs " +
                      $"my color is {color}" +
                      $"my sound is {sound}"
                      );

        }

        public void goToEnclose(ICarnivore[] carnEnclose, int stateEnclose)
        {
            Console.WriteLine($"I am a {this.GetName()} and I am going to Enclose in position {stateEnclose}");
            carnEnclose[stateEnclose] = this;
            DisplayAnimal();
            displayEatC();
        }




        public string TypeC { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FoodC { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    }

    class Bear : Animal, ICarnivore, IHerbivore
    {
        private string sound = string.Empty;
        private string color = string.Empty;

        public Bear(string sound, string color)
        {
            this.sound = sound;
            this.color = color;
        }
        public void displayEatH()
        {
            throw new NotImplementedException();
        }
        public void displayEatC()
        {
            throw new NotImplementedException();
        }
        public override void DisplayAnimal()
        {
            throw new NotImplementedException();
        }

        public void goToEnclose(ICarnivore[] carnEnclose, int stateEnclose)
        {
            carnEnclose[stateEnclose] = this;
        }

        public void goToEnclose(IHerbivore[] herbEnclose, int stateEnclose)
        {
            herbEnclose[stateEnclose] = this;
        }



        public string TypeC { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FoodC { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string TypeH { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FoodH { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }



    }

    class Elephant : Animal, IHerbivore, IEquatable<Elephant>
    {

        private string sound = string.Empty;
        private string color = string.Empty;
        private double size = 0;
        public Elephant(string sound, string color, double size)
        {
            this.sound = sound;
            this.color = color;
            this.size = size;
        }
        public void displayEatH()
        {
            throw new NotImplementedException();
        }
        public override void DisplayAnimal()
        {
            throw new NotImplementedException();
        }

        public void goToEnclose(IHerbivore[] herbEnclose, int stateEnclose)
        {
            herbEnclose[stateEnclose] = this;
        }

        public bool Equals(Elephant? otherElephant)
        {
            return this.size == otherElephant.size;
        }






        public string TypeH { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FoodH { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }




    }

}