using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ValidarContraseña : MonoBehaviour
{
    string contraseñacorrecta;
    string contraseñausuario;
    public Text ingresousuario;
    public Text textomsj;
    public GameObject cartel;
    void Start()
    {
        contraseñacorrecta = "12345";
        cartel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Validarcontraseña()
    {
        contraseñausuario = ingresousuario.text;
        if (contraseñausuario == contraseñacorrecta)
        {
            cartel.SetActive(true);
            textomsj.text = " Bienvenido ";
            Debug.Log(" Bienvenido");
        }
        else
        {
            textomsj.text = " Contraseña incorrecta";
            cartel.SetActive(true);
            Debug.Log(" Contraseña incorrecta");
        }
    }
}
