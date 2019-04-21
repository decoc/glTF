using System;

namespace UnityGlTF.Schema
{
    [Serializable]
    public class GlTFTextureBase:GlTFProperty
    {
        public int index;
        public int texCoord;
    }
}