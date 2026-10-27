using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerController : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    void Start()
    {
        // VideoPlayerがアタッチされているか確認
        if (videoPlayer == null)
        {
            Debug.LogError("VideoPlayer is not attached.");
            return;
        }

        // 50%の確率で再生を制御する
        float randomValue = Random.value;
        if (randomValue < 0.5f)
        {
            // 再生
            videoPlayer.Play();
        }
        else
        {
            // 停止
            videoPlayer.Stop();
        }
    }
}
