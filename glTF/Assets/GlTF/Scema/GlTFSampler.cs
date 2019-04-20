using System;

namespace UnityGlTF
{
    //samplerはtextureの折り返しとスケーリングを記述
    [Serializable]
    public class GlTFSampler
    {
        public int magFilter;
        public int minFilter;
        public int warpS;
        public int warpT;
    }
}