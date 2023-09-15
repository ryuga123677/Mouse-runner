using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cred : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void CREDIT()
    {
        SceneManager.LoadScene(2);

        StartCoroutine(jumpedd());
     
        
        

      
        
      
    }
    IEnumerator jumpedd()
    {
        yield return new WaitForSeconds(2f);
      
        SceneManager.LoadScene(0);
    }

}
