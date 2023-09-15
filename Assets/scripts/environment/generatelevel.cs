using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generatelevel : MonoBehaviour
{
    public GameObject[] section;
    public int zPos = 50;
    public bool creatingsection = false;
    public int secnum;
   
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {if(creatingsection==false)
        {
            creatingsection=true;
            StartCoroutine(GenerateSection());
            
        }
        
    }
    IEnumerator GenerateSection()
    {
        secnum = Random.Range(0, 3);
         Instantiate(section[secnum], new Vector3(0, 0, zPos), Quaternion.identity);
      

        zPos += 50;
        yield return new WaitForSeconds(2);
        
        creatingsection =false;
    }
}
