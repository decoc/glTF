using System;

namespace UnityGlTF.Schema
{
    /// <summary>
    /// model, animation, およびskinningのジオメトリに使用される
    /// 情報が記載されている
    /// </summary>
    [Serializable]
    public class GlTFBuffer:GlTFChildOfRootProperty
    {
        /// <summary>
        /// URIを使用し，バイナリ情報ファイルを参照する
        /// </summary>
        public string Uri;

        /// <summary>
        /// バイナリ情報1ブロックの長さ
        /// </summary>
        public uint ByteLength;
    }
}