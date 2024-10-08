// See https://aka.ms/new-console-template for more information
using System.Drawing;
using Adventure.UI;
using Adventure.Environment;

namespace Adventure;

class Adventure 
{
    static void Main(string[] args)
    {
        /*using Bitmap bmp = new(600, 400);
        using Graphics gfx = Graphics.FromImage(bmp);
        gfx.SmoothingMode = System.Drawing.Drawing2d.SmoothingMode.AntiAlias
        gfx.Clear(Color.Navy);

        Random rand = new(0);
        using Pen pen = new(Color.White);
        for (int i = 0; i < 10_000; i++)
        {
            pen.Color = Color.FromArgb(rand.Next());
            Point pt1 = new(rand.Next(bmp.Width), rand.Next(bmp.Height));
            Point pt2 = new(rand.Next(bmp.Width), rand.Next(bmp.Height));
            gfx.DrawLine(pen, pt1, pt2);
        }

        bmp.Save("demo.png");*/

        World world = World.instance;
        world.Map.Add("Start", new Room(
            "Start", 
            "You wake up in a dark cave with nothing on your person but a set of worn shirt and matching pants. The walls echo an eerie dripping, despite the room being dry and warm."
            + "Between the crevices of the cave is a blue clay like substance that rubs off to the touch, and you notice it's already marked your clothes."
            , []
        ));
        world.CurrentRoom = world.Map["Start"];

        Room tempRoom = new Room(
            "WatchRoom",
            "You continue down the cave, passing wooden chairs and tapastries depicting beings from what you assume to be some cultures epics or legends."
            + "Some seem horrorfics, some triumphant. As you continue further, the cave gives way to porceline tile floors and man made wooden struts extend along the whiles" +
            "This part of the cave was clearly... not natural...",
            []
        );
        world.CurrentRoom.interactables.Add(
            "Jail Door",
            new Exit(
                "Jail Door",
                "Further into the cave, you find a row of jail bars blocking the path, with and iron door embeded into the middle.",
                "The lock on the door is old and rusted, as well as much of the door itself, your easilly able to kick it aside",
                tempRoom
            )
        );
         
        //World.PrintCommandList();
        world.CurrentRoom.WriteAppearance();
        string ?comm = "";


        while (!comm.Equals("exit", StringComparison.OrdinalIgnoreCase))
        {
            Console.Write("\nEnter Command: ");
            comm = Console.ReadLine() ?? " ";
            string[] comms = comm.Split();
            world.NextCommand(comms);
            
        }
    }

    
}



