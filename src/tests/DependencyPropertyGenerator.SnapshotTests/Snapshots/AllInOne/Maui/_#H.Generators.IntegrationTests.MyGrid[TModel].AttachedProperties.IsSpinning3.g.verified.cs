//HintName: H.Generators.IntegrationTests.MyGrid[TModel].AttachedProperties.IsSpinning3.g.cs

#nullable enable

namespace H.Generators.IntegrationTests
{
    partial class MyGrid<TModel>
    {
        /// <summary>
        /// Identifies the IsSpinning3 dependency property.<br/>
        /// Default value: default(bool)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        public static readonly global::Microsoft.Maui.Controls.BindableProperty IsSpinning3Property =
            global::Microsoft.Maui.Controls.BindableProperty.CreateAttached(
                propertyName: "IsSpinning3",
                returnType: typeof(bool),
                declaringType: typeof(global::H.Generators.IntegrationTests.MyGrid<TModel>),
                defaultValue: default(bool),
                defaultBindingMode: global::Microsoft.Maui.Controls.BindingMode.OneWay,
                validateValue: null,
                propertyChanged: static (sender, oldValue, newValue) =>
                {
                    OnIsSpinning3Changed();
                },
                propertyChanging: null,
                coerceValue: null,
                defaultValueCreator: null);

        /// <summary>
        /// Default value: default(bool)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        public static void SetIsSpinning3(global::Microsoft.Maui.Controls.BindableObject element, bool value)
        {
            element = element ?? throw new global::System.ArgumentNullException(nameof(element));

            element.SetValue(IsSpinning3Property, value);
        }

        /// <summary>
        /// Default value: default(bool)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
        public static bool GetIsSpinning3(global::Microsoft.Maui.Controls.BindableObject element)
        {
            element = element ?? throw new global::System.ArgumentNullException(nameof(element));

            return (bool)element.GetValue(IsSpinning3Property);
        }

        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        static partial void OnIsSpinning3Changed();
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        static partial void OnIsSpinning3Changed(global::Microsoft.Maui.Controls.VisualElement visualElement);
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        static partial void OnIsSpinning3Changed(global::Microsoft.Maui.Controls.VisualElement visualElement, bool newValue);
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        static partial void OnIsSpinning3Changed(global::Microsoft.Maui.Controls.VisualElement visualElement, bool oldValue, bool newValue);
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        static partial void OnIsSpinning3Changing();
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        static partial void OnIsSpinning3Changing(global::Microsoft.Maui.Controls.VisualElement visualElement);
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        static partial void OnIsSpinning3Changing(global::Microsoft.Maui.Controls.VisualElement visualElement, bool newValue);
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        static partial void OnIsSpinning3Changing(global::Microsoft.Maui.Controls.VisualElement visualElement, bool oldValue, bool newValue);
    }
}