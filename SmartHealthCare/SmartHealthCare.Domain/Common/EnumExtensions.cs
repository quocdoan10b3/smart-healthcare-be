using System.Runtime.Serialization;

namespace SmartHealthCare.Domain.Common;

public static class EnumExtensions
{
    public static string GetEnumMemberValue<T>(this T enumValue) where T : Enum
    {
        var type = typeof(T);
        var memberInfo = type.GetMember(enumValue.ToString());
        var attributes = memberInfo[0].GetCustomAttributes(typeof(EnumMemberAttribute), false);

        return (attributes.Length > 0) ? ((EnumMemberAttribute)attributes[0]).Value : enumValue.ToString();
    }
}