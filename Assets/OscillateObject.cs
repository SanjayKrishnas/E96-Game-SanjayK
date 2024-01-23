using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscillateObject : MonoBehaviour
{
    private float speed = 20.0f;
    private Vector3 origin;
    // Start is called before the first frame update
    void Start() //consturctor
    {
        
    }

    // Update is called once per frame
    void Update() //will run every single frame of the game
    {
        transform.Rotate(new Vector3(0, -1, 0) * speed * Time.deltaTime); //should rotate the wheels
    }
}
