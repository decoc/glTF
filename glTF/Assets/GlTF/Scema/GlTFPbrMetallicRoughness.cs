using System;

namespace UnityGlTF
{
    [Serializable]
    public class GlTFPbrMetallicRoughness
    {
        public GlTFBaseColorTexture baseColorTexture;

        public float[] baseColorFactor = {1, 1, 1, 1};

        public double metallicFactor = 1;

        public double roughnessFactor = 1;

        public GlTFMetallicRoughnessTexture metallicRoughnessTexture;
    }
}