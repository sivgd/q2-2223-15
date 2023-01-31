using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptOBJ : MonoBehaviour
{
    internal object sprite;

    [CreateAssetMenu(fileName = "ScriptOBJ", menuName = "Credit")]
    public class Image : ScriptableObject
    {
        public new string name;
        public Sprite image;
    }
}