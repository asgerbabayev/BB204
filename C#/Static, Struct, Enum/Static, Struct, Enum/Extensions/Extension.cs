using Static__Struct__Enum.Models;
using System.Text;

namespace Static__Struct__Enum.Extensions;

static class Extension
{
    public static string CustomReverse(this string word)
    {
        StringBuilder result = new StringBuilder();
        for (int i = word.Length - 1; i <= 0; i--)
        {
            result.Append(word[i]);
        }
        return result.ToString();
    }

    public static void CustomReverse(this Person word)
    {

    }
}
