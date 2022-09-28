namespace Test
{
    public class DemeritPointsCalculator
    {
        private const int speedLimit = 65;
        private const int speedMax = 400;

        /// <summary>
        /// speed is negative throw ArgumentOutofRangeException
        /// speed is less than 65 and positive return 0
        /// speed for each 5 km/h more than 65 add one point
        /// speed is more than 400 throw ArgumentOutofRangeException
        /// </summary>
        /// <param name="speed"></param>
        /// <returns></returns>
        public int CalculateDemeritPoints(int speed)
        {
            if (speed < 0 || speed > speedMax)
                throw new ArgumentOutOfRangeException();

            if (speed <= speedLimit) return 0;

            const int kmPerDemeritPoint = 5;
            var demeritPoints = (speed - speedLimit) / kmPerDemeritPoint;

            return demeritPoints;
        }
    }
}
