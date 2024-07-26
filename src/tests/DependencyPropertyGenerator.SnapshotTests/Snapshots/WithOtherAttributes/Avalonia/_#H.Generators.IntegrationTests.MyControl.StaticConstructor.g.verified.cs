//HintName: H.Generators.IntegrationTests.MyControl.StaticConstructor.g.cs
#nullable enable

namespace H.Generators.IntegrationTests
{
    partial class MyControl
    {
        static MyControl()
        {
            StartOfStaticConstructor();
            IsSpinning5Property.Changed.Subscribe(new global::Avalonia.Reactive.AnonymousObserver<global::Avalonia.AvaloniaPropertyChangedEventArgs<bool>>(static x =>
            {
                ((global::H.Generators.IntegrationTests.MyControl)x.Sender).OnIsSpinning5Changed(
                    (bool)x.OldValue.GetValueOrDefault(),
                    (bool)x.NewValue.GetValueOrDefault());
            }));
            EndOfStaticConstructor();
        }
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        static partial void StartOfStaticConstructor();
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        static partial void EndOfStaticConstructor();
    }
}