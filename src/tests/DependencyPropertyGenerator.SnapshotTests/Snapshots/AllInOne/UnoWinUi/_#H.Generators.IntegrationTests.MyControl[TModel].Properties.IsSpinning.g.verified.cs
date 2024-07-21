﻿//HintName: H.Generators.IntegrationTests.MyControl[TModel].Properties.IsSpinning.g.cs

#nullable enable

namespace H.Generators.IntegrationTests
{
    partial class MyControl<TModel>
    {
        /// <summary>
        /// Identifies the <see cref="IsSpinning"/> dependency property.<br/>
        /// Default value: true
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        public static readonly global::Microsoft.UI.Xaml.DependencyProperty IsSpinningProperty =
            global::Microsoft.UI.Xaml.DependencyProperty.Register(
                name: "IsSpinning",
                propertyType: typeof(bool),
                ownerType: typeof(global::H.Generators.IntegrationTests.MyControl<TModel>),
                typeMetadata: new global::Microsoft.UI.Xaml.PropertyMetadata(
                    defaultValue: (bool)true,
                    propertyChangedCallback: static (sender, args) =>
                    {
                        ((global::H.Generators.IntegrationTests.MyControl<TModel>)sender).OnIsSpinningChanged(
                            (bool)args.OldValue,
                            (bool)args.NewValue);
                    }));

        /// <summary>
        /// Description<br/>
        /// Default value: true
        /// </summary>
        [global::System.ComponentModel.Category("Category")]
        [global::System.ComponentModel.Description("Description")]
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        public bool IsSpinning
        {
            get => (bool)GetValue(IsSpinningProperty);
            set => SetValue(IsSpinningProperty, value);
        }

        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        partial void OnIsSpinningChanged();
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        partial void OnIsSpinningChanged(bool newValue);
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        partial void OnIsSpinningChanged(bool oldValue, bool newValue);
    }
}