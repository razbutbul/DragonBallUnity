using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AboutActivation : MonoBehaviour
{
    public Text aboutText;
   
    public void ActivateText()
    {
        aboutText.gameObject.SetActive(true);
    }
    public void DeactivateText()
    {
        aboutText.gameObject.SetActive(false);
    }

}
