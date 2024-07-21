//HintName: H.Generators.IntegrationTests.MyGrid[TModel].WeakEvents.StaticCompleted.g.cs
#nullable enable

namespace H.Generators.IntegrationTests
{
    partial class MyGrid<TModel>
    {
        private static global::Microsoft.Maui.WeakEventManager StaticCompletedWeakEventManager { get; } = new global::Microsoft.Maui.WeakEventManager();
        /// <summary>
        /// </summary>
        public static event global::System.EventHandler? StaticCompleted
        {
            add => StaticCompletedWeakEventManager.AddEventHandler(value);
            remove => StaticCompletedWeakEventManager.RemoveEventHandler(value);
        }

        /// <summary>
        /// A helper method to raise the StaticCompleted event.
        /// </summary>
        internal static void RaiseStaticCompletedEvent(object? sender)
        {
            StaticCompletedWeakEventManager.HandleEvent(sender!, global::System.EventArgs.Empty!, eventName: nameof(StaticCompleted));
        }
    }
}