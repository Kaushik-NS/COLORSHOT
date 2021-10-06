using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager1 : MonoBehaviour
{

    public GameObject SpherePrefab;
    public GameObject[] OuterSpheres;
    public GameObject[] InnerSpheres;
    public GameObject[] InnerMostSpheres;
    public float BallSpeed;
    float Outer_timecounter=0;
    float Inner_timecounter = 0;
    Color[] colors;
    public bool CanInstantiate = true;
    public bool BallDestroyed = false;
    public GameObject BulletPrefab;
    public Transform FirePoint;
    public Rigidbody BulletRB;
    public GameObject GM;
    public GameObject Bullet;
    public Color ColorForBullet;
    public float NumberOfPaths;
    public float NumberOfBallColours;

    void Start()
    {
        //Bullet = new GameObject();
        InnerSpheres = new GameObject[40];
        OuterSpheres = new GameObject[40];
        InnerMostSpheres = new GameObject[20];
        colors = new Color[7];
        colors[0] = Color.cyan; 
        colors[1] = Color.red;
        colors[2] = Color.green;
        colors[3] = Color.blue;
        colors[4] = Color.yellow;
        colors[5] = Color.magenta;
        colors[6] = Color.black;
        Debug.Log("BallSpeed is " + BallSpeed);
        Debug.Log("BallColor is " + InGameSettings.Settings_BallColors);
        if (InGameSettings.Settings_Paths == 2)
        {
            for (int i = 0; i < 21; i++)
            {
                InnerSpheres[i] = Instantiate(SpherePrefab, transform.position, Quaternion.identity);
                InnerSpheres[i].GetComponent<Oscillator>().TimeCounter = Inner_timecounter;
                InnerSpheres[i].GetComponent<Oscillator>().width = 3f;
                InnerSpheres[i].GetComponent<Oscillator>().height = 3f;
                InnerSpheres[i].GetComponent<Oscillator>().speed = InGameSettings.Settings_BallSpeed;
                InnerSpheres[i].tag = "Ball";
                //Color BallColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
                Color BallColor = colors[Random.Range(0, InGameSettings.Settings_BallColors)];
                InnerSpheres[i].GetComponent<Renderer>().material.color = BallColor;
                Inner_timecounter += 0.3f;
            }
        }
        Debug.Log("BallSpeed is " + BallSpeed);
        //for (int i = 0; i < 10; i++)
        //{
        //    InnerMostSpheres[i] = Instantiate(SpherePrefab, transform.position, Quaternion.identity);
        //    InnerMostSpheres[i].GetComponent<Oscillator>().TimeCounter = Inner_timecounter;
        //    InnerMostSpheres[i].GetComponent<Oscillator>().width = 2f;
        //    InnerMostSpheres[i].GetComponent<Oscillator>().height = 2f;
        //    InnerMostSpheres[i].GetComponent<Oscillator>().speed = BallSpeed;
        //    InnerMostSpheres[i].tag = "Ball";
        //    //Color BallColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        //    Color BallColor = colors[Random.Range(0, colors.Length)];
        //    InnerMostSpheres[i].GetComponent<Renderer>().material.color = BallColor;
        //    Inner_timecounter += 0.6f;
        //}
        //if (NumberOfPaths == 2)
        //{
        for (int i = 0; i < 33; i++)
        {
            OuterSpheres[i] = Instantiate(SpherePrefab, transform.position, Quaternion.identity);
            OuterSpheres[i].GetComponent<Oscillator>().TimeCounter = Outer_timecounter;
            OuterSpheres[i].GetComponent<Oscillator>().width = 4.5f;
            OuterSpheres[i].GetComponent<Oscillator>().height = 4.5f;
            OuterSpheres[i].GetComponent<Oscillator>().speed = -InGameSettings.Settings_BallSpeed;
            OuterSpheres[i].tag = "Ball";
            //Color BallColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            Color BallColor = colors[Random.Range(0, InGameSettings.Settings_BallColors)];
            OuterSpheres[i].GetComponent<Renderer>().material.color = BallColor;
            Outer_timecounter += 0.19f;
        }
    }
    //Bullet = Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation);



    // Update is called once per frame
    void Update()
    {
        bool FoundMatchingColor = false;
        if (CanInstantiate == true)
        {
            BulletRB = Bullet.GetComponent<Rigidbody>();
            while (FoundMatchingColor == false)
            {
                ColorForBullet = colors[Random.Range(0, colors.Length)];
                for (int i = 0; i < OuterSpheres.Length; i++)
                {
                    if (OuterSpheres[i] != null)
                    {
                        if (ColorForBullet == OuterSpheres[i].GetComponent<Renderer>().material.color)
                        {
                            FoundMatchingColor = true;
                        }
                    }
                }
                for (int i = 0; i < InnerSpheres.Length; i++)
                {
                    if (InnerSpheres[i] != null)
                    {
                        if (ColorForBullet == InnerSpheres[i].GetComponent<Renderer>().material.color)
                        {
                            FoundMatchingColor = true;
                        }
                    }
                }
                if (FoundMatchingColor == true)
                {
                    BulletRB.GetComponent<Renderer>().material.color = ColorForBullet;
                }
            }
            CanInstantiate = false;
        }
    }
}
