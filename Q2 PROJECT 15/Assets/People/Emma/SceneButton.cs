using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneButton : MonoBehaviour
{
    public string ANI;
    public void ButtonClick()
    {
        Debug.Log("BUTTON PRESSED");
        SceneManager.LoadScene(ANI);
    }

}