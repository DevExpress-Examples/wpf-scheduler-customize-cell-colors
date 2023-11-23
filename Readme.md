<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128656114/19.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T604609)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF Scheduler - Customize Cell Colors

This example illustrates multiple techniques used to set the time cell background in a scheduler grouped by resources:

![image](https://github.com/DevExpress-Examples/how-to-set-the-cell-color-using-different-approaches-t604609/assets/65009440/a1174c93-da25-4d8b-af4b-5bb462a70345)

## Map the Brush Property

In [classic themes](https://docs.devexpress.com/WPF/400994/controls-and-libraries/scheduler/appearance-customization#classic-themes), a cell background color depends on the resource color. Use the following properties to specify the resource color:

* [ResourceItem.Brush](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.ResourceItem.Brush) and [ResourceItem.BrushName](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.ResourceItem.BrushName)
* [ResourceMappings.Brush](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.ResourceMappings.Brush) and [ResourceMappings.BrushName](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.ResourceMappings.BrushName)

```xaml
<dxsch:DataSource.ResourceMappings>
    <dxsch:ResourceMappings Brush="Brush"
                            Caption="Caption"
                            Id="Id"/>
</dxsch:DataSource.ResourceMappings>
```

### Files to Review

* [ResourceBrushPropertyView.xaml](./CS/DXSample/Views/ResourceBrushPropertyView.xaml)
* [ResourceViewModel.cs](./CS/DXSample/ViewModels/ResourceViewModel.cs) (VB: [ResourceViewModel.vb](./VB/DXSample/ViewModels/ResourceViewModel.vb))

## Brush Set

Use the [BrushSet](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.SchedulerControl.BrushSet) property to declare a custom resource brush set. Refer to the following help topic for more information: [Brushes and Customization](https://docs.devexpress.com/WPF/400994/controls-and-libraries/scheduler/appearance-customization#brushes-and-customization).

```xaml
<dxsch:SchedulerControl.BrushSet>
    <dxsch:BrushSet>
        <dxsch:BrushInfo Name="{x:Static dxsch:DefaultBrushNames.Resource1}"
                         Brush="OrangeRed"/>
        <dxsch:BrushInfo Name="{x:Static dxsch:DefaultBrushNames.Resource2}"
                         Brush="YellowGreen"/>
    </dxsch:BrushSet>
</dxsch:SchedulerControl.BrushSet>
```

### Files to Review

* [BrushSetView.xaml](./CS/DXSample/Views/BrushSetView.xaml)

## Brush Provider

Use the [BrushProvider](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.Common.BrushProvider) property to declare a custom resource provider set. Refer to the following help topic for more information: [Brush Provider](https://docs.devexpress.com/WPF/400994/controls-and-libraries/scheduler/appearance-customization#brush-provider).

```xaml
<dxsch:SchedulerControl.BrushProvider>
    <dxsch:BrushProvider DefaultDarkCellBackground="LightCoral"                                                
                         DefaultLightCellBackground="LightSeaGreen"                                            
                         ResourceDarkCellBackground="{dxsch:OverrideBrushTransform OverrideBrush=LightGreen}"  
                         ResourceLightCellBackground="{dxsch:OverrideBrushTransform OverrideBrush=LightBlue}"/>
</dxsch:SchedulerControl.BrushProvider>
```

### Files to Review

* [BrushProviderView.xaml](./CS/DXSample/Views/BrushProviderView.xaml)

## Time Regions

Use the [Time Regions](https://docs.devexpress.com/WPF/401378/controls-and-libraries/scheduler/time-regions) feature to highlight specific time frames.

```xaml
<dxsch:DataSource AppointmentsSource="{Binding Appointments}"
                  ResourcesSource="{Binding Resources}"
                  TimeRegionsSource="{Binding TimeRegions}">
    <dxsch:DataSource.TimeRegionMappings>
        <dxsch:TimeRegionMappings Brush="Brush"
                                  End="EndTime"
                                  Id="Id"
                                  ResourceId="ResourceId"
                                  Start="StartTime"/>
    </dxsch:DataSource.TimeRegionMappings>
</dxsch:DataSource>
```

### Files to Review

* [TimeRegionsView.xaml](./CS/DXSample/Views/TimeRegionsView.xaml)
* [TimeRegionViewModel.cs](./CS/DXSample/ViewModels/TimeRegionViewModel.cs) (VB: [TimeRegionViewModel.vb](./VB/DXSample/ViewModels/TimeRegionViewModel.vb))

## (*not recommended*) Cell Style

Use the `CellStyle` property to declare a custom cell style for a view, as demonstrated in [previous versions of this example](https://github.com/DevExpress-Examples/how-to-set-the-cell-color-using-different-approaches-t604609/tree/17.2.3+).

## Documentation

* [Customize Colors](https://docs.devexpress.com/WPF/400994/controls-and-libraries/scheduler/appearance-customization)
* [Customize Appointments](https://docs.devexpress.com/WPF/119867/controls-and-libraries/scheduler/styles-and-templates/visual-appointment)

## More Examples

* [WPF Scheduler - Highlight Time Intervals](https://github.com/DevExpress-Examples/wpf-scheduler-highlight-time-intervals)
* [WPF Scheduler - Customize Appointment Appearance](https://github.com/DevExpress-Examples/wpf-scheduler-customize-appointment-appearance)
* [WPF Scheduler - Handle the CustomAppointmentBackground Event to Change the Appointment Background](https://github.com/DevExpress-Examples/wpf-scheduler-handle-customappointmentbackground-event-to-change-appointment-background)
* [WPF Scheduler - Customize the Appointment Flyout and Tooltip](https://github.com/DevExpress-Examples/wpf-scheduler-customize-appointment-flyout-and-tooltip)
* [WPF Scheduler - Disable Resource Colorization](https://github.com/DevExpress-Examples/wpf-scheduler-disable-resource-colorization)
