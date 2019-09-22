namespace NetC.MapLocationFormComponent.Kentico.MVC
{
    public class MapLocation
    {
        public MapLocation(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public double Latitude { get; set; } = 0;
        public double Longitude { get; set; } = 0;
    }
}