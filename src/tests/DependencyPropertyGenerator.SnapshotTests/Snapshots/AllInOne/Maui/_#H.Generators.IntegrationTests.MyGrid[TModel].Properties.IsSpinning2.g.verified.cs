﻿//HintName: H.Generators.IntegrationTests.MyGrid[TModel].Properties.IsSpinning2.g.cs

#nullable enable

namespace H.Generators.IntegrationTests
{
    partial class MyGrid<TModel>
    {
        /// <summary>
        /// Identifies the <see cref="IsSpinning2"/> dependency property.<br/>
        /// Default value: default(bool)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        public static readonly global::Microsoft.Maui.Controls.BindableProperty IsSpinning2Property =
            global::Microsoft.Maui.Controls.BindableProperty.Create(
                propertyName: "IsSpinning2",
                returnType: typeof(bool),
                declaringType: typeof(global::H.Generators.IntegrationTests.MyGrid<TModel>),
                defaultValue: default(bool),
                defaultBindingMode: global::Microsoft.Maui.Controls.BindingMode.OneWay,
                validateValue: null,
                propertyChanged: static (sender, oldValue, newValue) =>
                {
                    ((global::H.Generators.IntegrationTests.MyGrid<TModel>)sender).OnIsSpinning2Changed();
                },
                propertyChanging: null,
                coerceValue: null,
                defaultValueCreator: null);

        /// <summary>
        /// Default value: default(bool)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        public bool IsSpinning2
        {
            get => (bool)GetValue(IsSpinning2Property);
            set => SetValue(IsSpinning2Property, value);
        }

        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        partial void OnIsSpinning2Changed();
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        partial void OnIsSpinning2Changed(bool newValue);
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        partial void OnIsSpinning2Changed(bool oldValue, bool newValue);
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        partial void OnIsSpinning2Changing();
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        partial void OnIsSpinning2Changing(bool newValue);
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        partial void OnIsSpinning2Changing(bool oldValue, bool newValue);
    }
}