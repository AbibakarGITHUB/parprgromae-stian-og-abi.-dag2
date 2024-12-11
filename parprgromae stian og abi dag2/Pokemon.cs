using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParprogAbibakar
{
    internal class Pokemon
    {
        public string Name { get; set; } = "";

        public int MaxHp
        {
            get { return _maxHp; }
            set { _maxHp = value; }
        }

        public int CurrentHp
        {
            get { return _currentHp; }
            set { _currentHp = value; }
        }

        private int _maxHp = 0;
        private int _currentHp = 0;

        public Pokemon(string name, int maxHp, int currentHp)
        {
            Name = name;
            MaxHp = maxHp;
            CurrentHp = currentHp;
        }
    }
}

