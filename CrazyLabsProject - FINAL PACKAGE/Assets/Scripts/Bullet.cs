using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public ParticleSystem Explosion;
    public ParticleSystem Explosion1;
    public GameObject MainBullet;
    public AudioSource BallBurst;
    public AudioSource BallBurst1;
    public AudioSource BallHit;
    public AudioSource BallHit1;
    private GameWin WinPanel;
    private BallCounter BC;
    public FireButton HitButton;


    float force = 3f;
    void Start()
    {
        BC = GameObject.FindGameObjectWithTag("BallCounter").GetComponent<BallCounter>();
        WinPanel = GameObject.FindGameObjectWithTag("GameWin").GetComponent<GameWin>();
        HitButton = GameObject.FindGameObjectWithTag("FireButton").GetComponent<FireButton>();
        //Explosion1 = GetComponent<ParticleSystem>();
        //WinPanel = new GameObject.FindGameObjectWithTag("GamewinPanel");
    }
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Ball")
        {
            
            Renderer me = gameObject.GetComponent<Renderer>();
            Renderer colliding = other.gameObject.GetComponent<Renderer>();
            if (me != null && colliding != null)
            {
                //GM.GetComponent<AudioSource>().Play();
                if (me.sharedMaterial.color == colliding.sharedMaterial.color)
                {
                    ScoreScript.ScoreValue += 10;
                    MainBullet.GetComponent<AudioSource>().Play();
                    if (other.gameObject.tag == "Ball")
                    { 
                        if (Explosion == null)
                        {
                            //Debug.Log("Came in to Instantiate PS");
                            Explosion = Instantiate(Explosion1,transform.position, Quaternion.identity);
                        }

                        Explosion.transform.position = transform.position;
                        Explosion.GetComponent<Renderer>().material = other.gameObject.GetComponent<Renderer>().material;
                        Explosion.Play();
                        //Vector3 dir = other.contacts[0].point - transform.position;
                        //dir = -dir.normalized;
                        //GetComponent<Rigidbody>().AddForce(dir * force);
                    }
                    BallBurst = Instantiate(BallBurst1, transform.position, Quaternion.identity);
                    BallBurst.Play();

                    Destroy(other.gameObject);
                    BC.DecrementBalls();
                    if (BC.BallsLeft <= 0 )
                    {
                        HitButton.DisableHit();
                        WinPanel.ShowPanel();
                    }
                     Destroy(this.gameObject);
                    //}
                }
                else
                {
                    ScoreScript.ScoreValue -= 5;
                    Destroy(this.gameObject);
                    BallHit = Instantiate(BallHit1, transform.position, Quaternion.identity);
                    BallHit.Play();

                }
            }
        }



        //if (other.gameObject.tag == "Ball")
        //    if (other.gameObject.GetComponent<Renderer>().material.color)
        //{
        //    //Debug.Log(other.gameObject.tag);
        //    Destroy(other.gameObject);
        //    Destroy(this.gameObject);
        //}
    }
}
