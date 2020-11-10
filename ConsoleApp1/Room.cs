using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Room
    {
        //RoomId, Description, Exits,Destinations
        int roomID;
        string description;
        string exits;
        string destinations;

        public int RoomID { get => roomID; set => roomID = value; }
        public string Description { get => description; set => description = value; }
        public string Exits { get => exits; set => exits = value; }
        public string Destinations { get => destinations; set => destinations = value; }
    }
}
