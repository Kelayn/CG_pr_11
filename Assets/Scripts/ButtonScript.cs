using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonScript : MonoBehaviour
{

    public GameObject gameObjectPanel;
    public GameObject gameObjectImage;
    public Sprite Newsprite;


    // Start is called before the first frame update
    public void Close()
    {   
        gameObjectPanel.SetActive(false);
        
    }

    // Update is called once per frame
    public void ChangeImage()
    {
        gameObjectImage.GetComponent<Image>().sprite = Newsprite;
    }
}
