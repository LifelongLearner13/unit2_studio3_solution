using System;
using System.Collections.Generic;

namespace unit2_studio3_solution
{
    public class Menu
    {
        public DateTime LastUpdated { get; }
        public List<MenuItem> Items { get; set; }

        public Menu(DateTime date, List<MenuItem> items)
        {
            LastUpdated = date;
            Items = items;
        }

        public Menu(List<MenuItem> items): this(new DateTime(), items) { }
    }
}
