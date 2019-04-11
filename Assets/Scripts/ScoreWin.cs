using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreWin : MonoBehaviour
{
    public GameObject winPannel;
    public GameObject loose;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "WinStar")
        {
            winPannel.SetActive(true);
            loose.SetActive(false);
        }
    }

}
