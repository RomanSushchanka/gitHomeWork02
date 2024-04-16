using System;

public class MobileNetwork
{
    public string Name { get; set; }
}

public class MobilePhone<T> where T : MobileNetwork
{
    public T Network { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        MobileNetwork network = new MobileNetwork { Name = "MyNetwork" };
        MobilePhone<MobileNetwork> phone1 = new MobilePhone<MobileNetwork> { Network = network };

        Console.WriteLine($"Phone1 Network: {phone1.Network.Name}");

        MobileNetwork childNetwork = new MobileNetwork { Name = "ChildNetwork" };
        MobilePhone<MobileNetwork> phone2 = new MobilePhone<MobileNetwork> { Network = childNetwork };

        Console.WriteLine($"Phone2 Network: {phone2.Network.Name}");
    }
}