using System;

namespace UnityGlTF.Schema
{
    /// <summary>
    /// 透視投影の設定
    /// </summary>
    [Serializable]
    public class GlTFPerspective:GlTFProperty
    {
        public float asceptRatio;
        public float yFov;
        public float zFar;
        public float zNear;
    }
}