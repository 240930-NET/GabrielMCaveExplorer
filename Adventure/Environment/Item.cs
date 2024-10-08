using Adventure.Environment;

public class Item : Interactable{
    string description;
    public Item(string name, string appearanceText, string interactionTxt, string desc) : base(name, appearanceText, interactionTxt)
    {
        description = desc;
    }

    public override void Action()
    {
        //World.instance.GetInventory().Add(this);
    }
}