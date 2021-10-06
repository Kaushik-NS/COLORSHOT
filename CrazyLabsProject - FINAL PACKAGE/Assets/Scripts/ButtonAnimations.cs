using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimations : MonoBehaviour
{
    public void ButtonTouch()
    {
        GetComponent<Animation>().Play("ButtonTouch_Play");
        GetComponent<Animation>().Play("ButtonTouch_Exit");
        GetComponent<Animation>().Play("ButtonTouch_Help");
        GetComponent<Animation>().Play("ButtonTouchRotate_Settings");

    }
}
