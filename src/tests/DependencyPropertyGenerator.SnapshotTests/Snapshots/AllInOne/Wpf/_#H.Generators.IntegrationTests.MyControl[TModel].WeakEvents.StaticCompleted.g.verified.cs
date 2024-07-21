//HintName: H.Generators.IntegrationTests.MyControl[TModel].WeakEvents.StaticCompleted.g.cs
#nullable enable

namespace H.Generators.IntegrationTests
{
    partial class MyControl<TModel>
    {
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        private class StaticCompletedWeakEventManager : global::System.Windows.WeakEventManager
        {
            private StaticCompletedWeakEventManager()
            {
            }

            public static void AddHandler(object? source, global::System.EventHandler? handler)
            {
                if (source == null)
                    throw new global::System.ArgumentNullException(nameof(source));
                if (handler == null)
                    throw new global::System.ArgumentNullException(nameof(handler));

                CurrentManager.ProtectedAddHandler(source, handler);
            }

            public static void RemoveHandler(object? source, global::System.EventHandler? handler)
            {
                if (source == null)
                    throw new global::System.ArgumentNullException(nameof(source));
                if (handler == null)
                    throw new global::System.ArgumentNullException(nameof(handler));

                CurrentManager.ProtectedRemoveHandler(source, handler);
            }

            internal static StaticCompletedWeakEventManager CurrentManager
            {
                get
                {
                    var managerType = typeof(StaticCompletedWeakEventManager);
                    var manager = (StaticCompletedWeakEventManager)GetCurrentManager(managerType);
                    if (manager == null)
                    {
                        manager = new StaticCompletedWeakEventManager();
                        SetCurrentManager(managerType, manager);
                    }

                    return manager;
                }
            }

            protected override void StartListening(object? source)
            {
                MyControl<TModel>.StaticCompleted += OnStaticCompleted;
            }

            protected override void StopListening(object? source)
            {
                MyControl<TModel>.StaticCompleted -= OnStaticCompleted;
            }

            internal void OnStaticCompleted(object? sender, global::System.EventArgs args)
            {
                DeliverEvent(sender, args);
            }
        }

        /// <summary>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        public static event global::System.EventHandler? StaticCompleted
        {
            add => StaticCompletedWeakEventManager.AddHandler(null, value);
            remove => StaticCompletedWeakEventManager.RemoveHandler(null, value);
        }

        /// <summary>
        /// A helper method to raise the StaticCompleted event.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        internal static void RaiseStaticCompletedEvent(object? sender)
        {
            StaticCompletedWeakEventManager.CurrentManager.OnStaticCompleted(sender, global::System.EventArgs.Empty);
        }
    }
}