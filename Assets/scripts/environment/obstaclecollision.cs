using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class obstaclecollision : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject theplayer;
    public GameObject charmodel;
    public GameObject levelcontrol;
    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        theplayer.GetComponent<player>().enabled = false;
        charmodel.GetComponent<Animator>().Play("Stumble Backwards 1");
        levelcontrol.GetComponent<distance>().enabled = false;
       
        StartCoroutine(waitings());
       


    }
    IEnumerator waitings()
    {
        yield return new WaitForSeconds(1.8f);
        SceneManager.LoadScene(0);


    }
}
