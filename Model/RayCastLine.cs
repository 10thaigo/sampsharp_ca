using SampSharp.GameMode;

namespace SampSharp.ColAndreas.Model
{
    public class RayCastLine
    {
        public Vector3 CollisionPoint { get; }

        public int Model { get; }

        public static RayCastLine NoCollisionPoint { get; } = new RayCastLine(Vector3.Zero);

        public RayCastLine(Vector3 collisionPoint)
        {
            CollisionPoint = collisionPoint;
        }

        public RayCastLine(Vector3 collisionPoint, int model) : this(collisionPoint)
        {
            Model = model;
        }
    }
}
