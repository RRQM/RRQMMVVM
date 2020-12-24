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
    /// 注册为消息
    /// </summary>
    public class RegistMethodAttribute : Attribute
    {
        /// <summary>
        /// 
        /// </summary>
        public RegistMethodAttribute()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="token"></param>
        public RegistMethodAttribute(string token)
        {
            this.Token = token;
        }
        /// <summary>
        /// 标识
        /// </summary>
        public string Token { get; set; }
    }
}
