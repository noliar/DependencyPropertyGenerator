//HintName: H.Generators.IntegrationTests.UIElementExtensions.StaticConstructor.g.cs
#nullable enable

namespace H.Generators.IntegrationTests
{
    partial class UIElementExtensions
    {
        static UIElementExtensions()
        {
            StartOfStaticConstructor();
            BindEventPropertyProperty.Changed.Subscribe(new global::Avalonia.Reactive.AnonymousObserver<global::Avalonia.AvaloniaPropertyChangedEventArgs<object?>>(static x =>
            {
                OnBindEventPropertyChanged(
                    (global::Avalonia.Input.InputElement)x.Sender,
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