using System;

namespace UnityGlTF.Schema
{
    [Serializable]
    public class GlTFAsset:GlTFProperty
    {
        public string copyright;
        public string generator;
        public string version    = "0.0";
        public string minVersion = "0.0";
    }
}