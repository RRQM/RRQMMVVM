using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRQMMVVM
{
    /*
    若汝棋茗
    */
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
   public class MessageRegisteredException:Exception
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mes"></param>
        public MessageRegisteredException(string mes):base(mes)
        { 
        
        }
    }
}
