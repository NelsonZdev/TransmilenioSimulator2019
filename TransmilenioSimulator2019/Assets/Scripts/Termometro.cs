
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Termometro : MonoBehaviour
{

    public Scrollbar barra;
    public float felicidad;
    // Start is called before the first frame update
    void Start(){
       
        felicidad=0f;
       /* Renderer rend = GetComponent<Renderer>();
        rend.material.SetColor(Color.red);*/
        /* SpriteRenderer renderer = barra.GetComponent<SpriteRenderer>();
        renderer.color = new Color(135f, 0f, 0f, 1f);*/
         Scrollbar b = barra.GetComponent<Scrollbar>(); 
    }

    // Update is called once per frame
    void Update()
    {   
            felicidad+=0.001f;
            barra.size=felicidad;
            if(felicidad>=0.771){
             ColorBlock cb = barra.colors;
             cb.normalColor = Color.green;
             barra.colors = cb;
            }/*else if (felicidad<=0.312){
             ColorBlock cb = barra.colors;
             cb.normalColor = Color.yellow;
             barra.colors = cb; 
            }*/else if(felicidad==0.5){
             ColorBlock cb = barra.colors;
             cb.normalColor = Color.white;
             barra.colors = cb;
            }else if (felicidad<0.5 && felicidad>0.2 || felicidad>0.5 && felicidad<0.771){
             ColorBlock cb = barra.colors;
             cb.normalColor = Color.yellow;
             barra.colors = cb;
            }else if (felicidad<=0.2){
             ColorBlock cb = barra.colors;
             cb.normalColor = Color.red;
             barra.colors = cb;
            }

    }
}

