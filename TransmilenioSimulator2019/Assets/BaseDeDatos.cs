using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class BaseDeDatos : MonoBehaviour
{
    [HideInInspector]
    public Datos claseDatos;
    private float dato;
    private string ubicacionGuardado;
    // Start is called before the first frame update
    private void Awake()
    {
        ubicacionGuardado = Application.dataPath;
    }
    void Start()
    {
        claseDatos = new Datos()
        {
            info1 = "NuevoJson2",
            dato_principal = 53
        };
        string archivoJson = JsonUtility.ToJson(claseDatos);
        print(archivoJson);

        File.WriteAllText(ubicacionGuardado + "Base_de_Datos", archivoJson);
        print(ubicacionGuardado);

        Datos cargarDatos = JsonUtility.FromJson<Datos>(archivoJson);
        print("float: "+cargarDatos.dato_principal);
        print("String: " + cargarDatos.info1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
[System.Serializable]
public class Datos
{
    public string info1;
    public float dato_principal;
}
