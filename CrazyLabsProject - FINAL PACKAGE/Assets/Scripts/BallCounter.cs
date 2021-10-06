using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCounter : MonoBehaviour
{
    public int BallsLeft=0;
    // Start is called before the first frame update
    void Start()
    {
     
        if (InGameSettings.Settings_Paths == 1)
        {
            BallsLeft = 33;
        }
        else if (InGameSettings.Settings_Paths == 2)
        {
            BallsLeft = 54;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DecrementBalls()
    {
        BallsLeft--;
    }
}
