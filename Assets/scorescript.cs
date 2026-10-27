using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scorescript : MonoBehaviour
{
    string PreviousSceneName;
    float idleTimeThreshold = 30f; // 操作がないと判定される閾値（秒）
    float idleTimer = 0f; // 経過時間のカウンター

    void Start()
    {
        if ((GameDirector.team == 1) && (GameDirector2.team == 2))
        {
            PreviousSceneName = "finish";
            GameDirector.team = 0;
            GameDirector2.team = 0;
        }
        // 前のシーン名を取得
        else if (GameDirector.team == 1)
        {
            PreviousSceneName = GameDirector.previousSceneName;
        }
        else if (GameDirector2.team == 2)
        {
            PreviousSceneName = GameDirector2.previousSceneName;
        }
    }

    void Update()
    {


        // 操作がある場合、ページを移動
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown("joystick button 0"))
        {
            string nextSceneName = GetNextScene(PreviousSceneName);
            SceneManager.LoadScene(nextSceneName);
        }
        else
        {
            // 操作がない場合、経過時間をカウントアップ
            idleTimer += Time.deltaTime;

            // 経過時間が閾値を超えた場合、1slideシーンに戻る
            if (idleTimer >= idleTimeThreshold)
            {
                SceneManager.LoadScene("1slide");

                // タイマーをリセットする
                idleTimer = 0f;
            }
        }
    }

    // 移動元のシーンに応じて次のシーンを返す関数
    string GetNextScene(string previousScene)
    {
        switch (previousScene)
        {
            case "8a lot long":
                return "9slideA";
            case "8a lot short":
                return "9slideB";
            case "finish":
                return "10afterslide";
            default:
                return "DefaultScene"; // デフォルトのシーン名（エラー時など）
        }
    }
}
