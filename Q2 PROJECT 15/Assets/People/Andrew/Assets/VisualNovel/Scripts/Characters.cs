using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Setializable]
public class Characters : MonoBehaviour
{

    public string name;

    /// Root contains all images for characters in the scene, root is object
    [HideInInspector] public RectTransform root;

    public bool isMultiLayerCharacter{ get { return renderers.renderer == null;}}
   
    ///Creates a new character
    public Character (string _name)
    {
        CharacterManager cm = CharacterManager.instance;
        ///Locates the character's prefab
        GameObeject prefab = Resources.Load("Character/Character[" + _name + "]") as GameObjects;
        GameObject ob = Instantiate(prefab, cm.characterPanel);

        root = ob.GetComponent<RectTransform> ();
        name = _name;

        ///get the renderer(s)
        renderers.renderer = ob.GetComponentInChildren<RawImage>();
        if (isMultiLayerCharacter)
        {
            renderers.bodyRenderer = ob.transform.Find("bodyLayer").GetComponent<Image>();
            renderers.expressionRenderer = ob.transform.Find("expressionLayer").GetComponent<Image>();
        }
    }

    class Renderers
    {
        ///used as the only image for a single layer character
        public RawImage renderer;
    }

    Renderers renderers;

}
