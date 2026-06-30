using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Vida_Script : MonoBehaviour
{
    int vidas;
    public Text TextVida;
    
    public Image GameOver;
    // Start is called before the first frame update
    void Start()
    {
        GameOver.enabled= false;
        
        vidas = 3;
    }
     
    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D otro)
    {
        if (otro.gameObject.tag == "Skeleton")
        {

            vidas = vidas - 1;
            FindObjectOfType<Cat_Movement>().SendMessage("Re");
            TextVida.text= "Vidas = " + vidas;
            
            
            
                        
            

            if (vidas <= 0)
            {
               
                Destroy(this.gameObject);
                
                
                GameOver.enabled = true;
                
                
               
                             
                
                
                
            }
        }
    }
    
    void Update()
    {
        
    }
}
