//HintName: H.Generators.IntegrationTests.TreeViewExtensions.StaticConstructor.g.cs
#nullable enable

namespace H.Generators.IntegrationTests
{
    partial class TreeViewExtensions
    {
        static TreeViewExtensions()
        {
            StartOfStaticConstructor();
            SelectedItemProperty.Changed.Subscribe(new global::Avalonia.Reactive.AnonymousObserver<global::Avalonia.AvaloniaPropertyChangedEventArgs<object?>>(static x =>
            {
                OnSelectedItemChanged(
                    (global::Avalonia.Controls.TreeView)x.Sender,
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