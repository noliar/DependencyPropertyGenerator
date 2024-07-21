﻿//HintName: H.Generators.IntegrationTests.MyControl[TModel].AddOwner.Background.g.cs

#nullable enable

namespace H.Generators.IntegrationTests
{
    partial class MyControl<TModel>
    {
        /// <summary>
        /// Identifies the <see cref="Background"/> dependency property.<br/>
        /// Default value: default(Brush)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        public static readonly global::System.Windows.DependencyProperty BackgroundProperty =
            global::System.Windows.Controls.Border.BackgroundProperty.AddOwner(
                ownerType: typeof(global::H.Generators.IntegrationTests.MyControl<TModel>),
                null);

        /// <summary>
        /// Default value: default(Brush)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        public global::System.Windows.Media.Brush? Background
        {
            get => (global::System.Windows.Media.Brush?)GetValue(BackgroundProperty);
            set => SetValue(BackgroundProperty, value);
        }

        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        partial void OnBackgroundChanged();
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        partial void OnBackgroundChanged(global::System.Windows.Media.Brush? newValue);
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        partial void OnBackgroundChanged(global::System.Windows.Media.Brush? oldValue, global::System.Windows.Media.Brush? newValue);
    }
}