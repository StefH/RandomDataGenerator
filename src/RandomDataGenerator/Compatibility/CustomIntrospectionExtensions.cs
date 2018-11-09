using System.Linq;

// ReSharper disable once CheckNamespace
namespace System.Reflection
{
    /// <summary>
    /// https://github.com/castleproject/Core/blob/netcore/src/Castle.Core/Compatibility/IntrospectionExtensions.cs
    /// </summary>
	internal static class CustomIntrospectionExtensions
    {
#if NET20 || NET35
        public static Type GetTypeInfo(this Type type)
        {
            return type;
        }

        public static Type[] GetGenericTypeArguments(this Type type)
        {
            return type.GetGenericArguments();
        }
#else
        public static Type[] GetGenericTypeArguments(this TypeInfo typeInfo)
        {
            return typeInfo.GenericTypeArguments;
        }
#endif

        public static PropertyInfo[] GetPublicSettableProperties(this Type type)
        {
#if NET20 || NET35
            return type.GetProperties(BindingFlags.Instance | BindingFlags.SetProperty | BindingFlags.Public);
#else
            return type.GetTypeInfo().DeclaredProperties.Where(pi => pi.CanWrite).ToArray();
#endif
        }
    }
}