using System.Linq;

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
#endif

        public static PropertyInfo[] GetAllPublicProperties(this Type type)
        {
#if NET20 || NET35
            return type.GetProperties(BindingFlags.Instance | BindingFlags.SetProperty | BindingFlags.Public);
#else
            return type.GetTypeInfo().DeclaredProperties.ToArray();
#endif
        }
    }
}