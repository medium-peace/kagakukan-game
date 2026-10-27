using UnityEngine;
using TMPro;

public class YourScore : MonoBehaviour
{
    // UI Text指定用
    public TextMeshProUGUI totalPointText;
    public static int ganma;

    void Start()
    {
        // テキストオブジェクトを検索して取得
        totalPointText = GameObject.Find("TotalPointText").GetComponent<TextMeshProUGUI>();

        // ganmaの値を計算する
        ganma = CalculateGanma();

        // テキストに合計ポイントを表示
        totalPointText.text = ganma.ToString() + " point";
    }

    int CalculateGanma()
    {
        // alphaとbetaの合計を計算し、ganmaに格納
        int ganma1 = GameDirector.alpha + GameDirector2.beta;
        int ganma2 = GameDirector2.alpha + GameDirector.beta;
        
        GameDirector.alpha = -100000;
        GameDirector2.alpha = -100000;
        GameDirector.beta = -100000;
        GameDirector2.beta = -100000;

        // どちらの組み合わせが大きいか比較し、大きい方をganmaとして返す
        return Mathf.Max(ganma1, ganma2);
    }
}
