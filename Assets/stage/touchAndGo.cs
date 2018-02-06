using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class touchAndGo : MonoBehaviour {

    public GameObject charaterSoul;
    public Transform charaterTransform;
    public Transform thisTrans;
    public string gotowhere;

    void Awake() {
        charaterTransform = charaterSoul.GetComponent<Transform>();
        thisTrans = GetComponent<Transform>();
    }
    void OnMouseUp() {
        if((thisTrans.position.x + 1 ) > charaterTransform.position.x && (thisTrans.position.x - 1 ) < charaterTransform.position.x) {
            if((thisTrans.position.y + 0.6 ) > charaterTransform.position.y && (thisTrans.position.y - 0.6 ) < charaterTransform.position.y) {
                StartCoroutine(LoadYourAsyncScene());
            }
        }
    }

    IEnumerator LoadYourAsyncScene()
    {
        // The Application loads the Scene in the background at the same time as the current Scene.
        //This is particularly good for creating loading screens. You could also load the scene by build //number.
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(gotowhere);

        //等待載入
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
