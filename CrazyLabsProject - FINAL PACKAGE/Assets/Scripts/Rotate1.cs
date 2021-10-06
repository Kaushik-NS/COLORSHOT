using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate1 : MonoBehaviour
{
    private Touch Touch;
    private Vector2 TouchPosition;
    private Quaternion RotationZ;
    private Vector2 begintouchposition;
    private Vector2 endtouchposition;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch = Input.GetTouch(0);
            RotationZ = Quaternion.Euler(0f, 0f, -Touch.deltaPosition.x * InGameSettings.Settings_GunSensitivity * Time.deltaTime);
            transform.rotation = RotationZ * transform.rotation;
        }
            //switch (Touch.phase)
            //{
            //    case TouchPhase.Began:
            //        begintouchposition = Touch.position;
            //        break;
            //    case TouchPhase.Ended:
            //        endtouchposition = Touch.position;
            //        if (begintouchposition == endtouchposition)
            //        {
            //            GetComponent<MouseShoot>().Shoot();
            //        }
            //        else
            //        {
            //            RotationZ = Quaternion.Euler(0f, 0f, -Touch.deltaPosition.x * RotateSpeedModifier * Time.deltaTime);
            //            transform.rotation = RotationZ * transform.rotation;
            //        }
            //        break;
            //}
            //if (Touch.phase == TouchPhase.Moved)
            //{
            //    //We transform the touch position into word space from screen space and store it.
            //    Vector3 touchPosWorld = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            //    Vector2 touchPosWorld2D = new Vector2(touchPosWorld.x, touchPosWorld.y);

            //    //We now raycast with this information. If we have hit something we can process it.
            //    RaycastHit2D hitInformation = Physics2D.Raycast(touchPosWorld2D, Camera.main.transform.forward);

            //    if (hitInformation.collider != null)
            //    {
            //        //We should have hit something with a 2D Physics collider!
            //        GameObject touchedObject = hitInformation.transform.gameObject;
            //        if (touchedObject.tag == "Slider")
            //        {
            //            RotationZ = Quaternion.Euler(0f, 0f, -Touch.deltaPosition.x * RotateSpeedModifier * Time.deltaTime);
            //            transform.rotation = RotationZ * transform.rotation;
            //        }

            //    }
            //}
    }
}
