using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class gamestart : MonoBehaviour {
    public string Data;
    public GameObject DataLoad;
    // public GameLoad gameload;
    void Start()
    {
        StartCoroutine(LoadYourAsyncScene());
    }

    IEnumerator LoadYourAsyncScene()
    {
        // The Application loads the Scene in the background at the same time as the current Scene.
        //This is particularly good for creating loading screens. You could also load the scene by build //number.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("classroom");
        //等待載入
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
    IEnumerator LoadYourAsyncScene2()
    {
        // The Application loads the Scene in the background at the same time as the current Scene.
        //This is particularly good for creating loading screens. You could also load the scene by build //number.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("selectmenu");

        //等待載入
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
