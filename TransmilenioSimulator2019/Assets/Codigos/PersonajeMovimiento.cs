using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeMovimiento : MonoBehaviour
{
    [Header("Ordenar de forma decendente de 1 a ultimo")]
    public List<Transform> rutas;
    public GameObject ubicacion;
    public float velocidad;
    [Header("Verdadero = Cuando llega a la ultima parada ya no hace nada")]
    [Header("Falso = Cuando llega a la ultima ruta regresa a la primera y comienza de nuevo")]
    public bool ruta_Final;

    // Variables privadas
    private Transform personaje;
    private int numeroRuta;
    private bool retorno = false;

    // Start is called before the first frame update
    void Start()
    {
        personaje = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
        personaje.position = Vector2.MoveTowards(personaje.transform.position, rutas[numeroRuta].transform.position, velocidad * Time.deltaTime);
        personaje.right = rutas[numeroRuta].transform.position - personaje.transform.position;
        Vector3 distancias = rutas[numeroRuta].position - personaje.position;
        float distancia = distancias.sqrMagnitude;
        if (distancia <= 0)
        {
            if (retorno == false)
            {
                if (numeroRuta == rutas.Count - 1)
                {
                    if(ruta_Final == false)
                        retorno = true;                   
                }
                else
                {
                    numeroRuta++;
                }
            }
            else
            {
                if (numeroRuta == 0)
                {
                    retorno = false;
                }
                else
                {
                    numeroRuta--;
                }
            }

           
        }
        Debug.DrawLine(rutas[0].position, rutas[1].position,Color.red);
    }
}
