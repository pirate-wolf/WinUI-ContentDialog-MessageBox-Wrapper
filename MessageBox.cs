//MessageBox Wrapper for ContentDialog
//v1.0
//Created by Allen White, aka APirateWolf
//Creation date: 10/18/2023

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System;

namespace TSTC_Directory_Viewer_2
{
    /// <summary>
    /// Wrapper for the WPF/WinUI ContentDialog to display a message dialog within the application
    /// using the familiar MessageBox command from WinForms.
    /// </summary>
    /// 

    //TODO - Handle/return dialog results
    internal class MessageBox
    {
        /// <summary>
        /// Set the style for all dialogs
        /// </summary>
        private static Style dialogStyle = Application.Current.Resources["DefaultContentDialogStyle"] as Style;

        /// <summary>
        /// Toggle whether to show dialogs full size
        /// </summary>
        public static bool displayDialogsFullSize = false;

        //Expose the ContentDialog instance so that events can be assigned directly in other code.
        public static ContentDialog dialog = new ContentDialog();

        /// <summary>
        /// Display a dialog with body text and an OK button
        /// </summary>
        /// <param name="page">Page calling the command for XamlRoot, should always be "this" to reference current page</param>
        /// <param name="body">Main body text of the dialog</param>
        public static async void Show(Page page, string body)
        {

            dialog.XamlRoot = page.XamlRoot;
            dialog.Style = dialogStyle;
            dialog.Content = body;
            dialog.PrimaryButtonText = "OK";
            dialog.DefaultButton = ContentDialogButton.Primary;
            dialog.FullSizeDesired = displayDialogsFullSize;

            await dialog.ShowAsync();
        }

        /// <summary>
        /// Display a dialog with body text, title text, and an OK button
        /// </summary>
        /// <param name="page">Page calling the command for XamlRoot, should always be "this" to reference current page</param>
        /// <param name="body">Main body text of the dialog</param>
        /// <param name="title">Title text of the dialog</param>
        public static async void Show(Page page, string body, string title)
        {

            dialog.XamlRoot = page.XamlRoot;
            dialog.Style = dialogStyle;
            dialog.Title = title;
            dialog.Content = body;
            dialog.PrimaryButtonText = "OK";
            dialog.DefaultButton = ContentDialogButton.Primary;
            dialog.FullSizeDesired = displayDialogsFullSize;

            await dialog.ShowAsync();
        }

        /// <summary>
        /// Display a dialog with body text, title text, and a customizable primary button
        /// </summary>
        /// 
        /// <param name="page">Page calling the command for XamlRoot, should always be "this" to reference current page</param>
        /// <param name="body">Main body text of the dialog</param>
        /// <param name="title">Title text of the dialog</param>
        /// <param name="primaryButtonText">Text for the primary button</param>
        public static async void Show(Page page, string body, string title, string primaryButtonText)
        {
            dialog.XamlRoot = page.XamlRoot;
            dialog.Style = dialogStyle;
            dialog.Title = title;
            dialog.Content = body;
            dialog.PrimaryButtonText = primaryButtonText;
            dialog.DefaultButton = ContentDialogButton.Primary;
            dialog.FullSizeDesired = displayDialogsFullSize;

            await dialog.ShowAsync();
        }

        /// <summary>
        /// Display a dialog with body text, title text, and customizable primary and secondary buttons
        /// </summary>
        /// <param name="page">Page calling the command for XamlRoot, should always be "this" to reference current page</param>
        /// <param name="body">Main body text of the dialog</param>
        /// <param name="title">Title text of the dialog</param>
        /// <param name="primaryButtonText">Text for the primary button</param>
        /// <param name="secondaryButtonText">Text for the secondary button</param>
        public static async void Show(Page page, string body, string title, string primaryButtonText, string secondaryButtonText)
        {
            dialog.XamlRoot = page.XamlRoot;
            dialog.Style = dialogStyle;
            dialog.Title = title;
            dialog.Content = body;
            dialog.PrimaryButtonText = primaryButtonText;
            dialog.SecondaryButtonText = secondaryButtonText;
            dialog.DefaultButton = ContentDialogButton.Primary;
            dialog.FullSizeDesired = displayDialogsFullSize;

            await dialog.ShowAsync();
        }
    }
}
