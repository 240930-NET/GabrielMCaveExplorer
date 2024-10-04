namespace Adventure.UI;

public static class Terminal
{
    private static List<string> validCommands = ["Move", "Inventory", "Pickup", "Interact", "Talk", "Use", "Exit"];
    public static List<string> getValidCommands() => validCommands;
    public static void printCommandList()
    {
        Console.WriteLine("Available commands:");
        Console.WriteLine(
            "  Move {Door}\n   Inventory\n   Pickup\n   Interact\n   Talk\n   Use\n   Exit"
            );
    }

    public static void commandHandler(string comm)
    {

    }
    public static int[] move(string direction, int[] currentPos)
    {
        int[] newPos = currentPos;
        if (direction.Equals("North", StringComparison.OrdinalIgnoreCase))
            newPos[1]++;
        if (direction.Equals("South", StringComparison.OrdinalIgnoreCase))
            newPos[1]--;
        if (direction.Equals("West", StringComparison.OrdinalIgnoreCase))
            newPos[0]--;
        if (direction.Equals("East", StringComparison.OrdinalIgnoreCase))
            newPos[1]++;
        

        return currentPos;
    } 
}