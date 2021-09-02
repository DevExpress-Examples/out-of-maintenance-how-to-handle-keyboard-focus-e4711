<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128607725/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4711)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))
<!-- default file list end -->
# How to handle keyboard focus


<p>This example illustrates how to move keyboard focus between RichEditControl and adjacent controls when the TAB or SHIFT+TAB key combinations are pressed. This allows you to overcome the following limitation: <a href="https://www.devexpress.com/Support/Center/p/S137077">Need the AcceptTab property</a>.</p>
<p>The main idea is to set the <a href="https://msdn.microsoft.com/en-us/library/system.windows.input.keyboardnavigation.tabnavigation.aspx">KeyboardNavigation.TabNavigation</a> property for a RichEditControl to Once to avoid visiting its child elements and process tab navigation keys manually. </p>

<br/>


