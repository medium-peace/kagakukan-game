using UnityEngine;
using UnityEngine.SceneManagement;

public class PatarnObject : MonoBehaviour
{

    public static int randomSceneIndex;
    // Start is called before the first frame update
    void Start()
    {
              // ランダムに0か1を選択
            randomSceneIndex = Random.Range(0, 2);
            Debug.Log("選択された数値: " + randomSceneIndex);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)|| Input.GetKeyDown("joystick button 0"))
        {
           
    
            // 選択されたシーンに遷移
            if (randomSceneIndex == 0)
            {
                SceneManager.LoadScene("8a lot long"); // シーンAの名前を指定
            } 
            else
            {
                SceneManager.LoadScene("8a lot short"); // シーンBの名前を指定
            }
            
        }
    }
}
