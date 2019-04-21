using System;

namespace UnityGlTF.Schema
{
    [Serializable]
    public class GlTFAnimationChannel:GlTFProperty
    {
        public int sampler;
        public GlTfAnimationChannelTarget target;
        public GlTFAnimationSampler[]     samplers;
    }
}