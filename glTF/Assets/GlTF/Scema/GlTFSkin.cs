using System;

namespace UnityGlTF.Schema
{

    /// <summary>
    /// glTFアセットには，頂点skinningに必要な情報を記述可能
    /// 頂点skinningを使用すると，meshの頂点が，現在の姿勢に基づいて影響を受ける
    /// </summary>
    [Serializable]
    public class GlTFSkin:GlTFChildOfRootProperty
    {
        public int inverseBingMatrices = -1;

        public int skeleton = -1;

        public int[] joints;
    }
}