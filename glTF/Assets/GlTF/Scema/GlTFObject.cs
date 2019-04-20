using System;

namespace UnityGlTF
{
    /// <summary>
    /// glTFの基本部分は，3Dモデルを含むシーンの構造や構成を記述するJSONファイル
    /// 以下はglTFを構成するトップレベルの要素
    /// </summary>
    [Serializable]
    public class GlTFObject
    {
        /// <summary>
        /// アセット情報
        /// </summary>
        public GlTFAsset asset;

        public GlTFScene[]      scenes;
        public GlTFNode[]       nodes;

        // シーンの視点設定
        public GlTFCamera[]     cameras;

        // 3Dオブジェクトのジオメトリ情報
        public GlTFMesh[]       meshes;

        // 情報参照と情報レイアウト情報
        public GlTFBuffer[]     buffers;
        public GlTFBufferView[] bufferViews;
        public GlTFAccessor[]   accessors;

        // オブジェクトのレンダリング方法の定義
        public GlTFMaterial[]   materials;

        // オブジェクト表面の外観
        public GlTFTexture[]    textures;
        public GlTFImage[]      images;
        public GlTFSampler[]    samplers;

        // 頂点スキニングに関する情報
        public GlTFSkin[]       skins;

        // 時系列変化に関する情報
        public GlTFAnimation[]  animations;

        public string[] extentionUsed;
        public string[] extentionRequired;
    }
}