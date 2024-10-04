using Adventure.Environment;

public class Exit : Interactable
{
    private Room next {get; set;}
    public Exit(string appearanceText, string interactionTxt, Room next) : base(appearanceText, interactionTxt)
    {
        this.next = next;
    }

    public override void Action()
    {
        World.instance.CurrentRoom = next;
    }
}