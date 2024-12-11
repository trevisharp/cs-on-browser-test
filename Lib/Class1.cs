using System.Linq;
using System.Runtime.InteropServices.JavaScript;

namespace Lib;

public static partial class Test
{
    [JSExport]
    public static float Sum(float a, float b)
        => a + b;
    
    [JSExport]
    public static string[] Sort(params string[] array)
        => [ ..array.Select(float.Parse).OrderBy(x => x).Select(x => x.ToString()) ];
}
