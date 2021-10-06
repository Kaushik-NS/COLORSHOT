using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletSpeed_DropDown_Handler : MonoBehaviour
{
    public Dropdown BulletSpeed;
    void Start()
    {
        BulletSpeed.onValueChanged.AddListener(delegate
        {
            Paths_ValueChangedHappened(BulletSpeed);
        });
    }

    void Update()
    {
       
    }

    public void Paths_ValueChangedHappened(Dropdown Sender)
    {
        InGameSettings.Settings_BulletSpeed = int.Parse(BulletSpeed.options[BulletSpeed.value].text);
        Debug.Log(InGameSettings.Settings_BulletSpeed);
    }
}
