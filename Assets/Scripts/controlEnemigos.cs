using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class controlEnemigos : MonoBehaviour
{

    public float fuerzaExplosion;
    private bool vivo = true;
    protected NavMeshAgent meshEnemigo;

    // Start is called before the first frame update
    void Start()
    {
        vivo = true;
        meshEnemigo = GetComponent<NavMeshAgent>();
        setRigidBodyState(true);
        setColliderState(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(vivo) {
            GameObject personaje = GameObject.FindGameObjectWithTag("Player");
            meshEnemigo.SetDestination(personaje.transform.position);
        }
    }



    public void die()
    {
        vivo = false;
        GameObject explosion = GameObject.FindGameObjectWithTag("Explosion");
        BlastWave blast = (BlastWave) explosion.GetComponent(typeof(BlastWave));
        blast.explota();
        GetComponent<Animator>().enabled = false;
        Collider [] colliders = Physics.OverlapSphere(transform.position, 50f);
        vivo = false;
        explosion.transform.position = transform.position;

        foreach(Collider closeObject in colliders)
        {
            Rigidbody rigidbody = closeObject.GetComponent<Rigidbody>();
            if(rigidbody != null)
                rigidbody.AddExplosionForce(fuerzaExplosion, transform.position, 50f);
        }
        setRigidBodyState(false);
        setColliderState(true);
    }



    public void setRigidBodyState(bool state)
    {
        Rigidbody [] rigidbodies = GetComponentsInChildren<Rigidbody>();
        foreach(Rigidbody rigidbody in rigidbodies)
        {
            rigidbody.isKinematic = state;
        }
            GetComponent<Rigidbody>().isKinematic = !state;
    }
    public void setColliderState(bool state)
    {
        Collider [] colliders = GetComponentsInChildren<Collider>();
        foreach(Collider collider in colliders)
        {
            collider.enabled = state;
        }
            GetComponent<Collider>().enabled = !state;
    }
}