using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Credits : MonoBehaviour
{
    [SerializeField]
    private Image _credit;

    public void OnMouseDown(Image image)
    {
        _credit.sprite = image.sprite;
    }
}