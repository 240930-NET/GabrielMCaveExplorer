public class Room
{
    int [] cords;
    string description;
    List<item> items;
    public Room(int x, int y, string desc, List<item> its)
    {
        int [] cords = {x, y};
        description = desc;
        items = its; 
    }
}