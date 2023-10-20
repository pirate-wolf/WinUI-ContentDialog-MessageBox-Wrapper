**# WinUI-ContentDialog-MessageBox-Wrapper-C#**

A C# wrapper for the WPF/WinUI ContentDialog to display a message dialog within the application using the familiar MessageBox command from WinForms. I recently started working in WinUI coming from WinForms and wanted a familar tool to display even simple dialogs for troubleshooting, hence this was born. 

I've separated and set a variable for the displayStyle and a public bool for displaying dialogs full size to allow for easier setting of these properties either in the class or separately. 

The class contains 3 overloads of the Show() method. All take a Page as the first variable which should always be set to "this" when calling (ex. MessageBox.Show(this, "body", "title")) and is required for the command to access the XamlRoot of the calling page. 

**Show**(_Page, body, title_) - Simple messagebox with an OK button

**Show**(_Page, body, title, primaryButtonText_) - Allows customization of the primary button text

**Show**(_Page, body, title, primaryButtonText, secondaryButtonText_) - Allows customization of the primary and secondary button text

**Future plans:**

Handle return events

More overloads/customization options. 
