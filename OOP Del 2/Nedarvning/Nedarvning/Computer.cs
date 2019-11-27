using System;
using System.Collections.Generic;
using System.Text;

namespace Nedarvning
{
    class Computer
    {
        public string manufacture;
        public double cost;
        public string cpu;
        public string productID;
        public string modelID;
        public string osVersion;
        public string gpu;

        public (string, double, string, string, string, string, string) GetComputerInfo()
        {
            return (manufacture, cost, cpu, productID, modelID, osVersion, gpu);
        }

    }
    class AllInOnePC : Desktop
    {
        public Screen screen;

        public (string, double, string, string, string, string, string, int[], Screen) GetAllInOneInfo()
        {
            return (GetDesktopInfo().Item1, GetDesktopInfo().Item2, GetDesktopInfo().Item3, GetDesktopInfo().Item4, GetDesktopInfo().Item5, GetDesktopInfo().Item6, GetDesktopInfo().Item7, GetDesktopInfo().Item8, screen);
        }
    }
    class Laptop : Computer
    {
        public Screen screen;

    }
    class Desktop : Computer
    {
        public int[] caseSize;

        public (string, double, string, string, string, string, string, int[]) GetDesktopInfo()
        {
            return (GetComputerInfo().Item1, GetComputerInfo().Item2, GetComputerInfo().Item3, GetComputerInfo().Item4, GetComputerInfo().Item5, GetComputerInfo().Item6, GetComputerInfo().Item7, caseSize); 
        }
    }

    class MobilePhone : Computer
    {
        public Screen screen;
        public string simCard;

    }


    class Screen
    {
        public double screenSize;
        public int pointsTouchScreen;
        public int pixelCountX;
        public int pixelCounty;

        public Screen(double screenSize, int pointsTouchScreen, int pixelCountX, int pixelCounty)
        {
            this.screenSize = screenSize;
            this.pointsTouchScreen = pointsTouchScreen;
            this.pixelCountX = pixelCountX;
            this.pixelCounty = pixelCounty;
        }
    }
}
