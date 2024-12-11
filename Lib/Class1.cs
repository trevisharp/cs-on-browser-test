using System.Linq;
using System.Runtime.InteropServices.JavaScript;

namespace Lib;

public static partial class Test
{
    [JSExport]
    public static float Sum(float a, float b)
        => a + b;
    
    // [JSExport]
    // public static float[] Sort(float[] array)
    //     => [ ..array.OrderBy(x => x) ];
}
