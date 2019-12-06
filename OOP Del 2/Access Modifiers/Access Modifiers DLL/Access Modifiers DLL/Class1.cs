using System;
using System.Collections.Generic;

namespace Access_Modifiers_DLL
{
    public class Reg
    {
        private protected List<Person> people { get; } = new List<Person>();
        private protected List<Bike> bikes = new List<Bike>();

        public void AddPerson(string name, int age)
        {
            people.Add(new Person(name, age));
        }
        public void RemovePerson(int PersonIndex)
        {
            people[PersonIndex].RemoveAllBikes();
            people.RemoveAt(PersonIndex);
        }
        public void AddBike(string bikeName, string bikeID)
        {
            bikes.Add(new Bike(bikeName, bikeID));
        }
        public void SetOwner(int bikeId, int personId)
        {
            bikes[bikeId].SetOwner(people[personId]);

        }
        public string GetPersonList()
        {
            string list = "Index:\tName:";
            int i = 0;
            while (i < people.Count)
            {
                list += "\n" + i + "\t" + people[i].name;
                i += 1;
            }
            return list;
        }
        public string GetBikeList()
        {
            string list = "Index:\tName:\tBike ID:\tOwner:\tOwner Index:";
            int i = 0;
            while (i < bikes.Count)
            {
                try
                {
                    list += "\n" + i + "\t" + bikes[i].name + "\t" + bikes[i].id + "\t\t" + bikes[i].owner.name + "\t\t" + people.IndexOf(bikes[i].owner);
                }
                catch
                {
                    list += "\n" + i + "\t" + bikes[i].name + "\t" + bikes[i].id + "\t\t" + "N/A" + "\t\t" + "N/A";
                }
                i += 1;
            }
            return list;
        }
        public string GetBikeListOwnedBy(int PersonIndex)
        {
            string list = "Bikes Owned By" + people[PersonIndex].name + "(" + PersonIndex + "):\nIndex:\tName:\tBike ID:";
            int i = 0;
            foreach (Bike bike in people[PersonIndex].bikes)
            {
                list += "\n" + i + "\t" + bike.name + "\t" + bike.id;
            }
            return list;
        }
    }
    internal class Person
    {
        internal string name;
        internal int age;
        internal List<Bike> bikes = new List<Bike>();

        internal Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        internal void AddBike(Bike bike)
        {
            this.bikes.Add(bike);
        }
        internal void RemoveBikeFromBike(Bike bike)
        {
            bikes.RemoveAt(bikes.IndexOf(bike));
        }
        internal void RemoveAllBikes()
        {
            foreach (Bike bike in bikes)
            {
                bike.RemoveOwnerFromPerson();
            }
        }
    }
    internal class Bike
    {
        internal string name;
        internal string id;
        internal Person owner;

        internal Bike(string name, string id)
        {
            this.name = name;
            this.id = id;
        }
        internal void SetOwner(Person owner)
        {
            try
            {
                this.owner.RemoveBikeFromBike(this);
            }
            catch { }
            this.owner = owner;
            owner.AddBike(this);
        }
        internal void RemoveOwnerFromPerson()
        {
            owner = null;
        }

    }
}
