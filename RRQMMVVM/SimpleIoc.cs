using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RRQMMVVM
{
    /*
    若汝棋茗
    */
    /// <summary>
    /// ViewModelLocator基类
    /// </summary>
    public class SimpleIoc
    {
        private SimpleIoc()
        {

        }
        private static SimpleIoc instance;

        /// <summary>
        /// 默认单例实例
        /// </summary>
        public static SimpleIoc Default
        {
            get
            {
                if (instance == null)
                {
                    instance = new SimpleIoc();
                }

                return instance;
            }
        }

        private List<object> viewModelBases = new List<object>();
        private Dictionary<string, object> viewModelKey = new Dictionary<string, object>();

        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="element"></param>
        /// <param name="viewModel"></param>
        /// <param name="messageRegistType"></param>
        public void Register(FrameworkElement element, ViewModelBase viewModel)
        {
            element.DataContext = viewModel;
            viewModel.View = element;
            viewModelBases.Add(viewModel);
        }

        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="viewModel"></param>
        public void Register(ViewModelBase viewModel)
        {
            viewModelBases.Add(viewModel);
        }

        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="key"></param>
        /// <param name="viewModel"></param>
        public void Register(string key, ViewModelBase viewModel)
        {
            viewModelBases.Add(viewModel);
        }

        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="key"></param>
        /// <param name="element"></param>
        /// <param name="viewModel"></param>
        /// <param name="messageRegistType"></param>
        public void Register(string key, FrameworkElement element, ViewModelBase viewModel)
        {
            element.DataContext = viewModel;
            viewModel.View = element;
            viewModelKey.Add(key, viewModel);
        }

        /// <summary>
        /// 获取ViewModel
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T GetViewModelInstance<T>()
        {
            foreach (var item in viewModelBases)
            {
                if (item.GetType() == typeof(T))
                {
                    return (T)item;
                }
            }
            return default;
        }

        /// <summary>
        /// 获取ViewModel
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public T GetViewModelInstance<T>(string key)
        {
            try
            {
                return (T)viewModelKey[key];
            }
            catch (Exception)
            {
                return default;
            }

        }

    }
}
