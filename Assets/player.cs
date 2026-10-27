using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private GameObject director;
    private AudioSource audioSource;

    public float minX = -7.3f;
    public float maxX = 7.3f;
    public AudioClip arrowSE;
    public AudioClip coinSE;

    private float speedMultiplier = 1.0f; // 初期速度倍率

    private void Start()
    {
        Application.targetFrameRate = 60;
        director = GameObject.Find("GameDirector");
        audioSource = GetComponent<AudioSource>();

        // シーンごとに速度倍率を設定
        string sceneName = SceneManager.GetActiveScene().name;
        if (sceneName == "8a lot long")
        {
            speedMultiplier = 1.0f; // 8a lot longの場合、速度倍率をそのままにする
        }
        else if (sceneName == "10a few long")
        {
            speedMultiplier = 1.0f / 3.0f; // 10a few longの場合、速度倍率を1/3にする
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("coin"))
        {
            audioSource.PlayOneShot(coinSE);
            director.GetComponent<GameDirector>().Getcoin();
        }
        else
        {
            audioSource.PlayOneShot(arrowSE);
            director.GetComponent<GameDirector>().Getarrow();
        }
        Destroy(other.gameObject);
    }

    private void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");
        Move(moveInput * 10.0f * speedMultiplier * Time.deltaTime);
    }

    private void Move(float direction)
    {
        Vector3 newPosition = transform.position + new Vector3(direction, 0, 0);
        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);
        transform.position = newPosition;
    }
}
