//HintName: H.Generators.IntegrationTests.MyControl[TModel].AttachedEvents.AttachedTrayLeftMouseDown.g.cs

#nullable enable

namespace H.Generators.IntegrationTests
{
    public partial class MyControl<TModel>
    {
        /// <summary>
        /// </summary>
        public static readonly global::System.Windows.RoutedEvent AttachedTrayLeftMouseDownEvent =
            global::System.Windows.EventManager.RegisterRoutedEvent(
                name: "AttachedTrayLeftMouseDown",
                routingStrategy: global::System.Windows.RoutingStrategy.Bubble,
                handlerType: typeof(global::System.Windows.RoutedEventHandler),
                ownerType: typeof(global::H.Generators.IntegrationTests.MyControl<TModel>));

        /// <summary>
        /// </summary>
        public static void AddAttachedTrayLeftMouseDownHandler(global::System.Windows.DependencyObject element, global::System.Windows.RoutedEventHandler handler)
        {
            element = element ?? throw new global::System.ArgumentNullException(nameof(element));

            if (element is global::System.Windows.UIElement uiElement)
            {
                uiElement.AddHandler(AttachedTrayLeftMouseDownEvent, handler);
            }
            else if (element is global::System.Windows.ContentElement contentElement)
            {
                contentElement.AddHandler(AttachedTrayLeftMouseDownEvent, handler);
            }
        }

        /// <summary>
        /// </summary>
        public static void RemoveAttachedTrayLeftMouseDownHandler(global::System.Windows.DependencyObject element, global::System.Windows.RoutedEventHandler handler)
        {
            element = element ?? throw new global::System.ArgumentNullException(nameof(element));

            if (element is global::System.Windows.UIElement uiElement)
            {
                uiElement.RemoveHandler(AttachedTrayLeftMouseDownEvent, handler);
            }
            else if (element is global::System.Windows.ContentElement contentElement)
            {
                contentElement.RemoveHandler(AttachedTrayLeftMouseDownEvent, handler);
            }
        }
    }
}