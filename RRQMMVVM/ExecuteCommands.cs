using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RRQMMVVM
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="parameter"></param>
    public delegate void DelegateCommand<T>(T parameter);

    /// <summary>
    /// 绑定有参数命令
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ExecuteCommand<T> : ICommand
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        public ExecuteCommand (DelegateCommand<T> command)
        {
            delCommand = command;
        }

        DelegateCommand<T> delCommand;

        /// <summary>
        /// 
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
           
            if (delCommand == null)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            T t = (T)parameter;
            if (CanExecute(parameter))
            {
                CanExecuteChanged?.Invoke(this, null);
                delCommand.Invoke(t);
            }
        }
    }
}
