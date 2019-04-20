using System;

namespace UnityGlTF
{
    /// <summary>
    /// materialに利用される
    /// </summary>
    [Serializable]
    public class GlTFTexture
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