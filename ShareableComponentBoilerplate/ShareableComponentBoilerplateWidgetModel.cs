using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;

namespace CompanyName.ShareableComponentBoilerplate.Kentico.MVC
{
    public class ShareableComponentBoilerplateWidgetModel : IWidgetProperties
    {
        // Defines a property and sets its default value
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 0, Label = "Text")]
        public string TextValue { get; set; } = "Hello World";
    }
}
