// The idea is to reuse https://github.com/dotnet/corefx/blob/master/src/System.Numerics.Vectors/src/System/Numerics/Vector.cs
// with all dependencies but only for mobile as .net FX does not support this type

namespace System.Numerics
{
    public struct Vector<T> where T : struct
    {

    }
}