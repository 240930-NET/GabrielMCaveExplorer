public class Room
{
    public int [] cords;
    public string description;
    public List<Item> items;
    public Room(int x, int y, string desc, List<Item> its)
    {
        int [] cords = {x, y};
        description = desc;
        items = its; 
    }
}