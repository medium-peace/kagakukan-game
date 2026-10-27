using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject coinPrefab;
    public GameObject arrowPrefab;

    private float span = 0.1f; // 初期値

    private float spanBig = 0.1f; // 8a lot longや10a few longシーン用のspan
    private float spanSmall = 0.3f; // 8a lot shortや10a few shortシーン用のspan

    private float delta = 0;
    private int ratio = 7;

    private void Start()
    {
        // シーンごとに span の値を設定
        string sceneName = SceneManager.GetActiveScene().name;
        if (sceneName == "8a lot long" || sceneName == "8a few short")
        {
            span = spanBig;
        }
        else if (sceneName == "10a few long" || sceneName == "10a few short")
        {
            span = spanSmall;
        }
    }

    private void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject item;
            int dice = Random.Range(1, 11);
            if (dice <= this.ratio)
            {
                item = Instantiate(arrowPrefab);
            }
            else
            {
                item = Instantiate(coinPrefab);
            }

            int px = Random.Range(-7, 8);
            item.transform.position = new Vector3(px, 8.5f, 0);
        }
    }
}
