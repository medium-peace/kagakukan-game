using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameDirector : MonoBehaviour
{
    GameObject timerText;
    GameObject pointText;
    float time = 20.0f;
    int point = 0;

    // 他のシーンからアクセスできるようにpublic staticで宣言
    public static int alpha;
    public static int beta;

    void Start()
    {
        this.timerText = GameObject.Find("Time");
        this.pointText = GameObject.Find("Point");
        previousSceneName = SceneManager.GetActiveScene().name;
        team = 1;
    }

    public static string previousSceneName;
    public static int team;

    public void Getcoin()
    {
        // シーン名に応じてポイントの加算を変更
        if (SceneManager.GetActiveScene().name == "8a lot long")
        {
            this.point += 1000;
        }
        else if (SceneManager.GetActiveScene().name == "10a few long")
        {
            this.point += 2000;
        }
    }

    public void Getarrow()
    {
        // シーン名に応じてポイントの減算を変更
        if (SceneManager.GetActiveScene().name == "8a lot long")
        {
            this.point -= 500;
        }
        else if (SceneManager.GetActiveScene().name == "10a few long")
        {
            this.point -= 1000;
        }
    }

    void Update()
    {
        this.time -= Time.deltaTime;
        this.timerText.GetComponent<TextMeshProUGUI>().text = this.time.ToString("F1");
        this.pointText.GetComponent<TextMeshProUGUI>().text = this.point.ToString() + " point";

        // 時間が0以下になったらシーンを切り替える
        if (this.time <= 0)
        {
            // ポイントの値に応じてシーンを切り替える
            if (this.point >= 10000)
            {
                SceneManager.LoadScene("best");
            }
            else if (this.point >= 2000 && this.point < 10000)
            {
                SceneManager.LoadScene("normal");
            }
            else if (this.point < 2000)
            {
                SceneManager.LoadScene("bad");
            }
        }

        // 8a lot longのシーンであればalphaにポイントの結果を保存
        if (SceneManager.GetActiveScene().name == "8a lot long")
        {
            alpha = this.point;
        }
        // 10a few longのシーンであればbetaにポイントの結果を保存
        else if (SceneManager.GetActiveScene().name == "10a few long")
        {
            beta = this.point;
        }
    }
}
