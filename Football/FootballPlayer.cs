using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football
{
    public class FootballPlayer : Person
    {
        private string number;
        private int height;
        public FootballPlayer(string name, int age,string number,int height) 
            : base(name, age)
        {
            this.number = number;
            this.height = height;
        }
        public int GetHeight
        {
            get { return height; }
        }
        public string GetNumber
        {
            get { return number; }
        }
    }
}
