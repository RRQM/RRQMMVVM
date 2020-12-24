using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace RRQMMVVM
{

    /// <summary>
    /// 基类
    /// </summary>
    public class ObservableObject : INotifyPropertyChanged
    {

        /// <summary>
        /// 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 属性改变时
        /// </summary>
        /// <param name="propertyName"></param>
        public void OnPropertyChanged([CallerMemberName] string propertyName = "none passed")
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

       
    }
}
