namespace UnityGlTF.Schema
{
    public class GlTfAnimationChannelTarget:GlTFProperty
    {
        public int node = -1;
        public GlTFAnimationChannelPath path;
    }
}