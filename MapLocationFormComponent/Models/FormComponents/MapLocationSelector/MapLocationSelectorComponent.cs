using Kentico.Forms.Web.Mvc;
using NetC.MapLocationFormComponent.Kentico.MVC;

[assembly: RegisterFormComponent(MapLocationSelectorComponent.IDENTIFIER, typeof(MapLocationSelectorComponent), "Map location selector", IsAvailableInFormBuilderEditor = false, ViewName = "FormComponents/_MapLocationSelector")]
namespace NetC.MapLocationFormComponent.Kentico.MVC
{
    /// <summary>
    /// Represents a Map Location selector
    /// </summary>
    public class MapLocationSelectorComponent : FormComponent<MapLocationSelectorProperties, MapLocation>
    {
        public const string IDENTIFIER = "MapLocationSelector";

        [BindableProperty]
        public double Latitude { get; set; }

        [BindableProperty]
        public double Longitude { get; set; }

        public override MapLocation GetValue()
        {
            return new MapLocation(Latitude, Longitude);
        }

        public override void SetValue(MapLocation value)
        {
            Latitude = value?.Latitude ?? 0;
            Longitude = value?.Longitude ?? 0;
        }
    }
}