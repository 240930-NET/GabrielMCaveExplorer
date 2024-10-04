namespace Adventure.Environment;

public class Room(string name, string desc, List<Interactable> its)
{
    private string Name { get; set; } = name;
    private string Description { get; set; } = desc;
    public List<Interactable> interactables = its ?? [];

    public void WriteAppearance()
    {
        Console.WriteLine(Description);
        foreach (Interactable interactable in interactables)
            Console.WriteLine(interactable.AppearanceText);
    }
}