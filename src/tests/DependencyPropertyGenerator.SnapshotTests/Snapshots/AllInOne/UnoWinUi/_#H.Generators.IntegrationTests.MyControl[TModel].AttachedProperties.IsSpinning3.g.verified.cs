//HintName: H.Generators.IntegrationTests.MyControl[TModel].AttachedProperties.IsSpinning3.g.cs

#nullable enable

namespace H.Generators.IntegrationTests
{
    partial class MyControl<TModel>
    {
        /// <summary>
        /// Identifies the IsSpinning3 dependency property.<br/>
        /// Default value: default(bool)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        public static readonly global::Microsoft.UI.Xaml.DependencyProperty IsSpinning3Property =
            global::Microsoft.UI.Xaml.DependencyProperty.RegisterAttached(
                name: "IsSpinning3",
                propertyType: typeof(bool),
                ownerType: typeof(global::H.Generators.IntegrationTests.MyControl<TModel>),
                new global::Microsoft.UI.Xaml.PropertyMetadata(
                    defaultValue: default(bool),
                    propertyChangedCallback: static (sender, args) =>
                    {
                        OnIsSpinning3Changed();
                    }));

        /// <summary>
        /// Default value: default(bool)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        public static void SetIsSpinning3(global::Microsoft.UI.Xaml.DependencyObject element, bool value)
        {
            element = element ?? throw new global::System.ArgumentNullException(nameof(element));

            element.SetValue(IsSpinning3Property, value);
        }

        /// <summary>
        /// Default value: default(bool)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        public static bool GetIsSpinning3(global::Microsoft.UI.Xaml.DependencyObject element)
        {
            element = element ?? throw new global::System.ArgumentNullException(nameof(element));

            return (bool)element.GetValue(IsSpinning3Property);
        }

        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        static partial void OnIsSpinning3Changed();
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        static partial void OnIsSpinning3Changed(global::Microsoft.UI.Xaml.FrameworkElement frameworkElement);
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        static partial void OnIsSpinning3Changed(global::Microsoft.UI.Xaml.FrameworkElement frameworkElement, bool newValue);
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        static partial void OnIsSpinning3Changed(global::Microsoft.UI.Xaml.FrameworkElement frameworkElement, bool oldValue, bool newValue);
    }
}