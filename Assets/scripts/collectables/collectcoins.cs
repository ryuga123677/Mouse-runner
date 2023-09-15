using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collectcoins : MonoBehaviour
{
    public AudioSource coinfx;
    private void OnTriggerEnter(Collider other)
    {
        coinfx.Play();
        collectablecontrol.coincount += 1;
        this.gameObject.SetActive(false);
    }
}
