
namespace Adventure.test;
using Xunit;
using Adventure.Environment;

public class UnitTest1
{
    [Fact]
    public void MoveCommandWorks()
    {
        Room testNextRoom = new Room("NextRoom","NextRoomDesc", []);
        World world = World.instance;
        Exit testExit = new Exit("testExit", "Going to next room", "You pass through the exit", testNextRoom);
        world.Map.Add("Test", new Room( 
            "Test", 
            "Test", 
            new Dictionary<string, Interactable>(){{testExit.Name, testExit}}
        ));
        world.CurrentRoom = world.Map["Test"];
        Console.WriteLine(world.Map);

        World.Move(testExit.Name);

        Assert.Equal(testNextRoom.Name, world.CurrentRoom.Name);
    }

    [Fact]
    public void UseCommandWorks()
    {

    }

    [Fact]
    public void InventoryCommandWorks()
    {
        
    }

    [Fact]
    public void TalkCommandWorks()
    {
        
    }

    [Fact]
    public void InteractCommandWorks()
    {
        
    }
}