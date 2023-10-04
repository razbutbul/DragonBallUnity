using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelActivation : MonoBehaviour
{
    public GameObject panel;

    public void ActivatePanel()
    {
        panel.SetActive(true);
    }

    // Method to deactivate the panel.
    public void DeactivatePanel()
    {
        panel.SetActive(false);
    }
}
