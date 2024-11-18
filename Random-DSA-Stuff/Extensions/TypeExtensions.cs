namespace Random_DSA_Stuff.Extensions
{
    internal static class TypeExtensions
    {
        internal static string GetFormattedName(this Type type)
        {
            if (!type.IsGenericType)
            {
                return type.Name;
            }

            string genericName = type.Name[..type.Name.IndexOf('`')];
            string genericArguments = string.Join(", ", type.GetGenericArguments().Select(GetFormattedName));

            return $"{genericName}<{genericArguments}>";
        }
    }
}
