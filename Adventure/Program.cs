// See https://aka.ms/new-console-template for more information
using System.Drawing;

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

        int[][] maze = {
            {0,1,0,0,1,1,1,1},
            {1,1,1,1,1,0,0,0},
            {1,0,0,1,0,1,1,1},
            {1,1,1,1,1,0,1,0},
            {0,1,1,0,1,1,1,1}
        }

        List<string> inventory = {};

        Console.WriteLine("You wake up in a dark cave with nothing on your person, an eerie dripping can be heard echoing from the darkness");
        string comm = "";


        while (!comm.Equals("exit", StringComparison.OrdinalIgnoreCase))
        {
            printCommandList();
            Console.WriteLine("What action would you like to take?");
            comm = Console.ReadLine();
            comms = comm.Split();

        }
    }

    public void printCommandList()
    {
        Console.WriteLine("Available commands:");
        Console.WriteLine("Move\n Pickup\n Interact\n Talk\n")
    }

    public void commandHandler(string comm)
    {

    }
}

