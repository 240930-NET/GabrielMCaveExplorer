using Adventure.Environment;

public class Item : Interactable{
    string description;
    string name;
    public Item(string appearanceText, string interactionTxt, string name, string desc) : base(appearanceText, interactionTxt)
    {
        this.name = name;
        description = desc;
    }

    public override void Action()
    {
        //World.instance.GetInventory().Add(this);
    }
}