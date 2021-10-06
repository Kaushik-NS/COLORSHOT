using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameSettings : MonoBehaviour
{
    public static int Settings_Paths = 1;
    public static int Settings_BallColors = 3;
    public static int Settings_TimeLimit = 1;
    public static float Settings_BallSpeed = 0.4f;
    public static int Settings_BulletSpeed = 15;
    public static int Settings_GunSensitivity = 10;
    void Start()
    {
        Settings_Paths = 1;
        Settings_BallColors = 3;
        Settings_TimeLimit = 1;
        Settings_BallSpeed = 0.4f;
        Settings_BulletSpeed = 15;
        Settings_GunSensitivity = 10;
    }
    void Update()
    {
        
    }
}
