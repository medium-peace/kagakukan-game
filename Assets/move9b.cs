using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class move9b : MonoBehaviour
{
    public float idleTimeThreshold = 30f; // 操作がないと判定される閾値（秒）
    private float idleTimer = 0f; // 経過時間のカウンター

    // Update is called once per frame
    void Update()
    {
        // マウスのクリックまたはジョイスティックのボタンの入力があった場合
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown("joystick button 0"))
        {
            // シーンを "3slide" にロードする
            SceneManager.LoadScene("10a few long");

            // タイマーをリセットする
            idleTimer = 0f;
        }
        else
        {
            // 操作がない場合、経過時間をカウントアップする
            idleTimer += Time.deltaTime;

            // もし経過時間が閾値を超えた場合、slide1 シーンに戻る
            if (idleTimer >= idleTimeThreshold)
            {
                SceneManager.LoadScene("1slide");

                // タイマーをリセットする
                idleTimer = 0f;
            }
        }
    }
}
