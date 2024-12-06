using System.Linq;

namespace Lib;

public static class Test
{
    public static float Sum(float a, float b)
        => a + b;
    
    public static float[] Sort(float[] array)
        => [ ..array.OrderBy(x => x) ];
}
