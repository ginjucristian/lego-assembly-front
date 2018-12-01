using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPanelScript : MonoBehaviour {


    public GameObject ColorPanel;
    public GameObject SaturationValue;
    public GameObject Hue;

    public void TogglePanel()
    {
        if(ColorPanel != null)
        {
            bool isActive = ColorPanel.activeSelf;
            ColorPanel.SetActive(!isActive);
            SaturationValue.SetActive(!isActive);
            Hue.SetActive(!isActive);
        }
    }
}
