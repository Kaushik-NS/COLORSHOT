using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Paths_DropDown_Handler : MonoBehaviour
{
    public Dropdown Paths;
    void Start()
    {
        Paths.onValueChanged.AddListener(delegate
        {
            Paths_ValueChangedHappened(Paths);
        });
    }

    void Update()
    {
        
    }

    public void Paths_ValueChangedHappened(Dropdown Sender)
    {
       InGameSettings.Settings_Paths = int.Parse(Paths.options[Paths.value].text);
        Debug.Log(InGameSettings.Settings_Paths);
    }
}
