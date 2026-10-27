using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class move12L : MonoBehaviour
{
    public float idleTimeThreshold = 30f; // 操作がないと判定される閾値（秒）
    private float idleTimer = 0f; // 経過時間のカウンター

    // ボタンの押されるキー
    public void change_buttonL(){
         // シーンを "13slide" にロードする
            SceneManager.LoadScene("13slide");
    }
}
