using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorEscena : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject canvasPerdiste;
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void perdiste()
    {
        canvasPerdiste.SetActive(true);
        Time.timeScale = 0;
    }

    public void reinicio()
    {
        SceneManager.LoadScene(0);
    }
}
