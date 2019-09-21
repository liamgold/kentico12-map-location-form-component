using Kentico.PageBuilder.Web.Mvc;
using CompanyName.ShareableComponentBoilerplate.Kentico.MVC;

// Registers the Widget, pointing to the View that is actually compiled and located in the ShareableComponentBoilerplate.View project.
[assembly: RegisterWidget("CompanyName.ShareableComponentBoilerplate", "Sample widget", typeof(ShareableComponentBoilerplateWidgetModel), customViewName: "Widgets/_ShareableComponentBoilerplate")]

// FOR TESTING
// You can change the registration to point to a local View (non compiled) in order to debug.  
// This particular view is on my MVC Project, NOT my compiled ShareableComponentBoilerplate.View project
//[assembly: RegisterWidget("CompanyName.ShareableComponentBoilerplate", "Sample widget", typeof(ShareableComponentBoilerplateWidgetModel), customViewName: "Widgets/_ShareableComponentBoilerplate_Test")]