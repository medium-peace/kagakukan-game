using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class qcont : MonoBehaviour
{
    // 落下速度の初期値
    float fallSpeed = -0.1f;

    // Start is called before the first frame update
    GameObject player;
    
    void Start()
    {
        // シーンが long の場合は "player" を、shortの場合は "player2" を検索
        if (SceneManager.GetActiveScene().name == "8a lot long" || SceneManager.GetActiveScene().name == "10a few long")
        {
            this.player = GameObject.Find("player");
        }
        else if (SceneManager.GetActiveScene().name == "8a lot short" || SceneManager.GetActiveScene().name == "10a few short")
        {
            this.player = GameObject.Find("player2");
        }

        // シーンごとに落下速度を調整
        if (SceneManager.GetActiveScene().name == "10a few long" || SceneManager.GetActiveScene().name == "10a few short")
        {
            fallSpeed /= 3.0f; // 10a few longまたは10a few shortの場合、落下速度を1/3倍にする
        }
    }


    // Update is called once per frame
    void Update()
    {
        // 落下速度に応じて移動
        transform.Translate(0, fallSpeed, 0);

        if (transform.position.y < 0f)
        {
            Destroy(gameObject);
        }

        // nullチェックを追加
        if (this.player != null)
        {
            Vector2 p1 = transform.position;
            Vector2 p2 = this.player.transform.position;
            Vector2 dir = p1 - p2;
            float d = dir.magnitude;
            float r1 = 0.1f;
            float r2 = 0.2f;

            if (d < r1 + r2)
            {
                Destroy(gameObject);
            }
        }
    }
}
