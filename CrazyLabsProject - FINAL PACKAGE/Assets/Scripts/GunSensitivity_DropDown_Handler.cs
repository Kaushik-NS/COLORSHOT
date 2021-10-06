using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunSensitivity_DropDown_Handler : MonoBehaviour
{
    public Dropdown GunSensitivity;
    void Start()
    {
        GunSensitivity.onValueChanged.AddListener(delegate
        {
            Paths_ValueChangedHappened(GunSensitivity);
        });
    }

    void Update()
    {
        
    }

    public void Paths_ValueChangedHappened(Dropdown Sender)
    {
        InGameSettings.Settings_GunSensitivity = int.Parse(GunSensitivity.options[GunSensitivity.value].text);
        Debug.Log(InGameSettings.Settings_GunSensitivity);
    }
}
