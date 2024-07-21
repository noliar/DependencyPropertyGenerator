//HintName: H.Generators.IntegrationTests.MyControl[TModel].StaticConstructor.g.cs
#nullable enable

namespace H.Generators.IntegrationTests
{
    partial class MyControl<TModel>
    {
        static MyControl()
        {
            ModelProperty.Changed.Subscribe(new global::Avalonia.Reactive.AnonymousObserver<global::Avalonia.AvaloniaPropertyChangedEventArgs<TModel?>>(static x =>
            {
                ((global::H.Generators.IntegrationTests.MyControl<TModel>)x.Sender).OnModelChanged();
            }));

            IsSpinning2Property.Changed.Subscribe(new global::Avalonia.Reactive.AnonymousObserver<global::Avalonia.AvaloniaPropertyChangedEventArgs<bool>>(static x =>
            {
                ((global::H.Generators.IntegrationTests.MyControl<TModel>)x.Sender).OnIsSpinning2Changed();
            }));

            IsSpinningProperty.Changed.Subscribe(new global::Avalonia.Reactive.AnonymousObserver<global::Avalonia.AvaloniaPropertyChangedEventArgs<bool>>(static x =>
            {
                ((global::H.Generators.IntegrationTests.MyControl<TModel>)x.Sender).OnIsSpinningChanged(
                    (bool)x.OldValue.GetValueOrDefault(),
                    (bool)x.NewValue.GetValueOrDefault());
            }));
            IsSpinning3Property.Changed.Subscribe(new global::Avalonia.Reactive.AnonymousObserver<global::Avalonia.AvaloniaPropertyChangedEventArgs<bool>>(static x =>
            {
                OnIsSpinning3Changed();
            }));
        }
    }
}