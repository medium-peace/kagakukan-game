using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class move12R : MonoBehaviour
{
    public float idleTimeThreshold = 30f; // 操作がないと判定される閾値（秒）
    private float idleTimer = 0f; // 経過時間のカウンター

    public void change_buttonR(){
         // シーンを "13slide" にロードする
            SceneManager.LoadScene("13slide");
    }
    // Update is called once per frame
    void Update()
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
