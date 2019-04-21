using System;

namespace UnityGlTF.Schema
{
    [Serializable]
    public class GlTFAnimation:GlTFChildOfRootProperty
    {
        public GlTFAnimationChannel[] channels;
        public GlTFAnimationSampler[] samplers;
    }
}