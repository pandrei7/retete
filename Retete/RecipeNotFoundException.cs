using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retete
{
    class RecipeNotFoundException : Exception
    {
        public RecipeNotFoundException() { }

        public RecipeNotFoundException(string message) : base(message) { }

        public RecipeNotFoundException(string message, Exception inner) : base(message, inner) { }
    }
}
