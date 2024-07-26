//HintName: H.Generators.IntegrationTests.AnotherControl.StaticConstructor.g.cs
#nullable enable

namespace H.Generators.IntegrationTests
{
    partial class AnotherControl
    {
        static AnotherControl()
        {
            StartOfStaticConstructor();
            MyProperty3Property.Changed.Subscribe(new global::Avalonia.Reactive.AnonymousObserver<global::Avalonia.AvaloniaPropertyChangedEventArgs<int>>(static x =>
            {
                ((global::H.Generators.IntegrationTests.AnotherControl)x.Sender).OnMyProperty3Changed();
            }));

            MyPropertyProperty.Changed.Subscribe(new global::Avalonia.Reactive.AnonymousObserver<global::Avalonia.AvaloniaPropertyChangedEventArgs<int>>(static x =>
            {
                ((global::H.Generators.IntegrationTests.AnotherControl)x.Sender).OnMyPropertyChanged();
            }));

            MyProperty2Property.Changed.Subscribe(new global::Avalonia.Reactive.AnonymousObserver<global::Avalonia.AvaloniaPropertyChangedEventArgs<(int, string)>>(static x =>
            {
                ((global::H.Generators.IntegrationTests.AnotherControl)x.Sender).OnMyProperty2Changed();
            }));
            EndOfStaticConstructor();
        }
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        static partial void StartOfStaticConstructor();
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        static partial void EndOfStaticConstructor();
    }
}