//HintName: H.Generators.IntegrationTests.Generatable.StaticConstructor.g.cs
#nullable enable

namespace H.Generators.IntegrationTests
{
    partial class Generatable
    {
        static Generatable()
        {
            StartOfStaticConstructor();
            TextProperty.Changed.Subscribe(new global::Avalonia.Reactive.AnonymousObserver<global::Avalonia.AvaloniaPropertyChangedEventArgs<string?>>(static x =>
            {
                ((global::H.Generators.IntegrationTests.Generatable)x.Sender).OnMyTextChanged(
                    (string?)x.NewValue.GetValueOrDefault());
            }));
            EndOfStaticConstructor();
        }
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        static partial void StartOfStaticConstructor();
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        static partial void EndOfStaticConstructor();
    }
}