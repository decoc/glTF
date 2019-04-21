using System;

namespace UnityGlTF.Schema
{
    [Serializable]
    public class GlTFCamera:GlTFChildOfRootProperty
    {
        /// <summary>
        /// "Perspective(透視投影)またはOrthographic(並行投影)を指定する"
        /// </summary>
        public string type;

        /// <summary>
        /// 透視投影の設定
        /// </summary>
        public GlTFPerspective  perspective;

        /// <summary>
        /// 並行投影の設定
        /// </summary>
        public GlTFOrthographic orthographic;
    }
}