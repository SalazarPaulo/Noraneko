using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int puntaje;
    public Text puntajeText;
    // Start is called before the first frame update
    void Start()
    {
        puntaje = 0;
    }
    private void OnTriggerEnter2D(Collider2D cols)
    {
        if(cols.gameObject.tag == "Coin")
        {
            puntaje = puntaje + 10;
            Debug.Log("Agarro la moneda:" + puntaje);
            puntajeText.text = "Puntos = " + puntaje;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
