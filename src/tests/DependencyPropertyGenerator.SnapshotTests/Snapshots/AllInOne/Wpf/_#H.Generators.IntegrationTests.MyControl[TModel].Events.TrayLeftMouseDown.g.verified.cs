﻿//HintName: H.Generators.IntegrationTests.MyControl[TModel].Events.TrayLeftMouseDown.g.cs
#nullable enable

namespace H.Generators.IntegrationTests
{
    partial class MyControl<TModel>
    {
        /// <summary>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        public static readonly global::System.Windows.RoutedEvent TrayLeftMouseDownEvent =
            global::System.Windows.EventManager.RegisterRoutedEvent(
                name: "TrayLeftMouseDown",
                routingStrategy: global::System.Windows.RoutingStrategy.Bubble,
                handlerType: typeof(global::System.Windows.RoutedEventHandler),
                ownerType: typeof(global::H.Generators.IntegrationTests.MyControl<TModel>));

        /// <summary>
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        public event global::System.Windows.RoutedEventHandler TrayLeftMouseDown
        {
            add => AddHandler(TrayLeftMouseDownEvent, value);
            remove => RemoveHandler(TrayLeftMouseDownEvent, value);
        }

        /// <summary>
        /// A helper method to raise the TrayLeftMouseDown event.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        protected global::System.Windows.RoutedEventArgs OnTrayLeftMouseDown()
        {
            var args = new global::System.Windows.RoutedEventArgs(TrayLeftMouseDownEvent);
            this.RaiseEvent(args);

            return args;
        }
    }
}