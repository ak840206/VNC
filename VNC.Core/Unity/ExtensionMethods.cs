using System;
using Unity;

namespace VNC.Core.Unity
{
    public static class ExtensionMethods
    {
        public static void RegisterTypeForNavigation<T>(this IUnityContainer container)
        {
            container.RegisterType(typeof(Object), typeof(T), typeof(T).FullName);
        }
    }
}