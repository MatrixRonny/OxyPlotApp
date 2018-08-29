# OxyPlotApp
This WPF project makes OxyPlot throw an InvalidOperationException with the following message: 'This PlotModel is already in use by some other PlotView control.' It seems that the problem is related to DataTemplates.

Apart from MainViewModel, which does the setup, there are three ViewModels used within this application:
* FirstViewModel does not involve anything related to OxyPlot.
* SecondViewModel creates a PlotModel that is bound to a PlotView.
* IntermediateViewModel is used to create an additional layer of DataTemplates.

Only one instance of every ViewModel is created during the application runtime and multiple Views. MainView displays any of these ViewModels within ContentControls though DataTemplates. In addition, IntermediateView displays the Data property of its ViewModel within another ContentControl. The ideea is that, different instances of PlotView are binded to the same PlotModel at different points in time.

The application works fine only when FirstViewModel and SecondViewModel are displayed as content. Any ViewModel other than FirstViewModel that is displayed after IntermediateViewModel will cause the scenario described in the first paragraph. Sometimes, the GC runs and prevents this from happening, by collecting the Views that contain the binded PlotView.

It seems that, in the case of IntermediateViewModel, the PlotView.OnModelChanged method does not get called when the ViewModel is replaced. I think this happens when the following change occurs:
1. View => DataTemplate1 => View1 => DataTemplate2 => View2 => PlotView
2. View => DataTemplate3 => View3

I did some research and the problem does not happen in the following case:
1. View => DataTemplate1 => View1 => DataTemplate2 => View2 => PlotView
2. View => DataTemplate1 => View1 => DataTemplate3 => View3
