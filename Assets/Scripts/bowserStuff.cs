using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bowserStuff : MonoBehaviour
{
    public GameObject SpotLight;
    
    // Start is called before the first frame update
    void Start()
    {
        TheShow();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator TheShow()
    {
        yield return new WaitForSeconds(1);
        Debug.Log("waited 3 secs");
        SpotLight.SetActive(true);
        
    }
}
