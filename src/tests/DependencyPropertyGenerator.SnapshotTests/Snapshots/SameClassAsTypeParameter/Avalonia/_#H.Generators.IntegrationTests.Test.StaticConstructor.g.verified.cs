//HintName: H.Generators.IntegrationTests.Test.StaticConstructor.g.cs
#nullable enable

namespace H.Generators.IntegrationTests
{
    partial class Test
    {
        static Test()
        {
            StartOfStaticConstructor();
            TestPropProperty.Changed.Subscribe(new global::Avalonia.Reactive.AnonymousObserver<global::Avalonia.AvaloniaPropertyChangedEventArgs<global::H.Generators.IntegrationTests.Test?>>(static x =>
            {
                TestChanged(
                    (global::Avalonia.Controls.Grid)x.Sender,
                    (global::H.Generators.IntegrationTests.Test?)x.NewValue.GetValueOrDefault());
            }));
            EndOfStaticConstructor();
        }
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        static partial void StartOfStaticConstructor();
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        static partial void EndOfStaticConstructor();
    }
}