using System.Linq;
using Microsoft.JSInterop;

namespace Lib;

// doc: https://yangzhongke8.medium.com/without-blazor-webassembly-develop-a-web-site-that-compiles-and-runs-c-code-on-browser-c381873f6d03
public static partial class Test
{
    [JSInvokable]
    public static float Sum(float a, float b)
        => a + b;
    
    [JSInvokable]
    public static float[] Sort(params float[] array)
        => [ ..array.OrderBy(x => x) ];
}