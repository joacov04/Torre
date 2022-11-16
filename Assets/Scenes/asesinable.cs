using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asesinable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider collision){
            controlEnemigos enemigo = GetComponent<controlEnemigos>();
            print("Me estan pegando");
            if(collision.gameObject.tag == "Espada")
            {
                enemigo.die();
            }
    }

}
