using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemigoPrefab;

    [SerializeField]
    private float enemigoIntervalo = 3.5f;

    [SerializeField]
    private float posicionSpawnerX;
    [SerializeField]
    private float posicionSpawnerY;
    [SerializeField]
    private float posicionSpawnerZ;

    [SerializeField]
    public int cantidadEnemigos;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(enemigoIntervalo,enemigoPrefab));
    }


    private IEnumerator spawnEnemy(float intervalo, GameObject enemigo)
    {   
        yield return new WaitForSeconds(intervalo);
        GameObject nuevoEnemigo = Instantiate(enemigo, new Vector3(posicionSpawnerX, posicionSpawnerY ,posicionSpawnerZ), Quaternion.identity);
        cantidadEnemigos = cantidadEnemigos - 1;
        if(cantidadEnemigos > 0){
            StartCoroutine(spawnEnemy(intervalo,enemigo));
        }
        
    }

}
