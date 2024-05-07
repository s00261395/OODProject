using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_Project
{
    public class Bar
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }

        public string Description { get; set; }
        public Bar(string name, string imagePath, string description)
        {
            Name = name;
            ImagePath = imagePath;
            Description = description;
        }
    }
}
