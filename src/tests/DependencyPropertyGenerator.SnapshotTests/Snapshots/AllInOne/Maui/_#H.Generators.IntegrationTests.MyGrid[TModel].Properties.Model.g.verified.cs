//HintName: H.Generators.IntegrationTests.MyGrid[TModel].Properties.Model.g.cs

#nullable enable

namespace H.Generators.IntegrationTests
{
    partial class MyGrid<TModel>
    {
        /// <summary>
        /// Identifies the <see cref="Model"/> dependency property.<br/>
        /// Default value: default(TModel)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        public static readonly global::Microsoft.Maui.Controls.BindableProperty ModelProperty =
            global::Microsoft.Maui.Controls.BindableProperty.Create(
                propertyName: "Model",
                returnType: typeof(TModel),
                declaringType: typeof(global::H.Generators.IntegrationTests.MyGrid<TModel>),
                defaultValue: default(TModel),
                defaultBindingMode: global::Microsoft.Maui.Controls.BindingMode.OneWay,
                validateValue: null,
                propertyChanged: static (sender, oldValue, newValue) =>
                {
                    ((global::H.Generators.IntegrationTests.MyGrid<TModel>)sender).OnModelChanged();
                },
                propertyChanging: null,
                coerceValue: null,
                defaultValueCreator: null);

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
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        partial void OnModelChanging();
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        partial void OnModelChanging(TModel? newValue);
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        partial void OnModelChanging(TModel? oldValue, TModel? newValue);
    }
}