using System;

namespace UnityGlTF
{
    /// <summary>
    /// 階層構造のトップで，階層化したノードを包括する
    /// </summary>
    [Serializable]
    public class GlTFScene
    {
        /// <summary>
        /// Sceneの一段下にくるノードのインデックス
        /// </summary>
        public int[] nodes;
    }
}