using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialize
{
    public class B
    {
        public List<A> _base { get; set; }
        public B()
        {
            _base = new List<A>();
        }
        public void Add(A a)
        {
            _base.Add(a);
        }
        public void Show()
        {
            foreach(var x in _base)
            {
                x.Show();
            }
        }
    }
}
