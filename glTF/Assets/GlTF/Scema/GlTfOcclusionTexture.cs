using System;

namespace UnityGlTF.Schema
{
    [Serializable]
    public class GlTfOcclusionTexture : GlTFTextureBase
    {
        public int strength;
    }
}