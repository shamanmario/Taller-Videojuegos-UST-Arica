using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaTuberia : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidad = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * (velocidad + AumentaDificultad.velocidadDificil);
    }
}
