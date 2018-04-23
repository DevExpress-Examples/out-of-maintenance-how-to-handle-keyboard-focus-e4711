# How to handle keyboard focus


<p>This example illustrates how to move keyboard focus between RichEditControl and adjacent controls when the TAB or SHIFT+TAB key combinations are pressed. This allows you to overcome the following limitation: <a href="https://www.devexpress.com/Support/Center/p/S137077">Need the AcceptTab property</a>.</p>
<p>The main idea is to set the <a href="https://msdn.microsoft.com/en-us/library/system.windows.input.keyboardnavigation.tabnavigation.aspx">KeyboardNavigation.TabNavigation</a> property for a RichEditControl to Once to avoid visiting its child elements and process tab navigation keys manually. </p>

<br/>


