using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneswicher : MonoBehaviour
{

    public string sceneName;

    // Start is called before the first frame update

    public void changeScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
