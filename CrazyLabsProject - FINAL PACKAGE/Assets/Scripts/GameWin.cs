using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWin : MonoBehaviour
{
    public GameObject GameWinPanel;
    // Start is called before the first frame update
    void Start()
    {
        GameWinPanel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowPanel()
    {
        GameWinPanel.gameObject.SetActive(true);
    }
}
