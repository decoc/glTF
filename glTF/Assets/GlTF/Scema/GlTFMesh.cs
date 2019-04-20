using System;

namespace UnityGlTF
{

    // <summary>
    // 複数のprimitiveが記述できる
    // primitiveには，meshのレンダリングに必要なジオメトリ情報を参照するインデックスを記述
    // </summary>
    [Serializable]
    public class GlTFMesh
    {
        public GlTFPrimitive[] primitives;

        /// <summary>
        /// 各モーフのtargetの最終レンダリング状態へ活用される
        /// </summary>
        public float[] weights;
    }
}