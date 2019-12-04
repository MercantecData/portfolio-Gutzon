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

        public virtual string GetComputerInfo()
        {
            return "Product Type: Computer.\nManufactor: "+manufacture+".\nCost: "+cost+". \nCPU: "+cpu+". \nProduct ID: "+productID+". \nModel ID: "+modelID+". \nOS Version: "+osVersion+". \nGPU: "+gpu+".";
        }

    }
    class AllInOnePC : Desktop
    {
        public Screen screen;

        public  override string GetComputerInfo()
        {
            return GetDesktopInfo().Replace("Product Type: Desktop.", "Product Type: All In One PC.") + "\nScreen Resolution: "+ screen.pixelCountX+" X "+screen.pixelCounty+". \nScreen Size: "+screen.screenSize+"\". \nTouch Points: "+screen.pointsTouchScreen+".";
        }
    }
    class Laptop : Computer
    {
        public Screen screen;
        public string GetLaptopInfo()
        {
            return GetComputerInfo().Replace("Product Type: Computer.", "Product Type: Laptop.") + "\nScreen Resolution: " + screen.pixelCountX + " X " + screen.pixelCounty + ". \nScreen Size: " + screen.screenSize + "\". \nTouch Points: " + screen.pointsTouchScreen + ".";
        }
    }
    class Desktop : Computer
    {
        public int caseHeight;
        public int caseWidth;
        public int caseDepth;

        public string GetDesktopInfo()
        {
           return GetComputerInfo().Replace("Product Type: Computer.", "Product Type: Desktop.")+"\nCase Height: "+caseHeight+".\nCase Width: "+caseWidth+". \nCase Depth: "+caseDepth+"."; 
        }
    }

    class MobilePhone : Computer
    {
        public Screen screen;
        public string simCard;
        public string GetMobilInfo()
        {
            return GetComputerInfo().Replace("Product Type: Computer.", "Product Type: Mobile Phone.") + "\nScreen Resolution: " + screen.pixelCountX + " X " + screen.pixelCounty + ". \nScreen Size: " + screen.screenSize + "\". \nTouch Points: " + screen.pointsTouchScreen + ". \nSim Card Type: "+simCard+".";
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
