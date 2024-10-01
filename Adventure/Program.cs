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

        int[,] maze = {
            {0,1,0,0,1,1,1,1},
            {1,1,1,1,1,0,0,0},
            {1,0,0,1,0,1,1,1},
            {1,1,1,1,1,0,1,0},
            {0,1,1,0,1,1,1,1}
        };

        Room[,] Cave = new Room[8,8];

        List<Room> Rooms = [];

        List<Item> inventory = [];
        int[] pos = {0, 8};

        Console.WriteLine("You wake up in a dark cave with nothing on your person, an eerie dripping can be heard echoing from the darkness");
        string comm = "";


        while (!comm.Equals("exit", StringComparison.OrdinalIgnoreCase))
        {
            printCommandList();
            Console.WriteLine("What action would you like to take?");
            comm = Console.ReadLine();
            string[] comms = comm.Split();

            if (comms[0].Equals("Move", StringComparison.OrdinalIgnoreCase))
            {
                pos = move(comms[1], pos);
            }
        }
    }

    public static void printCommandList()
    {
        Console.WriteLine("Available commands:");
        Console.WriteLine(
            "  Move {Cordinal direction}\n   Inventory\n   Pickup\n   Interact\n   Talk\n   Exit"
            );
    }

    public static void commandHandler(string comm)
    {

    }
    public static int[] move(string direction, int[] currentPos)
    {
        return [0, 0];
    } 
}



