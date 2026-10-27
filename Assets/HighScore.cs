using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{
    // 静的変数としてGanmaを定義
    public static int Ganma;
    // MaxPointTextオブジェクトのTextMeshProUGUIを格納する変数
    public TextMeshProUGUI maxPointText;

    void Start()
    {
        // Ganmaの初期値を設定
        // Ganma = 0;

        // MaxPointTextオブジェクトを検索してTextMeshProUGUIを取得
        maxPointText = GameObject.Find("MaxPointText").GetComponent<TextMeshProUGUI>();

        // 初期値を表示
        maxPointText.text = Ganma.ToString() + " point";
    }

    void Update()
    {
        // Ganmaがganmaよりも小さい場合、Ganmaを更新し、MaxPointTextを更新する
        if (YourScore.ganma > Ganma)
        {
            Ganma = YourScore.ganma;
            maxPointText.text = Ganma.ToString() + " point!!";
            Debug.Log("New high score: " + Ganma);
        }
    }
}
