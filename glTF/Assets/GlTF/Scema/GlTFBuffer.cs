using System;

namespace UnityGlTF
{
    /// <summary>
    /// model, animation, およびskinningのジオメトリに使用される
    /// 情報が記載されている
    /// </summary>
    [Serializable]
    public class GlTFBuffer
    {
        /// <summary>
        /// URIを使用し，バイナリ情報ファイルを参照する
        /// </summary>
        public string uri;

        /// <summary>
        /// バイナリ情報1ブロックの長さ
        /// </summary>
        public uint   byteLength;
    }
}