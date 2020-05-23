using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{

    public float velocidad = 1;
    public float alturaSalto = 1;
    public bool puedeSaltar = false;

    public AudioClip salto;
    public AudioClip gameover;

    public ControladorEscena controlador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && puedeSaltar)
        {
            GetComponent<AudioSource>().PlayOneShot(salto, 1f);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, alturaSalto));
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "tuberia":
                //puedeSaltar = false;
                GetComponent<AudioSource>().Stop();
                GetComponent<AudioSource>().PlayOneShot(gameover, 1f);
                controlador.perdiste();
                break;
            case "piso":
                puedeSaltar = true;
                break;
            case "punto":
                ContadorPuntaje.puntaje++;
                break;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        puedeSaltar = false;
    }


}
