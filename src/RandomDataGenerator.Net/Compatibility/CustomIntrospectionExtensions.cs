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
    }
}