using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseShoot : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject BulletPrefab;
    public Rigidbody BulletRB;
    private Touch Touch;
    public GameObject GM;
    private Vector2 begintouchposition;
    private Vector2 endtouchposition;

    void Start()
    {
        //RB = GetComponent<Rigidbody>();  
    }
    void Update()
    {

        //if (Input.touchCount > 0)
        //{
        //    Touch = Input.GetTouch(0);
        //    switch (Touch.phase)
        //    {
        //        case TouchPhase.Began:
        //            begintouchposition = Touch.position;
        //            break;
        //        case TouchPhase.Ended:
        //            endtouchposition = Touch.position;

        //            if (begintouchposition == endtouchposition)
        //            {
        //                Shoot();
        //            }
        //            break;
        //    }
        //}
    }


    //    if (Input.touchCount > 0)
    //{

    //    Touch = Input.GetTouch(0);



    //    if ((Touch.phase == TouchPhase.Began))
    //    {
    //        Shoot();
    //    }
    //}
    //if (Touch.phase == TouchPhase.Ended)
    //{
    //    if (Input.touchCount > 1)
    //    {
    //       Shoot();
    //    }
    //}
    public void Shoot()
    {
        GameObject BulletFire = Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation);
        BulletRB = BulletFire.GetComponent<Rigidbody>();
        BulletRB.GetComponent<Renderer>().material.color = GM.GetComponent<GameManager1>().ColorForBullet;
        BulletRB.AddForce(FirePoint.up * InGameSettings.Settings_BulletSpeed, ForceMode.Impulse);
        GM.GetComponent<GameManager1>().CanInstantiate = true;
    }
}
