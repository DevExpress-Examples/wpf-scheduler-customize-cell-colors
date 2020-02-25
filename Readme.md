# How to set the cell color using different approaches

This example illustrates approaches to set the time cell background in a scheduler grouped by resource:

<br/>

1. In [classic themes](https://docs.devexpress.com/WPF/400994/controls-and-libraries/scheduler/appearance-customization#classic-themes), a cell background color depends on the resource's color that can be specified via [ResourceItem](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.ResourceItem)'s [Brush](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.ResourceItem.Brush)/[BrushName](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.ResourceItem.BrushName) or [ResourceMappings](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.ResourceMappings)' [Brush](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.ResourceMappings.Brush) or [BrushName](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.ResourceMappings.BrushName)

```xml
<dxsch:DataSource.ResourceMappings>
    <dxsch:ResourceMappings Brush="Brush"
                            Caption="Caption"
                            Id="Id" />
</dxsch:DataSource.ResourceMappings>
```

2. Declare a custom resource brush set using the [BrushSet](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.SchedulerControl.BrushSet) property. Refer to [Brushes and Customization](https://docs.devexpress.com/WPF/400994/controls-and-libraries/scheduler/appearance-customization#brushes-and-customization) for more information.

```xml
<dxsch:SchedulerControl.BrushSet>
    <dxsch:BrushSet>
        <dxsch:BrushInfo Name="{x:Static dxsch:DefaultBrushNames.Resource1}"
                         Brush="OrangeRed" />
        <dxsch:BrushInfo Name="{x:Static dxsch:DefaultBrushNames.Resource2}"
                         Brush="YellowGreen" />
    </dxsch:BrushSet>
</dxsch:SchedulerControl.BrushSet>
```

3. Declare a custom resource provider set using the [BrushProvider](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.Common.BrushProvider) property. Refer to [Brush Provider](https://docs.devexpress.com/WPF/400994/controls-and-libraries/scheduler/appearance-customization#brush-provider) for more information.

```xml
<dxsch:SchedulerControl.BrushProvider>
    <dxsch:BrushProvider DefaultDarkCellBackground="LightCoral"                                                
                         DefaultLightCellBackground="LightSeaGreen"                                            
                         ResourceDarkCellBackground="{dxsch:OverrideBrushTransform OverrideBrush=LightGreen}"  
                         ResourceLightCellBackground="{dxsch:OverrideBrushTransform OverrideBrush=LightBlue}"/>
</dxsch:SchedulerControl.BrushProvider>
```

4. Use the [Time Regions](https://docs.devexpress.com/WPF/401378/controls-and-libraries/scheduler/time-regions) feature to highlight specific time frames.

```xml
<dxsch:DataSource AppointmentsSource="{Binding Appointments}"
                  ResourcesSource="{Binding Resources}"
                  TimeRegionsSource="{Binding TimeRegions}">
    <dxsch:DataSource.TimeRegionMappings>
        <dxsch:TimeRegionMappings Brush="Brush"
                                  End="EndTime"
                                  Id="Id"
                                  ResourceId="ResourceId"
                                  Start="StartTime" />
    </dxsch:DataSource.TimeRegionMappings>
```

5. (*not recommended*) Declare a custom cell style for a view using its CellStyle property as demonstrated in [previous versions of this example](https://github.com/DevExpress-Examples/how-to-set-the-cell-color-using-different-approaches-t604609/tree/17.2.3+). 
