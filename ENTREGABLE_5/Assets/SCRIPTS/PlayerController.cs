using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //VELOCIDAD DEL PLAYER (PARA AVANZAR Y ROTAR) Y LIMITE PARA FINALIZZAR EL JUEGO
    private float speed = 20.0f;
    private float verticalInput;
    private float turnspeed = 50.0f;
    private float zMax = 450;

    // Start is called before the first frame update
    void Start()
    {
        //EL PLAYER APARECE EN LA POSICION 0,0,0
        transform.position = new Vector3(x: 0, y: 0, z: 0);
    }

    // Update is called once per frame
    void Update()
    {
        //EL MOVIMIENTO SERA PREDETERMINADO POR UNITY
        verticalInput = Input.GetAxis("Vertical");

        //VELOCIDAD DEL JUGADOR EN ROTACION Y MOVIMIENTO
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        transform.Rotate(Vector3.right, turnspeed * Time.deltaTime * verticalInput);

        //SI EL JUGADOR LLEGA AL LIMITE, SE PAUSARA EL JUEGO Y SE EINFORMARA DE ELLO
        if (transform.position.z >= zMax)
        {
            Debug.Log("THE END");
            Time.timeScale = 0;
        } 
    } 
}
