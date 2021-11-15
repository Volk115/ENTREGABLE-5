using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //POSICION DE LA CAMARA
    public GameObject Player;
    public Vector3 Offset = new Vector3(50, 0, 13);

    // Update is called once per frame
    void Update()
    {
        //SEGUIMIENTO DE LA CAMARA CON EL JUGADOR
        transform.position = Player.transform.position + Offset;

    }


}
