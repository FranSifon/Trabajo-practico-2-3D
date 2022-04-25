using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MayoriaEdad : MonoBehaviour
{

    public int EdadUsuario;
    public Text mitexto;
    void Start()
    {
       if ( EdadUsuario >= 18)
        {
            mitexto.text = " Es mayor de edad ";
            Debug.Log(" Es mayor de edad ");
        }
        else
        {
            mitexto.text = " Es menor de edad ";
            Debug.Log(" No es mayor de edad ");
        }
    }

   
    void Update()
    {
        
    }
}
