using System.Collections.Generic;

namespace UnityGlTF.Schema
{
    /// <summary>
    /// GlTFのプロパティは共通して拡張性を持つ
    /// </summary>
    public class GlTFProperty
    {
        public Dictionary<string, string> extensions = new Dictionary<string, string>();
        public Dictionary<string, string> extras     = new Dictionary<string, string>();
    }
}
