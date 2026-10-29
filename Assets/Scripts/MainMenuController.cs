using UnityEngine;
using UnityEngine.SceneManagement;

public class UiController : MonoBehaviour
{
 
    public void GoToSceneTwo()
    {
        SceneManager.LoadScene("Playground_scene");
    }


}
