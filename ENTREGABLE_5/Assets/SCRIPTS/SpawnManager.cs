using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public Vector3 spawnPos = new Vector3(0, 0, 30);
    private float randomY;

    //SEGUNDOS DE INICIO PARA LOS OBSTACULOS
    private float StartSeconds = 0.5f;
    //(LA VELOCIDAD HA SIDO MODIFICADA PARA QUE LOS OBSTACULOS APAREZCAN A UN TIEMPO CORRETCO)
    private float Seconds = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        //GENERA LOS OBSTACULOS
        InvokeRepeating("SpawnObstacle", StartSeconds, Seconds);
    }

    public void SpawnObstacle()
    {
        //LOS OBSTACULOS APARECERAN ALEATORIAMENTE ENTRE -10 Y 10 (EN UN RANGO DE 50)
        randomY = Random.Range(-10, 10);
        spawnPos = new Vector3(0, randomY, spawnPos.z + 50);
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }

}
