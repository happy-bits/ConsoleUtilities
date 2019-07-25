using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUtilities
{
    public class MenuOptionPart
    {
        public Action Action { get; }
        public string Description { get; }

        public MenuOptionPart(string description, Action action)
        {
            Description = description;
            Action = action;
        }

    }
}
