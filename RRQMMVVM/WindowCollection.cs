using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RRQMMVVM
{
    /// <summary>
    /// 窗口集合
    /// </summary>
    public class WindowCollection : List<Window>
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="window"></param>
        public new void Add(Window window)
        {
            window.Closed += Window_Closed;
            window.Activate();
            base.Add(window);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            base.Remove((Window)sender);
        }
    }
}
