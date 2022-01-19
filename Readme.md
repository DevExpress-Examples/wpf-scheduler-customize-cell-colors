<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128656114/19.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T604609)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to: Customize Scheduler Cell Colors

This example illustrates techniques to set the time cell background in a scheduler grouped by resource:

<br/>

1. In [classic themes](https://docs.devexpress.com/WPF/400994/controls-and-libraries/scheduler/appearance-customization#classic-themes), a cell background color depends on the resource's color. Use the following properties to specify the resource color:
    * [ResourceItem.Brush](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.ResourceItem.Brush) and [ResourceItem.BrushName](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.ResourceItem.BrushName)
    * [ResourceMappings.Brush](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.ResourceMappings.Brush) and [ResourceMappings.BrushName](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.ResourceMappings.BrushName)

    ```xml
    <dxsch:DataSource.ResourceMappings>
        <dxsch:ResourceMappings Brush="Brush"
                                Caption="Caption"
                                Id="Id" />
    </dxsch:DataSource.ResourceMappings>
    ```

2. Use the [BrushSet](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.SchedulerControl.BrushSet) property to declare a custom resource brush set. Refer to [Brushes and Customization](https://docs.devexpress.com/WPF/400994/controls-and-libraries/scheduler/appearance-customization#brushes-and-customization) for more information.

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

3. Use the [BrushProvider](https://docs.devexpress.com/WPF/DevExpress.Xpf.Scheduling.Common.BrushProvider) property to declare a custom resource provider set. Refer to [Brush Provider](https://docs.devexpress.com/WPF/400994/controls-and-libraries/scheduler/appearance-customization#brush-provider) for more information.

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
