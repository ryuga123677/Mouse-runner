using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    public float movspeed = 10f;
    public float leftrightspeed = 4f;
    static public bool canmove = false;
    public bool isjumping = false;
    public bool comingdown = false;
    public GameObject myplayer;

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.forward * Time.deltaTime * movspeed, Space.World);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x > levelboundary.leftside)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftrightspeed);
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < levelboundary.rightside)
            {
                transform.Translate(Vector3.right * Time.deltaTime * leftrightspeed);
            }
        }
        if ( (Input.GetKey(KeyCode.Space)))
        {
            if (isjumping == false)
            {
                isjumping = true;
                myplayer.GetComponent<Animator>().Play("Jumping 1");
                StartCoroutine(jumpseq());
            }
        }

        if (isjumping == true)
        {    if (comingdown == false)
            {
                transform.Translate(Vector3.up * Time.deltaTime * -5, Space.World);
                
            }
            if (comingdown == true)
            {
                transform.Translate(Vector3.up * Time.deltaTime * 5, Space.World);

            }
        
          
        }
    }


        IEnumerator jumpseq()
        {
            yield return new WaitForSeconds(0.8f);
            comingdown = false;

            yield return new WaitForSeconds(0.8f);
            isjumping = false;
            comingdown = true;
            myplayer.GetComponent<Animator>().Play("Running 1");
        }
     public void jump()
    {
        if (isjumping == false)
        {
            isjumping = true;
            myplayer.GetComponent<Animator>().Play("Jumping 1");
            StartCoroutine(jumpseq());
        }
    }
}


