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
    public delegate void DelegateCommand();
   
    /// <summary>
    /// 绑定命令
    /// </summary>
    public class ExecuteCommand: ICommand
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        public ExecuteCommand(DelegateCommand command)
        {
            this.delCommand = command;
        }

        
        private DelegateCommand delCommand;

        /// <summary>
        /// 
        /// </summary>
        public event EventHandler CanExecuteChanged;

        /// <summary>
        /// 执行测试
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
        /// 执行
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            if (CanExecute(parameter))
            {
                CanExecuteChanged?.Invoke(this, null);
                delCommand.Invoke();
            }
        }
    }
}
