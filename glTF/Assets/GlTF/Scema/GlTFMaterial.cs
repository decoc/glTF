using System;

namespace UnityGlTF
{
    [Serializable]
    public class GlTFMaterial
    {
        public GlTFPbrMetallicRoughness pbrMetallicRoughness;

        public GlTFNormalTexture normalTexture;

        public GlTfOcclusionTexture occulusionTexture;

        public GlTFEmissiveTexture   emissiveTexture;

        public float[] emissiveFactor = {0,0,0,0};

        public string alphaMode;

        public double alphaCutoff = 0.5f;

        public bool doubleSided;
    }
}