namespace StructExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Point3D point = new Point3D() { x = 1, y = 4, z = 12 };
            Point3D secondPoint = new Point3D() {  y = 4, x = 4, z = 5 };

            var distance = point.CalculateDistance(secondPoint);

            Console.WriteLine($"Distance is: {distance}");
        }
    }

    public struct Point3D
    {
        public double x;
        public double y;
        public double z;

        public double CalculateDistance(Point3D secondPoint) 
        {
            double distanceX = secondPoint.x - x;
            double distanceY = secondPoint.y - y;
            double distanceZ = secondPoint.z - z;
            double distance = Math.Sqrt(distanceX * distanceX + distanceY * distanceY + distanceZ * distanceZ);
            return distance;
        }
    }
}