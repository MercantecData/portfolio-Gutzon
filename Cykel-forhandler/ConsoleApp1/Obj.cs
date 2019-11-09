using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Bike
    {
        public string manifactor { get; private set; };
        public readonly string color;
        public readonly double wheelSize;

        public string GetManifactor()
        {
            return manifactor;
        }
        public string GetColor()
        {
            return color;
        }
        public double GetWheelSize()
        {
            return wheelSize;
        }
        public Bike(string manifactor, string color, double wheelSize)
        {
            this.manifactor = manifactor;
            this.color = color;
            this.wheelSize = wheelSize;
        }
    }
    class Shop
    {
        public string name;
        public List<Bike> bikes = new List<Bike>();


        public List<int> SearchByManifactor(string name)
        {
            List<int> temp1 = new List<int>();
            int i = 0;
            while (i < bikes.Count)
            {
                if (bikes[i].GetManifactor() == name)
                {
                    temp1.Add(i);
                }
                i += 1;

            }
            return temp1;
        }
        public List<int> SearchByColor(string color)
        {
            List<int> temp1 = new List<int>();
            int i = 0;
            while (i < bikes.Count)
            {
                if (bikes[i].GetColor() == color)
                {
                    temp1.Add(i);
                }
                i += 1;

            }
            return temp1;
        }
        public List<Bike> SearchByWheelSizeSmaller(double wheelSize)
        {
            List<Bike> temp1 = new List<Bike>();
            int i = 0;
            while (i < bikes.Count)
            {
                if (bikes[i].GetWheelSize() < wheelSize)
                {
                    temp1.Add(bikes[i]);
                }
                i += 1;

            }
            return temp1;
        }
        public List<Bike> SearchByWheelSizeBigger(double wheelSize)
        {
            List<Bike> temp1 = new List<Bike>();
            int i = 0;
            while (i < bikes.Count)
            {
                if (bikes[i].GetWheelSize() > wheelSize)
                {
                    temp1.Add(bikes[i]);
                }
                i += 1;

            }
            return temp1;
        }
       public List<string> GetAllManifactorNames()
        {
            List<string> temp = new List<string>();
            int i = 0;
            while (i < bikes.Count)
            {
                string temp2 = bikes[i].GetManifactor();
                int i2 = 0;
                while (i2 < bikes.Count)
                {
                    if (bikes[i2].GetManifactor() != temp2)
                    {
                        temp.Add(temp2);
                        i2 = bikes.Count;
                    }
                    i2 += 1;
                }
                i += 1;
            }


            return temp;
        }

        public Shop(string name)
        {
            this.name = name;
            bikes.Add(new Bike("Scott", "Rød", 16));
            bikes.Add(new Bike("Principia", "Blå", 14));
            bikes.Add(new Bike("Nishiki", "Gul", 17));
            bikes.Add(new Bike("Trek", "Rød", 16));
            bikes.Add(new Bike("Giant", "Blå", 18));
            bikes.Add(new Bike("Specialized", "Gul", 16));
            bikes.Add(new Bike("Kildemoes", "Blå", 16));
        }
    }

    class Owner
    {
        public readonly string name = " Owner";
        List<Shop> shops = new List<Shop>();

        public int CountAmountBikesBasedOnColor(string color)
        {
            int count = 0;
            int i = 0;
            while (i < shops.Count)
            {
                count += shops[i].SearchByColor(color).Count;
               
                i += 1;
            }
            return count;
        }
        public Owner(Shop shop)
        {
            this.shops.Add(shop);
        }
    }
}
