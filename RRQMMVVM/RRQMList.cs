using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRQMMVVM
{
    /// <summary>
    /// 继承ObservableCollection的集合
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class RRQMList<T>: ObservableCollection<T>
    {
        /// <summary>
        /// 
        /// </summary>
        public RRQMList()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        public RRQMList(List<T> list)
        {
            foreach (var item in list)
            {
                Add(item);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="collection"></param>
        public RRQMList(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Add(item);
            }
        }
    }
}
