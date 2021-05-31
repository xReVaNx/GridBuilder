using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GridBuilder.Models;

namespace GridBuilder.lib
{
    public interface IGridBuilder<T>
    {
        public static void Name(string name) { }
        public static void Columns(T paramList) { }

    }
}
