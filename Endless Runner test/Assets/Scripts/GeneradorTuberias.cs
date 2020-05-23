using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorTuberias : MonoBehaviour
{
    public GameObject tuberia;
    public float tiempoMax = 1;
    private float tiempoActual = 0;
    public float altura = 1;
    // Start is called before the first frame update
    void Start()
    {
        GameObject tuberiaNueva = Instantiate(tuberia);
        tuberiaNueva.transform.position += new Vector3(0, 0, 0);
        Destroy(tuberiaNueva, 10);
    }

    // Update is called once per frame
    void Update()
    {
        if(tiempoActual > tiempoMax)
        {
            GameObject tuberiaNueva = Instantiate(tuberia);
            tuberiaNueva.transform.position += new Vector3(0, Random.Range(-altura, altura), 0);
            Destroy(tuberiaNueva, 10);
            tiempoActual = 0;
            tiempoMax = Random.Range(1,3);
} else
        {
            tiempoActual += Time.deltaTime;
        }
        
    }
}
