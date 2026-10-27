using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sounds : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         if (Random.value < 0.5f)
        {
            PlayBGM();
        }
    }

    void PlayBGM()
    {
        // AudioSourceコンポーネントがアタッチされているかを確認
        AudioSource audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            // AudioSourceコンポーネントがアタッチされていない場合は新しいオブジェクトに追加する
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // BGMを設定して再生
        audioSource.loop = true;
        audioSource.Play();
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }   
}
