using static Program;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Zoo zoo = new Zoo();

            Bear bear = new Bear();
            zoo.AddToEnclosure(bear);

            Rabbit rabbit = new Rabbit();
            zoo.AddToEnclosure(rabbit);

            Wolf wolf = new Wolf();
            zoo.AddToEnclosure(wolf);

            Bear bear2 = new Bear();
            zoo.AddToEnclosure(bear2);

            Deer deer = new Deer();
            zoo.AddToEnclosure(deer);

            Deer deer2 = new Deer();
            zoo.AddToEnclosure(deer2);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }


    }

    protected class Zoo
    {
        private HerbivoreAnimal[] _arrayHerbivoreAnimal = new HerbivoreAnimal[2];
        private Predator[] _arrayPredator = new Predator[2];

        
        public void AddToEnclosure(Animal anim)
        {
            bool b = false;
            if (anim is HerbivoreAnimal) 
            {
                for (int i = 0; i < _arrayHerbivoreAnimal.Length; i++)
                {
                    if (_arrayHerbivoreAnimal[i] == null)
                    {
                        b = true;
                    }
                }

                if (b == false)
                {
                    //throw new InvalidOperationException("The herbivore enclosure  is full!");
                    Console.WriteLine("The herbivore enclosure  is full!");
                    return;
                }

                for (int i = 0; i < _arrayHerbivoreAnimal.Length; i++)
                {
                    if (_arrayHerbivoreAnimal[i] == null)
                    {
                        _arrayHerbivoreAnimal[i] = (HerbivoreAnimal)anim;
                        Console.WriteLine($"{anim.GetType().Name} added to the herbivore enclosure.");
                        return;
                    }
                }
            }
            else
            {
                
                for (int i = 0; i < _arrayPredator.Length; i++)
                {
                    if (_arrayPredator[i] == null)
                    {
                        b = true;
                    }
                }

                if (b == false)
                {
                    //throw new InvalidOperationException("The predators enclosure is full!");
                    Console.WriteLine("The predators enclosure is full!");
                    return;
                }

                for (int i = 0; i < _arrayPredator.Length; i++)
                {
                    if (_arrayPredator[i] == null)
                    {
                        _arrayPredator[i] = (Predator)anim;
                        Console.WriteLine($"{anim.GetType().Name} added to the predator enclosure.");
                        return;
                    }
                }
            }
            return;
        }
    }
    public class Animal
    {
        protected bool _isAngry = false;
        public virtual void Life()
        {

        }
    }

    public class HerbivoreAnimal : Animal
    {
        public void EatGrass()
        {
            if (_isAngry)
            {
                Console.WriteLine("Eat grass");
            }
        }
        public override void Life()
        {
            
        }
    }

    public class Predator : Animal
    {
        public void Bite()
        {
            if (_isAngry)
            {
                Console.WriteLine("Starts hunting");
            }
        }
        public override void Life()
        {

        }
    }

    public class Rabbit : HerbivoreAnimal
    {
        public override void Life()
        {

        }
    }
    public class Deer : HerbivoreAnimal
    {
        public override void Life()
        {

        }
    }

    public class Wolf : Predator
    {
        public override void Life()
        {

        }
    }

    public class Bear : Predator
    {
        public override void Life()
        {

        }
    }
}