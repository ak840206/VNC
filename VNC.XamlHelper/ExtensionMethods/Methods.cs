using System;
using System.Windows;
using System.Windows.Threading;

namespace ExtensionMethods
{
    public static class Methods
    {

        private static Action EmptyDelegate = delegate() {  };

        public static void Refresh(this UIElement uiElement)
        {
            uiElement.Dispatcher.Invoke(DispatcherPriority.Render, EmptyDelegate);
        }

        //public static void Refresh(this TextBox tb)
        //{
        //    tb.Dispatcher.Invoke(DispatcherPriority.Render, EmptyDelegate);
        //}
    }
}
