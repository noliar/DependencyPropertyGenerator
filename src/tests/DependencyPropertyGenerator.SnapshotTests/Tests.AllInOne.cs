namespace H.Generators.SnapshotTests;

public partial class Tests
{
    [DataTestMethod]
    [DataRow(Framework.Wpf)]
    [DataRow(Framework.Uno)]
    [DataRow(Framework.UnoWinUi)]
    [DataRow(Framework.Maui)]
    [DataRow(Framework.Avalonia)]
    public Task AllInOne(Framework framework)
    {
        return CheckSourceAsync<DependencyPropertyGenerator>(GetHeader(framework, string.Empty, "Controls", "Media") + @"
[DependencyProperty(""Model"", ""TModel"")]
[DependencyProperty<bool>(""IsSpinning"", DefaultValue = true, Category = ""Category"", Description = ""Description"")]
[DependencyProperty(""IsSpinning2"", typeof(bool))]
[AttachedDependencyProperty<bool, FrameworkElement>(""IsSpinning3"")]
[AddOwner<Brush, Border>(nameof(Border.Background))]
[RoutedEvent(""TrayLeftMouseDown"", RoutedEventStrategy.Bubble)]
[RoutedEvent(""AttachedTrayLeftMouseDown"", RoutedEventStrategy.Bubble, IsAttached = true)]
[WeakEvent<string>(""UrlChanged"")]
[WeakEvent(""Completed"")]
[WeakEvent(""StaticCompleted"", IsStatic = true)]
public partial class MyControl<TModel> : UIElement
{
    public bool IsChanged { get; private set; }
    
    // Optional
    partial void OnIsSpinningChanged(bool oldValue, bool newValue)
    {
        IsChanged = true;
    }

    partial void OnIsSpinning2Changed() { }
    static partial void OnIsSpinning3Changed() { }

    partial void OnModelChanged() { }
}", framework, additionalGenerators: [new StaticConstructorGenerator(), new AttachedDependencyPropertyGenerator(), new AddOwnerGenerator(), new OverrideMetadataGenerator(), new RoutedEventGenerator(), new WeakEventGenerator()]);
    }
}
