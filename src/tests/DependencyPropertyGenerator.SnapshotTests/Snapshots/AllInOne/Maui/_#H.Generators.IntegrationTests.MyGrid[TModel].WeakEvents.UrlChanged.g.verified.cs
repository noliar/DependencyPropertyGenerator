//HintName: H.Generators.IntegrationTests.MyGrid[TModel].WeakEvents.UrlChanged.g.cs
#nullable enable

namespace H.Generators.IntegrationTests
{
    partial class MyGrid<TModel>
    {
        private global::Microsoft.Maui.WeakEventManager UrlChangedWeakEventManager { get; } = new global::Microsoft.Maui.WeakEventManager();
        /// <summary>
        /// </summary>
        public event global::System.EventHandler<string?>? UrlChanged
        {
            add => UrlChangedWeakEventManager.AddEventHandler(value);
            remove => UrlChangedWeakEventManager.RemoveEventHandler(value);
        }

        /// <summary>
        /// A helper method to raise the UrlChanged event.
        /// </summary>
        internal void RaiseUrlChangedEvent(object? sender, string? args)
        {
            UrlChangedWeakEventManager.HandleEvent(sender!, args!, eventName: nameof(UrlChanged));
        }
    }
}