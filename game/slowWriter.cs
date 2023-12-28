using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace game
{
    public class slowWriter
    {
        private int speed;

        public slowWriter(int speed)
        {
            this.speed = speed;
        }

        public int getSpeed() { return speed; }
        public void setSpeed(int Newspeed) { this.speed = Newspeed; }

        public void slowWrite(string text)
        {
            bool writing = true;
            int count = 0;
            while (writing) 
            {
                Console.Write(text[count]);
                Thread.Sleep(speed * 3);
            }
        }

        public void slowWriteClear(string text)
        {
            Console.Clear();
            bool writing = true;
            int count = 0;
            while (writing)
            {
                Console.Write(text[count]);
                Thread.Sleep(speed * 3);
            }
            
        }

    }
}
