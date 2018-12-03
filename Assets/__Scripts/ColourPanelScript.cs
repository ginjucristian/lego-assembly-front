using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourPanelScript : MonoBehaviour {

    public GameObject ColourPanel;
    public GameObject SaturationValue;
    public GameObject Hue;

    public void TogglePanel()
    {
        ColourPanel.SetActive(!ColourPanel.activeSelf);
        SaturationValue.SetActive(!SaturationValue.activeSelf);
        Hue.SetActive(!Hue.activeSelf);
    }

}
