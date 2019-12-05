using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Classes_and_Interfaces
{
    abstract class Computer
    {
        public string manufacture;
        public double cost;
        public string cpu;
        public string productID;
        public string modelID;
        public string osVersion;
        public string gpu;

        public abstract string GetComputerInfo();

    }
    class AllInOnePC : Desktop
    {
        public Screen screen;

        public override string GetComputerInfo()
        {
            return "Product Type: All In One PC.\nManufactor: " + manufacture + ".\nCost: " + cost + ". \nCPU: " + cpu + ". \nProduct ID: " + productID + ". \nModel ID: " + modelID + ". \nOS Version: " + osVersion + ". \nGPU: " + gpu + ". \nCase Height: " + caseHeight + ".\nCase Width: " + caseWidth + ". \nCase Depth: " + caseDepth + ". \nScreen Resolution: " + screen.pixelCountX + " X " + screen.pixelCounty + ". \nScreen Size: " + screen.screenSize + "\". \nTouch Points: " + screen.pointsTouchScreen + ".";
        }
    }
    class Laptop : Computer
    {
        public Screen screen;
        public override string GetComputerInfo()
        {
            return "Product Type: Laptop.\nManufactor: " + manufacture + ".\nCost: " + cost + ". \nCPU: " + cpu + ". \nProduct ID: " + productID + ". \nModel ID: " + modelID + ". \nOS Version: " + osVersion + ". \nGPU: " + gpu + ". \nScreen Resolution: " + screen.pixelCountX + " X " + screen.pixelCounty + ". \nScreen Size: " + screen.screenSize + "\". \nTouch Points: " + screen.pointsTouchScreen + ".";
        }
    }
    class Desktop : Computer
    {
        public int caseHeight;
        public int caseWidth;
        public int caseDepth;

        public override string GetComputerInfo()
        {
            return "Product Type: Desktop.\nManufactor: " + manufacture + ".\nCost: " + cost + ". \nCPU: " + cpu + ". \nProduct ID: " + productID + ". \nModel ID: " + modelID + ". \nOS Version: " + osVersion + ". \nGPU: " + gpu + ". \nCase Height: " + caseHeight + ".\nCase Width: " + caseWidth + ". \nCase Depth: " + caseDepth + ".";
        }
    }

    class MobilePhone : Computer
    {
        public Screen screen;
        public string simCard;
        public override string GetComputerInfo()
        {
            return "Product Type: Mobile Phone.\nManufactor: " + manufacture + ".\nCost: " + cost + ". \nCPU: " + cpu + ". \nProduct ID: " + productID + ". \nModel ID: " + modelID + ". \nOS Version: " + osVersion + ". \nGPU: " + gpu + ". \nScreen Resolution: " + screen.pixelCountX + " X " + screen.pixelCounty + ". \nScreen Size: " + screen.screenSize + "\". \nTouch Points: " + screen.pointsTouchScreen + ". \nSim Card Type: " + simCard + ".";
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
