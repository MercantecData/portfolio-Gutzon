using System;

namespace Nedarvning
{
    class Program
    {
        static void Main(string[] args)
        {
            AllInOnePC all = new AllInOnePC();
            all.cpu = "i7";
            all.caseSize = new int[] {13, 25, 60};
            all.cost = 5999;
            all.gpu = "GTX 2080 TI";
            all.manufacture = "Corsair";
            all.modelID = "DFG474539";
            all.productID = "KKDHUELS8347JJD";
            all.osVersion = "Windows 10 Pro";
            all.screen = new Screen(15.6, 10, 1920, 1080);
            Console.WriteLine(all.GetAllInOneInfo());
        }
    }
}
