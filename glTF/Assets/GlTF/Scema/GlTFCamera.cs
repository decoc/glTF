using System;

namespace UnityGlTF
{
    [Serializable]
    public class GlTFCamera
    {
        /// <summary>
        /// "Perspective(透視投影)またはOrthographic(並行投影)を指定する"
        /// </summary>
        public string type;

        public GlTFPerspective  perspective;
        public GlTFOrthographic orthographic;
    }
}