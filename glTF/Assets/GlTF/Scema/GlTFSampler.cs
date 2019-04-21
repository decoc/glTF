using System;

namespace UnityGlTF.Schema
{
    //samplerはtextureの折り返しとスケーリングを記述
    [Serializable]
    public class GlTFSampler:GlTFChildOfRootProperty
    {
        public int magFilter;
        public int minFilter;
        public int warpS;
        public int warpT;
    }
}