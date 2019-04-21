using System;

namespace UnityGlTF.Schema
{
    /// <summary>
    /// BufferViewは1つのbufferを参照し，そのbufferがどのように構成されるか記述される
    /// </summary>
    [Serializable]
    public class GlTFBufferView:GlTFChildOfRootProperty
    {
        /// <summary>
        /// このインデックスのBufferを参照する
        /// </summary>
        public int buffer;

        /// <summary>
        /// バイナリデータの読み込み開始位置
        /// </summary>
        public int byteOffset;

        /// <summary>
        /// 読み込み範囲
        /// </summary>
        public int byteLength;
        public int byteStride;
        public int target;
    }
}