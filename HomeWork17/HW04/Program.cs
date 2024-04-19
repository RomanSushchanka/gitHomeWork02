using Newtonsoft.Json;
using System.Text.Json.Serialization;
using JsonIgnoreAttribute = Newtonsoft.Json.JsonIgnoreAttribute;

public class MyItem
{
    
    public int Age { get; set; }
    [JsonIgnore]
    public string Name { get; set; }
}

public class Program
{
    public static void Main()
    {
        MyItem item = new MyItem
        {
            Age = 25,
            Name = "John"
        };

        JsonSerializerSettings settings = new JsonSerializerSettings
        {
            ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver()
        };
        settings.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());

        string json = JsonConvert.SerializeObject(item, settings);
        Console.WriteLine(json);
    }
}