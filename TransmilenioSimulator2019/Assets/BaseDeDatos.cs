using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseDeDatos : MonoBehaviour
{
    public List<DatosEstacion> datosEstacion;

    // Start is called before the first frame update
    private void Awake()
    {
        for (int i = 0;i< datosEstacion.Count;i++)
        {
            datosEstacion[i].GuardadDatos(i.ToString(), datosEstacion[i]._desbloqueado);
            datosEstacion[i].GuardarNombre(i.ToString(), datosEstacion[i]._nombreEstacion);
        }
        
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit"))
        {
            for (int i = 0; i < datosEstacion.Count; i++)
            {
                datosEstacion[i].CargarNombre(i.ToString());
                datosEstacion[i].CargarDatos(i.ToString());
                print("Estacion: " + datosEstacion[i]._nombreEstacion + " Desbloqueado: " + datosEstacion[i]._desbloqueado);
            }          
        }
    }
    public void Eliminar(string llave)
    {
        PlayerPrefs.DeleteKey(llave);
        PlayerPrefs.Save();
    }
    public void EliminarTodo()
    {
        PlayerPrefs.DeleteAll();
    }
}
[System.Serializable]
public class DatosEstacion
{
    public string _nombreEstacion;
    [Range(0,1)]public int _desbloqueado; // 0 = Bloqueado , 1 = Desbloqueando 

    public void CargarNombre(string llave)
    {
        _nombreEstacion = PlayerPrefs.GetString(llave+"_string", "NombreDefecto");      
        
    }
    public void CargarDatos(string llave)
    {
        _desbloqueado = PlayerPrefs.GetInt(llave + "_int", 0);
    }
    public void GuardarNombre(string llave, string nombreEstacion)
    {
        PlayerPrefs.SetString(llave + "_string", nombreEstacion);

        PlayerPrefs.Save();
    }
    public void GuardadDatos(string llave,int desbloqueado)
    {
        PlayerPrefs.SetInt(llave + "_int", desbloqueado);

        PlayerPrefs.Save();
    }
}
