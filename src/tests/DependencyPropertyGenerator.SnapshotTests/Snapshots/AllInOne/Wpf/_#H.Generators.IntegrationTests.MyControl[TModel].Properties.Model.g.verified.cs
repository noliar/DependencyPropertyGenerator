//HintName: H.Generators.IntegrationTests.MyControl[TModel].Properties.Model.g.cs

#nullable enable

namespace H.Generators.IntegrationTests
{
    partial class MyControl<TModel>
    {
        /// <summary>
        /// Identifies the <see cref="Model"/> dependency property.<br/>
        /// Default value: default(TModel)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        public static readonly global::System.Windows.DependencyProperty ModelProperty =
            global::System.Windows.DependencyProperty.Register(
                name: "Model",
                propertyType: typeof(TModel),
                ownerType: typeof(global::H.Generators.IntegrationTests.MyControl<TModel>),
                typeMetadata: new global::System.Windows.FrameworkPropertyMetadata(
                    defaultValue: default(TModel),
                    flags: global::System.Windows.FrameworkPropertyMetadataOptions.None,
                    propertyChangedCallback: static (sender, args) =>
                    {
                        ((global::H.Generators.IntegrationTests.MyControl<TModel>)sender).OnModelChanged();
                    },
                    coerceValueCallback: null,
                    isAnimationProhibited: false),
                validateValueCallback: null);

        /// <summary>
        /// Default value: default(TModel)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        public TModel? Model
        {
            get => (TModel?)GetValue(ModelProperty);
            set => SetValue(ModelProperty, value);
        }

        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        partial void OnModelChanged();
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        partial void OnModelChanged(TModel? newValue);
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        partial void OnModelChanged(TModel? oldValue, TModel? newValue);
    }
}