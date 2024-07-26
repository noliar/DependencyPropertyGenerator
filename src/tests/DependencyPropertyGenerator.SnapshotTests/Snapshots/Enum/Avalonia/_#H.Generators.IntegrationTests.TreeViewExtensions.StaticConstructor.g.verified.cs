//HintName: H.Generators.IntegrationTests.TreeViewExtensions.StaticConstructor.g.cs
#nullable enable

namespace H.Generators.IntegrationTests
{
    partial class TreeViewExtensions
    {
        static TreeViewExtensions()
        {
            StartOfStaticConstructor();
            ModeProperty.Changed.Subscribe(new global::Avalonia.Reactive.AnonymousObserver<global::Avalonia.AvaloniaPropertyChangedEventArgs<global::H.Generators.IntegrationTests.Mode>>(static x =>
            {
                OnModeChanged(
                    (global::Avalonia.Controls.TreeView)x.Sender,
                    (global::H.Generators.IntegrationTests.Mode)x.OldValue.GetValueOrDefault(),
                    (global::H.Generators.IntegrationTests.Mode)x.NewValue.GetValueOrDefault());
            }));
            EndOfStaticConstructor();
        }
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        static partial void StartOfStaticConstructor();
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        static partial void EndOfStaticConstructor();
    }
}