using System;

namespace UnityGlTF
{
    /// <summary>
    /// bufferviewで定義されるbuffer情報の具体的な型や構成が記述される
    /// </summary>
    [Serializable]
    public class GlTFAccessor
    {
        public int bufferView;

        /// <summary>
        /// bufferViewの開始位置を示す
        /// </summary>
        public int    byteOffset;

        /// <summary>
        /// VEC2などのデータの種類
        /// </summary>
        public string type;

        /// <summary>
        /// Floatなどの型情報
        /// </summary>
        public int    componentType;

        /// <summary>
        /// 格納されている数
        /// </summary>
        public int    count;

        //全ての値の範囲はmin, max特性で設定する
        public float[] max;
        public float[] min;
    }
}