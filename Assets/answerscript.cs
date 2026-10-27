using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class answerscript : MonoBehaviour
{
    // UI Text指定用
    public Text TextAnswer;

    // Start is called before the first frame update
    void Start()
    {
        // TextAnswerがnullでないことを確認
        if (TextAnswer != null)
        {
            // PatarnObjectクラスからランダムな数値を取得
            int randomNumber = PatarnObject.randomSceneIndex;

            // 数値に基づいてグループを判定し、結果を取得
            string result = DetermineGroup(randomNumber);

            // テキストに結果を表示
            TextAnswer.text = result;

            // デバッグログに結果を表示（オプション）
            Debug.Log(result);
        }
        else
        {
            Debug.LogError("TextAnswerが割り当てられていません。");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 数値に基づいてグループを判定するメソッド
    string DetermineGroup(int number)
    {
        // 与えられた数値が0の場合、グループ①を返す
        if (number == 0)
        {
            return "①";
        }
        // 与えられた数値が1の場合、グループ②を返す
        else if (number == 1)
        {
            return "②";
        }
        // それ以外の場合、該当するグループがないことを示すメッセージを返す
        else
        {
            return "該当するグループがありません。";
        }
    }
}
