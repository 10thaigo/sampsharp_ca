using SampSharp.GameMode;
using SampSharp.GameMode.Definitions;
using SampSharp.GameMode.Pools;
using SampSharp.GameMode.SAMP;
using SampSharp.GameMode.World;
using SampSharp.Streamer.World;

namespace SampSharp.ColAndreas.World
{
    public class ColDynamicObject : IdentifiedPool<ColDynamicObject>
    {
        private DynamicObject _dynamicObject;
        private Vector3 _position;
        private Vector3 _rotation;

        public Vector3 Position
        {
            get => _position;
            set
            {
                ColAndreas.Internal.SetCollisionPosition(Id, value.X, value.Y, value.Z);
                _dynamicObject.Position = value;
                _position = value;
            }
        }

        public Vector3 Rotation
        {
            get => _rotation;
            set
            {
                ColAndreas.Internal.SetCollisionRotation(Id, value.X, value.Y, value.Z);
                _dynamicObject.Rotation = value;
                _rotation = value;
            }
        }

        public ColDynamicObject(int modelid, Vector3 position, Vector3 rotation = default, int vw = -1, int interior = -1, BasePlayer? player = null, float streamdistance = 200.0f, float drawdistance = 200.0f, DynamicArea? area = null, int priority = 0)
        {
            Id = ColAndreas.Internal.CreateCollision(modelid, position.X, position.Y, position.Z, rotation.X, rotation.Y, rotation.Z, true);
            _position = position;
            _rotation = rotation;
            _dynamicObject = new DynamicObject(modelid, position, rotation, vw, interior, player, streamdistance, drawdistance, area, priority);
        }

        public void SetMaterial(int materialindex, int modelid, string txdname, string texturename, Color materialcolor = new Color()) => _dynamicObject.SetMaterial(materialindex, modelid, txdname, texturename, materialcolor);
        
        public void SetMaterialText(int materialindex, string text, ObjectMaterialSize materialsize = ObjectMaterialSize.X256X128, string fontface = "Arial", int fontsize = 24, bool bold = true, Color foreColor = new Color(), Color backColor = new Color(), ObjectMaterialTextAlign textalignment = ObjectMaterialTextAlign.Center) => _dynamicObject.SetMaterialText(materialindex, text, materialsize, fontface, fontsize, bold, foreColor, backColor, textalignment);

        protected override void Dispose(bool disposing = false)
        {
            if (IsDisposed) return;

            ColAndreas.Internal.DestroyCollision(Id);
            _dynamicObject.Dispose();

            base.Dispose(disposing);
        }
    }
}