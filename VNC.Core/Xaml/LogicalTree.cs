using System.Windows;

namespace VNC.Core.Xaml
{
    public static class LogicalTree
    {
        public static T FindAncestor<T>(DependencyObject dependencyObject)
            where T : class
        {
            DependencyObject target = dependencyObject;
            do
            {
                target = LogicalTreeHelper.GetParent(target);
            }
            while (target != null && !(target is T));
            return target as T;
        }
    }
}
