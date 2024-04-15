﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;



namespace Propriétés
{
    public class Program
    {
        public static void Main(string[] args)
        {
            House house = new House();
            Room room = new Room();
            Door houseDoor = new Door();
            Door roomDoor = new Door();
            house._doors.Add(houseDoor);
            room._doors.Add(roomDoor);
            house._rooms.Add(room);
        }
    }

    public class House
    {
      

        public House()
        {
        

        }
        public List<Room> _rooms {
            get => new List<Room>();
           


        }
        public List<Door> _doors
        {
            get => new List<Door>();
           

        }
      
        
       
       
       
    }

    public class Room
    {
        
        public List<Door> _doors
        {
            get => new List<Door>();


        }
        public Room()
        {
           
        }

       
    }

    public class Door
    {
        public bool _isOpen;

        public Door()
        {
            _isOpen = false;
        }

        public void Open()
        {
            if (_isOpen)
            {
                Console.WriteLine("Door already opened. Ain't done anything.");
            }
            else
            {
                _isOpen = true;
            }
        }

        public void Close()
        {
            if (!_isOpen)
            {
                Console.WriteLine("Door already closed. Ain't done anything.");
            }
            else
            {
                _isOpen = false;
            }
        }
    }
}