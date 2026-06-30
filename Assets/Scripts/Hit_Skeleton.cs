using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_Skeleton : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D coll) {
         if(coll.CompareTag("Player")) {
            print("Daño causado");
         }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
