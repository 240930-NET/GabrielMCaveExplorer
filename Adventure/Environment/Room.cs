namespace Adventure.Environment;
using System.Linq;
using System.Text.Json.Serialization;

public class Room
{
    public string Name { get; set; }
    public string Description { get; set; }
    [JsonInclude]
    public Dictionary<string, Interactable> interactables;

    [JsonConstructor]
    public Room(string name, string desc, Dictionary<string, Interactable> its)
    {
        this.Name = name;
        this.Description = desc;
        this.interactables = its ?? [];
    }
    public void WriteAppearance()
    {
        Console.WriteLine(Description);
        List<Interactable> listInts = interactables.Values.ToList();
        foreach (Interactable interactable in listInts)
            Console.WriteLine("\n" + interactable.AppearanceText);

        Console.WriteLine("\nYou can interact with the...");
        foreach (Interactable interactable in listInts)
            Console.Write("\t" + interactable.Name);

        Console.WriteLine();
        return;
    }
}