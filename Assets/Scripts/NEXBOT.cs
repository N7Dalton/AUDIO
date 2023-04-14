using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NEXBOT : MonoBehaviour
{
    // Start is called before the first frame update
   
        public GameObject player;

    public float speed;

    void Update()
    {
        SnailCrawl();
      
       // transform.Rotate(90, 0, 0);
       
    }

    public void SnailCrawl()
    {

        transform.LookAt(player.transform.position, Vector3.up);
        transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
