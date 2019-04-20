using System;

namespace UnityGlTF
{
    [Serializable]
    public class GlTFAnimationChannel
    {
        public int sampler;
        public GlTfAnimationChannelTarget target;
        public GlTFAnimationSampler[]     samplers;
    }
}