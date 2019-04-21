using System;

namespace UnityGlTF.Schema
{
    /// <summary>
    /// materialに利用される
    /// </summary>
    [Serializable]
    public class GlTFTexture:GlTFChildOfRootProperty
    {
        /// <summary>
        /// 参照するImage
        /// </summary>
        public int source;

        /// <summary>
        /// Textureの折り返しとスケーリングを記述する
        /// </summary>
        public int sampler;
    }
}