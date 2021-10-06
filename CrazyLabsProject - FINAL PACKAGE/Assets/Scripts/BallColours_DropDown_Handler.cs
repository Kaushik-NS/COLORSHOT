using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallColours_DropDown_Handler : MonoBehaviour
{
    public Dropdown BallColours;
    void Start()
    {
        BallColours.onValueChanged.AddListener(delegate
        {
            Paths_ValueChangedHappened(BallColours);
        });
    }

    void Update()
    {
        
    }

    public void Paths_ValueChangedHappened(Dropdown Sender)
    {
        InGameSettings.Settings_BallColors = int.Parse(BallColours.options[BallColours.value].text);
        Debug.Log(InGameSettings.Settings_BallColors);
    }
}
