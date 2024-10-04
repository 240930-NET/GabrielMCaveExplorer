namespace Adventure.Environment;

public abstract class Interactable
{
    private string appearanceText {get; set;} 
    private string interactionText {get; set;} 
    public Interactable(string appearanceText, string interactionText)
    {
        this.appearanceText = appearanceText;
        this.interactionText = interactionText;
    }

    public void interact()
    {
        Console.WriteLine(interactionText);
        Action();
    }
    public abstract void Action();
}