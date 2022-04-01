using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaPiso : MonoBehaviour
{

    public static bool estaEnPiso = false;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        estaEnPiso = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        estaEnPiso = false;
    }


}