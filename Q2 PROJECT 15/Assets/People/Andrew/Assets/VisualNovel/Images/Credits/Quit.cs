using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    public string gameScene;
    
    // Update is called once per frame
    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
                SceneManager.LoadScene(gameScene, LoadSceneMode.Single);
            
        }
    }
}
