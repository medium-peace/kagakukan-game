using UnityEngine;
using UnityEngine.Video;

public class balance : MonoBehaviour
{
    public VideoClip[] videoClips; // 再生する動画クリップの配列
    private VideoPlayer videoPlayer;

    void Start()
    {
        // 2分の1の確率で動画を再生する
        if (Random.Range(0, 2) == 0)
        {
            // ランダムなインデックスを取得して、それに対応する動画を再生する
            int randomIndex = Random.Range(0, videoClips.Length);
            PlayVideo(videoClips[randomIndex]);
        }
    }

    // 指定された動画を再生する関数
    void PlayVideo(VideoClip videoClip)
    {
        GameObject videoObject = new GameObject("Video Player");
        videoObject.transform.position = Camera.main.transform.position + Camera.main.transform.forward * (Camera.main.farClipPlane - 1f);
        videoObject.transform.LookAt(Camera.main.transform);
        videoPlayer = videoObject.AddComponent<VideoPlayer>();
        videoPlayer.playOnAwake = true;
        videoPlayer.isLooping = false;
         videoPlayer.renderMode = VideoRenderMode.CameraFarPlane;

        videoPlayer.clip = videoClip;
        videoPlayer.Play();
    }
}