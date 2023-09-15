using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class leftanndright : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    public float leftrightspeed = 4f;
    public GameObject myplayer;
    bool ispress = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(ispress==true)
        {
            

            if (myplayer.transform.position.x > levelboundary.leftside)
            {
                myplayer.transform.Translate(Vector3.left * Time.deltaTime * leftrightspeed);
            }

        }
    }
    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        ispress = true;
    }
    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        ispress = false;
    }
}
