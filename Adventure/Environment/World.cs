namespace Adventure.Environment;

public sealed class World
{
    public static List<Item> Inventory {get;} = [];
    public Room ?CurrentRoom {get; set;}
    public static readonly World instance = new();
    private World() {}

}