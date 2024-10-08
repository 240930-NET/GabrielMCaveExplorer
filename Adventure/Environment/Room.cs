namespace Adventure.Environment;
using System.Linq;

public class Room(string name, string desc, Dictionary<string, Interactable> its)
{
    public string Name { get; set; } = name;
    public string Description { get; set; } = desc;
    public Dictionary<string, Interactable> interactables = its ?? [];

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