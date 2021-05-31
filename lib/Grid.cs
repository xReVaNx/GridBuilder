using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GridBuilder.Models;

namespace GridBuilder.lib
{
    public class GridBuilder<T> where T : class
    {
        public GridBuilder<T> Name(string name)
        {
            return this;
        }
        public GridBuilder<T> Columns(Action<Columns<T>> columns)
        {
            return this;
        }
        public GridBuilder<T> Pageable()
        {
            return this;
        }
        public GridBuilder<T> Filterable()
        {
            return this;
        }
    }
    public class Columns<T>
    {
        public Columns<T> Bound(Func<T, string> param)
        {
            return this;
        }
        public Columns<T> Bound(Func<T, int> param)
        {
            return this;
        }
        public Columns<T> Height(string px)
        {
            return this;
        }
    }
}
