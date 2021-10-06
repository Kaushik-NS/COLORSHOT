using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireButton : MonoBehaviour
{
    public GameObject HitButton;

    public void DisableHit()
    {
        HitButton.gameObject.SetActive(false);
    }
}
