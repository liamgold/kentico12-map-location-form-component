using CMS.DataEngine;
using Kentico.Forms.Web.Mvc;
using System.Device.Location;

namespace NetC.MapLocationFormComponent.Kentico.MVC
{
    public class MapLocationSelectorProperties : FormComponentProperties<GeoCoordinate>
    {
        public MapLocationSelectorProperties() : base(FieldDataType.Text)
        {
        }

        [DefaultValueEditingComponent(MapLocationSelectorComponent.IDENTIFIER)]
        public override GeoCoordinate DefaultValue { get; set; }
    }
}