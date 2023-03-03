using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string SceneToLoad;
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        Debug.Log("button");
        SceneManager.LoadScene(SceneToLoad);
    }

}