using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gotoselect : MonoBehaviour {
    // void OnMouseDown() {
    //     Debug.Log("123");
    // }

    void OnMouseUp() {
        StartCoroutine(LoadYourAsyncScene());
    }

    IEnumerator LoadYourAsyncScene()
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
