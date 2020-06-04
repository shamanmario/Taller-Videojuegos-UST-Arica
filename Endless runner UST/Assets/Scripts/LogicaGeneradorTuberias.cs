using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaGeneradorTuberias : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject tuberia;
    public float tiempoMAX = 1;
    private float tiempoActual = 0;
    public float altura = 3;
    void Start()
    {
        GameObject tuberiaNueva = Instantiate(tuberia);
        tuberiaNueva.transform.position = tuberiaNueva.transform.position + new Vector3(0,0,0);
        Destroy(tuberiaNueva, 5);
        tiempoActual = 0;

    }

    // Update is called once per frame
    void Update()
    {

        if(tiempoActual > tiempoMAX)
        {
            GameObject tuberiaNueva = Instantiate(tuberia);
            tuberiaNueva.transform.position = tuberiaNueva.transform.position 
                + new Vector3(0, Random.Range(-altura, altura), 0);
            Destroy(tuberiaNueva, 5);
            tiempoActual = 0;
            tiempoMAX = Random.Range(1,4);
            AumentaDificultad.velocidadDificil += 1;
        } else
        {
            tiempoActual += Time.deltaTime;
        }

        
    }
}
