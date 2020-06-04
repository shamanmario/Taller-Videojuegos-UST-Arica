using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LogicaPersonaje : MonoBehaviour
{
    // Start is called before the first frame update
    public float altura = 200;
    public bool hayPiso = false;
    public ControladorEscena controlador;
    public AudioClip salto;
    public AudioClip gameOver;

    private bool juegoActivo = true;
    void Start()
    {
        juegoActivo = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && hayPiso && juegoActivo)
        {
            GetComponent<AudioSource>().PlayOneShot(salto, 1);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0,altura));
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Suelo")
            hayPiso = true;

        if(collision.tag == "Tuberia")
        {
            GetComponent<AudioSource>().Stop();
            GetComponent<AudioSource>().PlayOneShot(gameOver, 1);
            controlador.perdiste();
            juegoActivo = false;
        }
            


    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        hayPiso = false;
    }

  


}
