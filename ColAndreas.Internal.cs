using SampSharp.Core.Natives.NativeObjects;
using SampSharp.GameMode;

namespace SampSharp.ColAndreas
{
    public class ColAndreas
    {
        public static ColAndreasInternal Internal { get; } = NativeObjectProxyFactory.CreateInstance<ColAndreasInternal>();

        public static void RemoveBuildingCollision(int modelid, Vector3 position, float radius = 0.50f) => Internal.RemoveBuildingCollision(modelid, position.X, position.Y, position.Z, radius);
    }

    public class ColAndreasInternal
    {
        [NativeMethod(Function = "CA_RayCastLine")]
        public virtual int RayCastLine(float StartX, float StartY, float StartZ, float EndX, float EndY, float EndZ, out float x, out float y, out float z) => throw new NativeNotImplementedException();
        
        [NativeMethod(Function = "CA_CreateObject")]
        public virtual int CreateCollision(int modelid, float x, float y, float z, float rx, float ry, float rz, bool add) => throw new NativeNotImplementedException();

        [NativeMethod(Function = "CA_SetObjectPos")]
        public virtual int SetCollisionPosition(int index, float x, float y, float z) => throw new NativeNotImplementedException();

        [NativeMethod(Function = "CA_SetObjectRot")]
        public virtual int SetCollisionRotation(int index, float rx, float ry, float rz) => throw new NativeNotImplementedException();

        [NativeMethod(Function = "CA_DestroyObject")]
        public virtual int DestroyCollision(int index) => throw new NativeNotImplementedException();

        [NativeMethod(Function = "CA_RemoveBuilding")]
        public virtual int RemoveBuildingCollision(int modelid, float x, float y, float z, float radius) => throw new NativeNotImplementedException();
    }
}