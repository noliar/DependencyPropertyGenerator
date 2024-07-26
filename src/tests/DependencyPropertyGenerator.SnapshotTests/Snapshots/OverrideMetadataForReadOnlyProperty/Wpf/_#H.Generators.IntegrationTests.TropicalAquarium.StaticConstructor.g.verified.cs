﻿//HintName: H.Generators.IntegrationTests.TropicalAquarium.StaticConstructor.g.cs
#nullable enable

namespace H.Generators.IntegrationTests
{
    partial class TropicalAquarium
    {
        static TropicalAquarium()
        {
            StartOfStaticConstructor();
            AquariumGraphicProperty.OverrideMetadata(
                forType: typeof(global::H.Generators.IntegrationTests.TropicalAquarium),
                typeMetadata: new global::System.Windows.FrameworkPropertyMetadata(
                    defaultValue: (global::System.Uri)new System.Uri("http://www.contoso.com/tropical-aquarium-graphic.jpg"),
                    flags: global::System.Windows.FrameworkPropertyMetadataOptions.None,
                    propertyChangedCallback: static (sender, args) =>
                    {
                        ((global::H.Generators.IntegrationTests.TropicalAquarium)sender).OnAquariumGraphicChanged();
                    },
                    coerceValueCallback: null,
                    isAnimationProhibited: false),
                key: AquariumGraphicPropertyKey);
            EndOfStaticConstructor();
        }

        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        static partial void StartOfStaticConstructor();
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        static partial void EndOfStaticConstructor();

        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        partial void OnAquariumGraphicChanged();
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        partial void OnAquariumGraphicChanged(global::System.Uri newValue);
        [global::System.CodeDom.Compiler.GeneratedCode("DependencyPropertyGenerator", "0.0.0.0")]
        partial void OnAquariumGraphicChanged(global::System.Uri oldValue, global::System.Uri newValue);
    }
}