using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject SettingsPanel;
    public GameObject HelpPanel;
    public GameObject CreditsPanel;
    public Dropdown Path_DropDown;
    public Dropdown BallColour_DropDown;
    public Dropdown TimeLimit_DropDown;
    public Dropdown BallSpeed_DropDown;
    public Dropdown BulletSpeed_DropDown;
    public Dropdown GunSensitivity_DropDown;
    public void Start()
    {
       
    }
    public void PanelActive()
    {
        SettingsPanel.SetActive(true);
    }
    public void PanelInactive()
    {
        SettingsPanel.SetActive(false);
    }
    public void SetPaths()
    {
        GetComponent<GameManager1>().NumberOfPaths = Path_DropDown.value; 
    }
    public void SetNoOfBallColours()
    {
        GetComponent<GameManager1>().NumberOfBallColours = BallColour_DropDown.value; 
    }
    public void SetTimeValue()
    {
        GetComponent<Timer>().TimeValue = TimeLimit_DropDown.value;
    }
    public void SetBallSpeed()
    {
        Debug.Log("BallSpeedValue is " + BallSpeed_DropDown.value);
        GetComponent<GameManager1>().BallSpeed = BallSpeed_DropDown.value; 
    }
    public void SetBulletSpeed()
    {
        //GetComponent<MouseShoot>().BulletForce = BulletSpeed_DropDown.value;
    }
    public void SetGunSensitivity()
    {
        //GetComponent<Rotate1>().RotateSpeedModifier = GunSensitivity_DropDown.value;
    }
    public void SetAllSettings()
    {
        //GetComponent<GameManager1>().NumberOfPaths = Path_DropDown.value;
        //GetComponent<GameManager1>().NumberOfBallColours = BallColour_DropDown.value;
        //GetComponent<Timer>().TimeValue = TimeLimit_DropDown.value;
        //GetComponent<GameManager1>().BallSpeed = BallSpeed_DropDown.value;
        //GetComponent<MouseShoot>().BulletForce = BulletSpeed_DropDown.value;
        //GetComponent<Rotate1>().RotateSpeedModifier = GunSensitivity_DropDown.value;
        SettingsPanel.SetActive(false);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ShowHelp()
    {
        HelpPanel.SetActive(true);
    }

    public void HelpPanelInactive()
    {
        HelpPanel.SetActive(false);
    }

    public void ShowCredits()
    {
        CreditsPanel.SetActive(true);
    }

    public void CreditsPanelInactive()
    {
        CreditsPanel.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
