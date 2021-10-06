using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager_Main : MonoBehaviour
{
    // Start is called before the first frame update
    public Color[] colorlist;
    public ColorBlock ColorsBlock;
    public Button TitleButton;
    public Image TitleImage;
    void Start()
    {
        //TitleButton = GetComponent<Button>();
        //ColorsBlock = GetComponent<Button>().colors;
        colorlist = new Color[7];
        colorlist[0] = Color.cyan;
        colorlist[1] = Color.red;
        colorlist[2] = Color.green;
        colorlist[3] = Color.white;
        colorlist[4] = Color.yellow;
        colorlist[5] = new Color(71,255,42);
        colorlist[6] = Color.black;
        InvokeRepeating("ChangeColors", 0.1f, 0.1f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeColors()
    {
        TitleButton.image.color = colorlist[Random.Range(0, 6)];
    }
}
