# Kentico 12 MVC Map Location Form Component
map-location-form-component for Kentico MVC, adds the ability for a content editor to capture a latitude/longitude value by clicking a location on a map.

## Nuget Package
https://www.nuget.org/packages/NetC.MapLocationFormComponent.Kentico.MVC/

## Example use
1. Include a property within an MVC widget property class:
```
[EditingComponent(MapLocationSelectorComponent.IDENTIFIER, Label = "Location")]
/// <summary>
/// Map Location field input.
/// </summary>
public MapLocation Location { get; set; }
```

2. Complete setting up the MVC widget itself, maybe you want to pass the individual values for Latitude and Longitude to your widget view model:
```
return PartialView("Widgets/_BannerWidget", new BannerWidgetViewModel
{
	Latitude = properties.Location?.Latitude ?? 0,
	Longitude = properties.Location?.Longitude ?? 0,
	Image = image,
	Text = properties.Text,
	LinkUrl = properties.LinkUrl,
	LinkTitle = properties.LinkTitle
});
```

3. Add the widget to an MVC page, and open the config window to see the new property available:
![form component image](https://raw.githubusercontent.com/liamgold/map-location-form-component/master/img/FormComponent.png)

## ⌨️ Contributions, 🐛 bug fixes and 📜 license
Feel free to Fork and submit pull requests to contribute.

You can submit bugs through the issue list and we will get to them as soon as we can, unless you want to fix it yourself and submit a pull request!

Check the LICENSE.txt for License information

## Compatibility
Can be used on any Kentico 12 SP site (hotfix 29 or above).
