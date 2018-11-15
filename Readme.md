<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/CustomCellColoring/MainWindow.xaml) (VB: [MainWindow.xaml.vb](./VB/CustomCellColoring/MainWindow.xaml.vb))
* [MainWindow.xaml.cs](./CS/CustomCellColoring/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/CustomCellColoring/MainWindow.xaml.vb))
* [MyCategory.cs](./CS/CustomCellColoring/Model/MyCategory.cs) (VB: [MyCategory.vb](./VB/CustomCellColoring/Model/MyCategory.vb))
* [MyViewModel.cs](./CS/CustomCellColoring/ViewModels/MyViewModel.cs) (VB: [MyViewModel.vb](./VB/CustomCellColoring/ViewModels/MyViewModel.vb))
<!-- default file list end -->
# How to set the cell color using different approaches


This example illustrates approaches to set the color of a time cell in a scheduler grouped by resource.<br>1. Each resource can have its own color specified by the <a href="http://help.devexpress.com/#WPF/DevExpressXpfSchedulingResourceItem_Colortopic">ResourceItem.Color</a> property. Uncomment two lines in the MainWindow's XAML to assign the resource color mapping, so that each resource obtains its color from the data source.<br>2. Use a custom resource brush schema. Create a <a href="http://help.devexpress.com/#WPF/clsDevExpressXpfSchedulingResourceBrushSchemaCollectiontopic">ResourceBrushSchemaCollection</a> object in MainWindow's XAML resources and assign it to the  <a href="http://help.devexpress.com/#WPF/DevExpressXpfSchedulingSchedulerControl_ResourceBrushSchemastopic">SchedulerControl.ResourceBrushSchemas</a> property.<br>3. Create a <a href="http://help.devexpress.com/#WPF/clsDevExpressXpfSchedulingVisualCellControltopic">CellControl</a>'s data template, define a cell style and assign the style to the appropriate property of the desired view

* Day view, Work-Week view, Week view - use the <a href="http://help.devexpress.com/#WPF/DevExpressXpfSchedulingDayViewBase_AllDayCellStyletopic">DayViewBase.AllDayCellStyle</a> and <a href="http://help.devexpress.com/#WPF/DevExpressXpfSchedulingDayViewBase_CellStyletopic">DayViewBase.CellStyle</a> properties;
* Month view - use the <a href="http://help.devexpress.com/#WPF/DevExpressXpfSchedulingMonthView_CellStyletopic">MonthView.CellStyle</a> property;
* Timeline view - use the <a href="http://help.devexpress.com/#WPF/DevExpressXpfSchedulingTimelineView_CellStyletopic">TimelineView.CellStyle</a> property.<br>The picture below demonstrates a custom cell style and template applied to the selected cells of the resource with ID=1.  A custom data template displays the time interval contained in the cell's data context.<br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-set-the-cell-color-using-different-approaches-t604609/17.2.3+/media/8eba6552-cd7a-4c2c-aa89-223b074362d6.png">

<br/>


