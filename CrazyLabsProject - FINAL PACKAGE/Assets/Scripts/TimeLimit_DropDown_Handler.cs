using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeLimit_DropDown_Handler : MonoBehaviour
{
    public Dropdown TimeLimit;
    void Start()
    {
        TimeLimit.onValueChanged.AddListener(delegate
        {
            Paths_ValueChangedHappened(TimeLimit);
        });
    }

    void Update()
    {
        
    }

    public void Paths_ValueChangedHappened(Dropdown Sender)
    {
        InGameSettings.Settings_TimeLimit = int.Parse(TimeLimit.options[TimeLimit.value].text);
        Debug.Log(InGameSettings.Settings_TimeLimit);
    }
}
