using System;

namespace UnityGlTF.Schema
{
    //Textureに使用される画像情報を定義する
    //画像ファイルの場所である，URIか，bufferViewに格納されている
    //画像情報の型を示す
    //MIME Typeへの参照により定義される
    [Serializable]
    public class GlTFImage:GlTFChildOfRootProperty
    {
        public string uri;
        public int bufferView;
        public string mimeType;
    }
}