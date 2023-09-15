using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class distance : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject disdisplay;
    public GameObject disenddisplay;
    public int disrun;
    public bool addingdis=false;

    // Update is called once per frame
    void Update()
    {
        if(addingdis==false)
        {
            addingdis=true;
            StartCoroutine(adddis());
        }
    }
    IEnumerator adddis()
    {

        disrun += 1;
        disdisplay.GetComponent<Text>().text = "" + disrun;
        disenddisplay.GetComponent<Text>().text = "" + disrun;
        yield return new WaitForSeconds(0.25f);
        addingdis = false;

    }
}
