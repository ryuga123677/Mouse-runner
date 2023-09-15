using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collectablecontrol : MonoBehaviour
{
    public static int coincount;
    public GameObject coincountdisplay;
    public GameObject coinenddisplay;

    // Update is called once per frame
    void Update()
    {
        coincountdisplay.GetComponent<Text> ().text = ""+coincount;
        coinenddisplay.GetComponent<Text>().text = "" + coincount;
    }
}
