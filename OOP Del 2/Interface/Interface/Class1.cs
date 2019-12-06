using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    interface IComputer
    {
        string GetComputerInfo();
        void PrintComputerInfo();
        void PrintProductID();
    }
    abstract class Computer
    {
        public string manufacture;
        public double cost;
        public string cpu;
        public string productID;
        public string modelID;
        public string osVersion;
        public string gpu;


    }
    class AllInOnePC : Desktop, IComputer
    {
        public Screen screen;

        public string GetComputerInfo()
        {
            return "Product Type: All In One PC.\nManufactor: " + manufacture + ".\nCost: " + cost + ". \nCPU: " + cpu + ". \nProduct ID: " + productID + ". \nModel ID: " + modelID + ". \nOS Version: " + osVersion + ". \nGPU: " + gpu + ". \nCase Height: " + caseHeight + ".\nCase Width: " + caseWidth + ". \nCase Depth: " + caseDepth + ". \nScreen Resolution: " + screen.pixelCountX + " X " + screen.pixelCounty + ". \nScreen Size: " + screen.screenSize + "\". \nTouch Points: " + screen.pointsTouchScreen + ".";
        }
        public void PrintComputerInfo()
        {
            Console.WriteLine(GetComputerInfo());
        }
        public void PrintProductID()
        {
            Console.WriteLine(productID);
        }
    }
    class Laptop : Computer, IComputer
    {
        public Screen screen;
        public string GetComputerInfo()
        {
            return "Product Type: Laptop.\nManufactor: " + manufacture + ".\nCost: " + cost + ". \nCPU: " + cpu + ". \nProduct ID: " + productID + ". \nModel ID: " + modelID + ". \nOS Version: " + osVersion + ". \nGPU: " + gpu + ". \nScreen Resolution: " + screen.pixelCountX + " X " + screen.pixelCounty + ". \nScreen Size: " + screen.screenSize + "\". \nTouch Points: " + screen.pointsTouchScreen + ".";
        }
        public void PrintComputerInfo()
        {
            Console.WriteLine(GetComputerInfo());
        }
        public void PrintProductID()
        {
            Console.WriteLine(productID);
        }
    }
    class Desktop : Computer, IComputer
    {
        public int caseHeight;
        public int caseWidth;
        public int caseDepth;

        public string GetComputerInfo()
        {
            return "Product Type: Desktop.\nManufactor: " + manufacture + ".\nCost: " + cost + ". \nCPU: " + cpu + ". \nProduct ID: " + productID + ". \nModel ID: " + modelID + ". \nOS Version: " + osVersion + ". \nGPU: " + gpu + ". \nCase Height: " + caseHeight + ".\nCase Width: " + caseWidth + ". \nCase Depth: " + caseDepth + ".";
        }
        public void PrintComputerInfo()
        {
            Console.WriteLine(GetComputerInfo());
        }
        public void PrintProductID()
        {
            Console.WriteLine(productID);
        }
    }

    class MobilePhone : Computer, IComputer
    {
        public Screen screen;
        public string simCard;
        public string GetComputerInfo()
        {
            return "Product Type: Mobile Phone.\nManufactor: " + manufacture + ".\nCost: " + cost + ". \nCPU: " + cpu + ". \nProduct ID: " + productID + ". \nModel ID: " + modelID + ". \nOS Version: " + osVersion + ". \nGPU: " + gpu + ". \nScreen Resolution: " + screen.pixelCountX + " X " + screen.pixelCounty + ". \nScreen Size: " + screen.screenSize + "\". \nTouch Points: " + screen.pointsTouchScreen + ". \nSim Card Type: " + simCard + ".";
        }
        public void PrintComputerInfo()
        {
            Console.WriteLine(GetComputerInfo());
        }
        public void PrintProductID()
        {
            Console.WriteLine(productID);
        }
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
