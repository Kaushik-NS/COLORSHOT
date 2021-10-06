using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallSpeed_DropDown_Handler : MonoBehaviour
{
    public Dropdown BallSpeed;
    void Start()
    {
        BallSpeed.onValueChanged.AddListener(delegate
        {
            Paths_ValueChangedHappened(BallSpeed);
        });
    }

    void Update()
    {
        
    }

    public void Paths_ValueChangedHappened(Dropdown Sender)
    {
        InGameSettings.Settings_BallSpeed = float.Parse(BallSpeed.options[BallSpeed.value].text);
        Debug.Log(InGameSettings.Settings_BallSpeed);
    }
}
