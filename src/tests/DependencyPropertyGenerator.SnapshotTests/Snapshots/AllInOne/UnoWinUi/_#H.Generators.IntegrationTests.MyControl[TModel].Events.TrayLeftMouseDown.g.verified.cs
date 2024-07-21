//HintName: H.Generators.IntegrationTests.MyControl[TModel].Events.TrayLeftMouseDown.g.cs
#nullable enable

namespace H.Generators.IntegrationTests
{
    public partial class MyControl<TModel>
    {
        /// <summary>
        /// A helper method to raise the TrayLeftMouseDown event. <br/>
        /// WinRT events are disabled by default due to a series of issues with them in Windows 10:
        /// https://github.com/HavenDV/H.NotifyIcon/issues/36
        /// https://github.com/HavenDV/H.NotifyIcon/issues/31
        /// Use the WinRTEvents = true option to enable them.
        /// </summary>
        protected global::Microsoft.UI.Xaml.RoutedEventArgs? OnTrayLeftMouseDown()
        {
            return null;
        }
    }
}