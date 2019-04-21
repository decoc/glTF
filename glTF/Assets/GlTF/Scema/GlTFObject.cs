using System;

namespace UnityGlTF.Schema
{
    /// <summary>
    /// glTFの基本部分は，3Dモデルを含むシーンの構造や構成を記述するJSONファイル
    /// 以下はglTFを構成するトップレベルの要素
    /// </summary>
    [Serializable]
    public class GlTFObject:GlTFProperty
    {
        /// <summary>
        /// アセット情報
        /// </summary>
        public GlTFAsset asset;

        public GlTFScene[] scenes;
        public GlTFNode[] nodes;

        /// <summary>
        /// シーンの視点設定
        /// </summary>
        public GlTFCamera[] cameras;

        /// <summary>
        /// 3Dオブジェクトのジオメトリ情報
        /// </summary>
        public GlTFMesh[] meshes;

        public GlTFBuffer[] buffers;
        public GlTFBufferView[] bufferViews;
        public GlTFAccessor[] accessors;

        /// <summary>
        /// オブジェクトのレンダリング方法の定義
        /// </summary>
        public GlTFMaterial[] materials;

        /// <summary>
        /// テクスチャの配列
        /// </summary>
        public GlTFTexture[] textures;

        /// <summary>
        /// イメージの配列
        /// </summary>
        public GlTFImage[] images;

        /// <summary>
        /// サンプラーの配列。サンプラーにはテクスチャフィルタリング及びラッピングモードのプロパティが含まれている
        /// </summary>
        public GlTFSampler[] samplers;

        /// <summary>
        /// 頂点スキニングに関する情報
        /// </summary>
        public GlTFSkin[] skins;

        /// <summary>
        /// 時系列変化に関する情報
        /// </summary>
        public GlTFAnimation[] animations;

        /// <summary>
        /// アセット内で使われている拡張名
        /// </summary>
        public string[] extensionUsed;

        /// <summary>
        /// アセットをロードするために必要な拡張名
        /// </summary>
        public string[] extensionRequired;
    }
}