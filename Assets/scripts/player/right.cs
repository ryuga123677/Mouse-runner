using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class right : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public float leftrightspeed = 4f;
    bool ispress = false;
    public GameObject myplayer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ispress==true)
        {
            if (myplayer.gameObject.transform.position.x < levelboundary.rightside)
            {
                myplayer.transform.Translate(Vector3.right * Time.deltaTime * leftrightspeed);
            }
        }
    }
    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {ispress= true;

    }
    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        ispress= false;
    }
}
