//using System;
//using System.CodeDom;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows;
//using System.Windows.Controls;

//namespace RRQMMVVM
//{
//    /*
//    若汝棋茗
//    */

//    public class UISkip: DependencyObject
//    {


//        public FrameworkElement MyProperty
//        {
//            get { return (FrameworkElement)GetValue(MyPropertyProperty); }
//            set { SetValue(MyPropertyProperty, value); }
//        }

//        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
//        public static readonly DependencyProperty MyPropertyProperty =
//            DependencyProperty.Register("MyProperty", typeof(FrameworkElement), typeof(UISkip), new PropertyMetadata(null));


//        public FrameworkElement Container { get; set; }

//        public void Show(FrameworkElement element)
//        {
//            if (element is Grid)
//            {
//                Grid grid = (Grid)element;

//                grid.Children.Add(element);
//            }
//        }

//    }
//}
