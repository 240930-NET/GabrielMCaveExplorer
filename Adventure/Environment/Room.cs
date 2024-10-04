namespace Adventure.Environment;

public class Room(int x, int y, string desc, List<Interactable> its)
{
    private int[] Cords { get; set; } = [x, y];
    private string description { get; set; } = desc;
    public List<Interactable> interactables = its;
}