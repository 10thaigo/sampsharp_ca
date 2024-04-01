using SampSharp.ColAndreas.Model;
using SampSharp.GameMode;

namespace SampSharp.ColAndreas
{
    public class RayCast
    {
        public static RayCastLine RayCastLine(Vector3 startPosition, Vector3 endPosition)
        {
            int result = ColAndreas.Internal.RayCastLine(startPosition.X, startPosition.Y, startPosition.Z, endPosition.X, endPosition.Y, endPosition.Z, out var x, out var y, out var z);
            
            if(result == 0)
                return Model.RayCastLine.NoCollisionPoint;

            return new RayCastLine(new Vector3(x, y, z), result);
        }   
    }
}
