namespace UnityGlTF
{
    /// <summary>
    /// レンダリングのmodeが設定でき，POINTS，LINES，TRIANGLESとしてレンダリングする
    /// 必要があるかどうかを示す定数を入れる 
    /// </summary>
    public class GlTFAttribute
    {
        public int POSITION   = -1;
        public int NORMAL     = -1;
        public int TANGENT    = -1;
        public int TEXCOORD_0 = -1;
        public int TEXCOORD_1 = -1;
        public int TEXCOORD_2 = -1;
        public int TEXCOORD_3 = -1;
        public int COLOR_0    = -1;
        public int JOINTS_0   = -1;
        public int WEIGHTS_0  = -1;
    }
}