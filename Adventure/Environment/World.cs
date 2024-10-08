namespace Adventure.Environment;

public sealed class World
{
    public static List<Item> Inventory {get;} = [];
    public Dictionary<string, Room> Map {get;} = [];
    public static readonly World instance = new();
    public Room ?CurrentRoom {
        get ;
        set ;
    }
    private World() {}

    public static void Move(string path)
    {
        if (instance.CurrentRoom != null)
        {
            if (instance.CurrentRoom.interactables.ContainsKey(path))
                instance.CurrentRoom.interactables[path].Action(); 
            else
                Console.WriteLine("Please enter a valid path");
        }
        else
            Console.WriteLine("You are not in a room to move");

        return;
        
    }

    private static List<string> validCommands = ["Help", "Move", "Inventory", "Pickup", "Interact", "Talk", "Use", "Exit"];
    public static List<string> getValidCommands() => validCommands;
    public static void PrintCommandList()
    {
        Console.WriteLine("Available commands:");
        Console.WriteLine(
            "   Help\n   Move {Door}\n   Inventory\n   Pickup\n   Interact\n   Talk\n   Use\n   Exit"
            );
    }
    public void NextCommand(string[] comms)
    {
        if (comms.GetLength(0) > 1)
        {
            if (comms[0].Equals("Move", StringComparison.OrdinalIgnoreCase))
            {
                if (comms.GetLength(0) > 2)
                {
                    World.Move(comms[1]);
                }
                else
                Console.WriteLine("Please enter a direction with your move command\n"); 
            }
            else if (comms[0].Equals("Help", StringComparison.OrdinalIgnoreCase))
            {

            }
        }
    }
}