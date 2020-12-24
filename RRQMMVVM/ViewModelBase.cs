using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace RRQMMVVM
{

    /// <summary>
    /// ViewModel基类
    /// </summary>
    public class ViewModelBase : ObservableObject
    {


        /// <summary>
        /// 判断是不是设计器模式
        /// </summary>
        public bool IsInDesignMode
        {
            get { return DesignerProperties.GetIsInDesignMode(new DependencyObject()); }
        }

        /// <summary>
        /// 目标View
        /// </summary>
        public FrameworkElement View { get; set; }
       
        /// <summary>
        /// UI线程调用
        /// </summary>
        /// <param name="action"></param>
        public void UIInvoke(Action action)
        {
            this.View.Dispatcher.Invoke(action);
        }
    }
}
