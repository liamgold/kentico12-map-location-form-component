using Kentico.Forms.Web.Mvc;
using NetC.MapLocationFormComponent.Kentico.MVC;
using System.Device.Location;

[assembly: RegisterFormComponent(MapLocationSelectorComponent.IDENTIFIER, typeof(MapLocationSelectorComponent), "Map location selector", IsAvailableInFormBuilderEditor = false, ViewName = "FormComponents/_MapLocationSelector")]
namespace NetC.MapLocationFormComponent.Kentico.MVC
{
    /// <summary>
    /// Represents a Map Location selector
    /// </summary>
    public class MapLocationSelectorComponent : FormComponent<MapLocationSelectorProperties, GeoCoordinate>
    {
        public const string IDENTIFIER = "MapLocationSelector";

        [BindableProperty]
        public double Latitude { get; set; }

        [BindableProperty]
        public double Longitude { get; set; }

        public override GeoCoordinate GetValue()
        {
            return new GeoCoordinate(Latitude, Longitude);
        }

        public override void SetValue(GeoCoordinate value)
        {
            Latitude = value?.Latitude ?? 0;
            Longitude = value?.Longitude ?? 0;
        }
    }
}