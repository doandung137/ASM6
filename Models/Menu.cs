using jsonCategory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsonCategory.Models
{
    class Menu
    {
        public string message { get; set; }
        public List<MenuItem> data { get; set; }
    }
}
