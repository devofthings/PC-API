using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API
{
    public class Computer
    {
        private int _id;
        private string _cpu;
        private string _graka;
        private int _ram;
        private string _motherboard;
        private string _power;
        private int _storage;

        public int ID { get => _id; set => _id = value; }
        public int Storage { get => _storage; set => _storage = value; }
        public string Power { get => _power; set => _power = value; }
        public string Motherboard { get => _motherboard; set => _motherboard = value; }
        public int Ram { get => _ram; set => _ram = value; }
        public string Graka { get => _graka; set => _graka = value; }
        public string Cpu { get => _cpu; set => _cpu = value; }

        public Computer()
        {
            ID = 0;
            Cpu = "";
            Graka = "";
            Ram = 0;
            Motherboard = "";
            Power = "";
            Storage = 0;
        }

        [Newtonsoft.Json.JsonConstructor]
        public Computer(int id, string c, string g, int r, string mb, string p, int s)
        {
            ID = id;
            Cpu = c;
            Graka = g;
            Ram = r;
            Motherboard = mb;
            Power = p;
            Storage = s;
        }

        public Computer returnConfig()
        {
            return this;
        }
    }
}