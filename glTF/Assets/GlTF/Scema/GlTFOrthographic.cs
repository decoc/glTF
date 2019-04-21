using System;

namespace UnityGlTF.Schema
{
    /// <summary>
    /// 並行投影の設定
    /// </summary>
    [Serializable]
    public class GlTFOrthographic
    {
        public float xMag;
        public float yMag;
        public float zFar;
        public float zNear;
    }
}