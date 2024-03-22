using SampSharp.ColAndreas.Definitions;
using SampSharp.GameMode;

namespace SampSharp.ColAndreas.RayCast
{
    public class RayCast
    {
        public RayCastLine RayCastLine(Vector3 startPosition, Vector3 endPosition)
        {
            int result = ColAndreas.Internal.RayCastLine(startPosition.X, startPosition.Y, startPosition.Z, endPosition.X, endPosition.Y, endPosition.Z, out var x, out var y, out var z);
            
            if(result == 0)
                return SampSharp.ColAndreas.RayCast.RayCastLine.NoCollisionPoint;
            
            if(result == Constants.WATER_OBJECT)
                return new RayCastLine(new Vector3(x, y, z));

            return new RayCastLine(new Vector3(x, y, z), result);
        }   
    }
}
