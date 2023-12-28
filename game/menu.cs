using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace game
{
    public class menu
    {
        private string title = "";
        private List<string> items = new List<string>();
        private string question //and read line for player input

        public menu() { }

        public void addTitle(string newTitle)
        { this.title = newTitle; }

        public void addItem(String item)
        {
            items.Add(item);
        }

        public void clearMenu()
        {
            title = ""; items = new List<string>();
        }

        //add function for player nput that returns the input
    }
}
