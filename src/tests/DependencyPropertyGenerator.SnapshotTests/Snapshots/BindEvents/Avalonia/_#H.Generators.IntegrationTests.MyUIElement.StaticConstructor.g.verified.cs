//HintName: H.Generators.IntegrationTests.MyUIElement.StaticConstructor.g.cs
#nullable enable

namespace H.Generators.IntegrationTests
{
    partial class MyUIElement
    {
        static MyUIElement()
        {
            StartOfStaticConstructor();
            BindEventsPropertyProperty.Changed.Subscribe(new global::Avalonia.Reactive.AnonymousObserver<global::Avalonia.AvaloniaPropertyChangedEventArgs<object?>>(static x =>
            {
                ((global::H.Generators.IntegrationTests.MyUIElement)x.Sender).OnBindEventsPropertyChanged(
                    (object?)x.OldValue.GetValueOrDefault(),
                    (object?)x.NewValue.GetValueOrDefault());
            }));
            EndOfStaticConstructor();
        }
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        static partial void StartOfStaticConstructor();
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        static partial void EndOfStaticConstructor();
    }
}