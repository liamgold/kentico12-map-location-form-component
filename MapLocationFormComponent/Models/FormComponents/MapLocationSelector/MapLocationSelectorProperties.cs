using CMS.DataEngine;
using Kentico.Forms.Web.Mvc;

namespace NetC.MapLocationFormComponent.Kentico.MVC
{
    public class MapLocationSelectorProperties : FormComponentProperties<MapLocation>
    {
        public MapLocationSelectorProperties() : base(FieldDataType.Text)
        {
        }

        [DefaultValueEditingComponent(MapLocationSelectorComponent.IDENTIFIER)]
        public override MapLocation DefaultValue { get; set; }
    }
}