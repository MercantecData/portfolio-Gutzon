﻿using System;
using System.Collections.Generic;

namespace Abstract_Classes_and_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Computer> pclist = new List<Computer>();
            AllInOnePC all = new AllInOnePC();
            all.cpu = "i7";
            all.caseHeight = 13;
            all.caseWidth = 25;
            all.caseDepth = 60;
            all.cost = 5999;
            all.gpu = "GTX 2080 TI";
            all.manufacture = "Corsair";
            all.modelID = "DFG474539";
            all.productID = "KKDHUELS8347JJD";
            all.osVersion = "Windows 10 Pro";
            all.screen = new Screen(15.6, 10, 1920, 1080);
            pclist.Add(all);
            Console.WriteLine(pclist[0].GetComputerInfo());
        }
    }
}