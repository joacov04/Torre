using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class matar : MonoBehaviour
{
    Collider Col;
    private void Start()
    {
        Col = GetComponent<BoxCollider>();
        Col.enabled = false;
    }
    private void Update()
    {
        // Check for mouse input
            if (Input.GetMouseButtonDown(0))
            {
                OnClick();
            }
    }
    void OnClick()
    {
                StartCoroutine(Activar());
                StartCoroutine(Desactivar());
    }
    IEnumerator Desactivar()
    {
        yield return new WaitForSeconds(0.6f); //wait 10 seconds
        Col.enabled = false;
        print("inactivo");
    }
    IEnumerator Activar()
    {
        yield return new WaitForSeconds(0.1f); //wait 10 seconds
        Col.enabled = true;
        print("activo");
    }
}
