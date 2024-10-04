namespace Adventure.Environment;

public abstract class Interactable
{
    public string AppearanceText {get; set;} 
    public string InteractionText {get; set;} 
    public Interactable(string appearanceText, string interactionText)
    {
        this.AppearanceText = appearanceText;
        this.InteractionText = interactionText;
    }

    public void interact()
    {
        Console.WriteLine(InteractionText);
        Action();
    }
    public abstract void Action();
}