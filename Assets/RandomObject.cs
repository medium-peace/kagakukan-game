using UnityEngine;

public class RandomObject : MonoBehaviour
{
    void Start()
    {
        // 1または2のランダムな値を生成
        int a = Random.Range(1, 3);
        int b = Random.Range(1, 3);
        int c = Random.Range(1, 3);

        // aが1の場合、Soundスクリプトを起動
       /*if (a == 1)
        {
            //Debug.Log("aが1なのでsoundスクリプトを起動します。");
            gameObject.AddComponent<sound>();
        }
    */
        // bが1の場合、Balanceスクリプトを起動
        /*if (b == 1)
        {
            //Debug.Log("bが1なのでbalanceスクリプトを起動します。");
            gameObject.AddComponent<balance>();
        }*/

        // cが1の場合、Vibeスクリプトを起動
        //if (c == 1)
        //{
            //Debug.Log("cが1なのでvibeスクリプトを起動します。");
          //  gameObject.AddComponent<vibe>();
        //}
    }
}
