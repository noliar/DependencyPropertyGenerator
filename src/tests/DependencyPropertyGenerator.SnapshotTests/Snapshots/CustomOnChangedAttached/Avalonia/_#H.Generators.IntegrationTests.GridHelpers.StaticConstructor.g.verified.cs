//HintName: H.Generators.IntegrationTests.GridHelpers.StaticConstructor.g.cs
#nullable enable

namespace H.Generators.IntegrationTests
{
    partial class GridHelpers
    {
        static GridHelpers()
        {
            StartOfStaticConstructor();
            RowCountProperty.Changed.Subscribe(new global::Avalonia.Reactive.AnonymousObserver<global::Avalonia.AvaloniaPropertyChangedEventArgs<int>>(static x =>
            {
                OnRowCountChanged(
                    (global::Avalonia.Controls.Grid)x.Sender,
                    (int)x.NewValue.GetValueOrDefault());
            }));
            EndOfStaticConstructor();
        }
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        static partial void StartOfStaticConstructor();
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        static partial void EndOfStaticConstructor();
    }
}