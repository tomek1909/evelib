using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eZet.EveLib.Core
{
    public static class MyExtensions
    {
        public static ReadOnlyCollection<T> AsReadOnly<T>(this List<T> list) 
        {
            return new ReadOnlyCollection<T>(list);            
        }
    }
}
