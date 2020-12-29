using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RRQMMVVM
{
    /// <summary>
    /// 显示窗口设置
    /// </summary>
    public class WindowSetting
    {
        /// <summary>
        /// Window类型
        /// </summary>
        public Type WindowType { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public WindowState WindowState { get; set; }

        /// <summary>
        /// 显示类型
        /// </summary>
        public ShowMode ShowMode { get; set; }

        /// <summary>
        /// 构造函数参数
        /// </summary>
        public object[] Parameters { get; set; }


    }
}
