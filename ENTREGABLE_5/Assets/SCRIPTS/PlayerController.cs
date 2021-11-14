using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 10.0f;
    private float verticalInput;
    private float turnSpeed = 20.0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(x: 0, y: 0, z: 0);


    }

    // Update is called once per frame
    void Update()
    {
        MoveGameObject(Vector3.forward * Time.deltaTime * speed, KeyCode.UpArrow);

        RotateGameObject(KeyCode.S, rotation: new Vector3(x: 0, y: 0, z: 0));
        RotateGameObject(KeyCode.S, rotation: new Vector3(x: turnSpeed, y: 0, z: 0));

    }

    public void MoveGameObject(Vector3 direction, KeyCode kCode)
    {
        if (Input.GetKeyDown(kCode))
        {
            transform.Translate(direction);
        }
    }

    public void RotateGameObject(KeyCode kcode, Vector3 rotation)
    {
        if (Input.GetKeyDown(kcode))
        {
            transform.rotation *= Quaternion.Euler(rotation);
        }


    }
}
