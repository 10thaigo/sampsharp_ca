using SampSharp.Core.Natives.NativeObjects;

namespace SampSharp.ColAndreas
{
    public class ColAndreas
    {
        public static ColAndreasInternal Internal { get; } = NativeObjectProxyFactory.CreateInstance<ColAndreasInternal>();
    }

    public class ColAndreasInternal
    {
        [NativeMethod(Function = "CA_RayCastLine")]
        public virtual int RayCastLine(float StartX, float StartY, float StartZ, float EndX, float EndY, float EndZ, out float x, out float y, out float z)
        {
            throw new NativeNotImplementedException();
        }
    }
}