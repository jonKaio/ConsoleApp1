using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    class Game
    {
        public static void Play()
        {
            int pGold = 0;
            Room[] locations;
            using (var reader = new StreamReader("rooms.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                locations = csv.GetRecords<Room>().ToArray<Room>();
                //var test = csv.GetRecords<Room>();
                //foreach (var sRoom in test)
                //{
                //    Console.WriteLine(sRoom.Description);
                //}
            }

            int currentLocation = 1;
            bool isPlaying = true;

            //pGold is going to be my Players Gold Wallet
            //So I need to load & save to it

            string tmpGoldString = File.ReadAllText("PlayerGold.txt");
            int.TryParse(tmpGoldString, out pGold);
            Console.WriteLine($"PLayer has {pGold}");
            pGold -= 50;
            File.WriteAllText("PlayerGold.txt", pGold.ToString());
            Room tmpLocation;

            while (isPlaying)
            {
                tmpLocation = locations.FirstOrDefault<Room>(x => x.RoomID == currentLocation);
                Console.WriteLine(tmpLocation.Description);
                string cmd = Console.ReadLine().ToLower();
                string[] destinations = tmpLocation.Destinations.Split(',');
                int idx = tmpLocation.Exits.IndexOf(cmd) ;
                currentLocation = int.Parse(destinations[idx]);
            }
        }

        internal static void Test()
        {
            int age;
            Console.WriteLine("Hello what is your name ?");
            string nm = Console.ReadLine();
            Console.WriteLine("How old are you ?");
            string ageStr= Console.ReadLine();
            if(File.Exists(nm+".txt"))
            { //read the file

            }
            else
            {
                //create the file
            }
            File.WriteAllText(nm + ".txt",ageStr);



        }
    }
}
