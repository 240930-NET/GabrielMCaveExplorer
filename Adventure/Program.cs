using System.Drawing;
using Adventure.UI;
using Adventure.Environment;
﻿using System.Text.Json;
using System.IO;

namespace Adventure;

class Adventure 
{
    static void Main(string[] args)
    {

        World world = World.instance;
        //if (File.Exists("AdventureSave.json"))
            //World.LoadData();
        //else
        //{
            World.InitializeWorld(world);
            World.SaveData();
        //}
        

        World.PrintCommandList();
        world.CurrentRoom?.WriteAppearance();
        string ?comm = "";


        while (!comm.Equals("exit", StringComparison.OrdinalIgnoreCase))
        {
            Console.Write("\nEnter Command: ");
            comm = Console.ReadLine() ?? " ";
            Console.WriteLine();
            List<string> comms = comm.Split().ToList();
            world.NextCommand(comms);
            World.SaveData();
        }
    }

    
}



