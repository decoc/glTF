using System;

namespace UnityGlTF
{
    [Serializable]
    public class GlTFAnimation
    {
        public GlTFAnimationChannel[] channels;
        public GlTFAnimationSampler[] samplers;
    }
}