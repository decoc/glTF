using System;

namespace UnityGlTF.Schema
{
    /// <summary>
    /// シーンを構成する要素
    /// </summary>
    [Serializable]
    public class GlTFNode:GlTFChildOfRootProperty

    {
    /// <summary>
    /// childrenのインデックスを記述する
    /// これにより簡易的なsceneの階層構造を記述できる
    /// </summary>
    public int[] children;

    // ローカル変換を記述できる。

    /// <summary>
    /// 列優先のmatrixもしくはT,R,Sを利用する 
    /// </summary>
    public bool useTRS = false;

    public double[] matrix =
    {
        1, 0, 0, 0,
        0, 1, 0, 0,
        0, 0, 1, 0,
        0, 0, 0, 0
    };

    // ローカル変換行列はM = T * R *Sで表される
    // T,R,Sはtranslation, rotation, scaleから作られるmatrix
    // ノードのグローバル変換は，各nodeへのパス上の全てのローカル変換の積で求められる
    public float[] translation = {0f, 0f, 0f};
    public float[] rotation = {0f, 0f, 0f, 1f};
    public float[] scale = {1f, 1f, 1f};

    // 各ノードはmesh配列またはcamera配列を指すインデックスにより，
    // meshとcameraを参照する
    public int mesh = -1;
    public int camera = -1;

    // ノードは頂点スキニングにも使用される
    // ノード階層はアニメーション化されたキャラクターの骨格を定義できる
    public int skin = -1;
    public double weights;
    }
}