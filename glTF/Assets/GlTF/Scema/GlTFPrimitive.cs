using System.Collections.Generic;

namespace UnityGlTF
{
    public class GlTFPrimitive
    {
        /// <summary>
        /// POINTS, LINES, TRIANGLES
        /// </summary>
        public int mode;

        /// <summary>
        /// アクセサのインデックス
        /// </summary>
        public int indices = -1;

        /// <summary>
        /// アクセサの属性とアクセサがアクセスする対象のインデックス
        /// </summary>
        public GlTFAttribute attributes;

        /// <summary>
        /// マテリアルのインデックス
        /// </summary>
        public int material = -1;

        /// <summary>
        /// モーフのターゲットを定義する。
        /// アクセサの属性名をtargetのジオメトリ変位を含むアクセサのインデックスにマップする
        /// </summary>
        public List<Dictionary<string, int>> targets;
    }
}