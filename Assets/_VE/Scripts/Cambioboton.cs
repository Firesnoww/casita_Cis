using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cambioboton : MonoBehaviour
{
    public RectTransform[] botones;
    public int conteo = 0;
    public RectTransform[] Posiciones;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        switch (conteo)
        {
            case 0:
                botones[0].gameObject.SetActive(true);
                botones[0].gameObject.GetComponent<Button>().enabled = true;
                botones[0].position = Posiciones[2].position;
                botones[1].gameObject.GetComponent<Button>().enabled = false;
                botones[1].gameObject.SetActive(true);
                botones[1].position = Posiciones[3].position;
                botones[2].gameObject.SetActive(false);
                botones[2].position = Posiciones[4].position;
                botones[3].gameObject.SetActive(false);
                botones[3].position = Posiciones[4].position;
                botones[4].gameObject.SetActive(false);
                botones[4].position = Posiciones[4].position;

                break;
            case 1:


                botones[0].gameObject.SetActive(true);
                botones[0].gameObject.GetComponent<Button>().enabled = false;
                botones[0].position = Posiciones[1].position;
                botones[1].gameObject.SetActive(true);
                botones[1].gameObject.GetComponent<Button>().enabled = true;
                botones[1].position = Posiciones[2].position;
                botones[2].gameObject.SetActive(true);
                botones[2].gameObject.GetComponent<Button>().enabled = false;
                botones[2].position = Posiciones[3].position;
                botones[3].gameObject.SetActive(false);
                botones[3].position = Posiciones[4].position;
                botones[4].gameObject.SetActive(false);
                botones[4].position = Posiciones[4].position;
                break;

            case 2:

                botones[0].gameObject.SetActive(false);
                botones[0].position = Posiciones[0].position;
                botones[1].gameObject.SetActive(true);
                botones[1].gameObject.GetComponent<Button>().enabled = false;
                botones[1].position = Posiciones[1].position;
                botones[2].gameObject.SetActive(true);
                botones[2].gameObject.GetComponent<Button>().enabled = true;
                botones[2].position = Posiciones[2].position;
                botones[3].gameObject.SetActive(true);
                botones[0].gameObject.GetComponent<Button>().enabled = false;
                botones[3].position = Posiciones[3].position;
                botones[4].gameObject.SetActive(false);
                botones[4].position = Posiciones[4].position;

                break;

            case 3:

                botones[0].gameObject.SetActive(false);
                botones[0].position = Posiciones[0].position;
                botones[1].gameObject.SetActive(false);
                botones[1].position = Posiciones[0].position;
                botones[2].gameObject.SetActive(true);
                botones[2].gameObject.GetComponent<Button>().enabled = false;
                botones[2].position = Posiciones[1].position;
                botones[3].gameObject.SetActive(true);
                botones[3].gameObject.GetComponent<Button>().enabled = true;
                botones[3].position = Posiciones[2].position;
                botones[4].gameObject.SetActive(true);
                botones[4].gameObject.GetComponent<Button>().enabled = false;
                botones[4].position = Posiciones[3].position;
                break;

            case 4:
                botones[0].gameObject.SetActive(false);
                botones[0].position = Posiciones[0].position;
                botones[1].gameObject.SetActive(false);
                botones[1].position = Posiciones[0].position;
                botones[2].gameObject.SetActive(false);
                botones[2].position = Posiciones[0].position;
                botones[3].gameObject.SetActive(true);
                botones[3].gameObject.GetComponent<Button>().enabled = false;
                botones[3].position = Posiciones[1].position;
                botones[4].gameObject.SetActive(true);
                botones[4].gameObject.GetComponent<Button>().enabled = true;
                botones[4].position = Posiciones[2].position;
                break;

            default:
                break;
        }
    }

    public void PasaDerecha()
    {
        if (conteo <= 4 )
        {
            conteo++;
        }      
    }
    public void PasaIzquierda()
    {
        if (conteo >= 0)
        {
            conteo--;
        }
    }

}
