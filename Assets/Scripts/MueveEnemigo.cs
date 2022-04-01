using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//CODIGO HECHO POR MI EN LA ACADEMIA PARA MOVER AL ENEMIGO
public class MueveEnemigo : MonoBehaviour
{
    public float speed = 2f; //SE DEFINEN LAS VARIABLES DE LA VELOCIDAD DEL ENEMIGO Y SU DISTANCIA A RECORRER, SE PUEDEN EDITAR EN UNITY YA QUE SON PUBLIC
    public float distance = 3f;
    private float positionLeft; //sE CREA LAS VARIABLES PARA DETECTAR SI ESTA EN LA DERECHA O IZQUIERDA 
    private float positionRight;

    private bool isMovingRight = false; //ES PARA DETECTAR CUANDO EL MOVIMIENTO ES A LA DERECHA Y SE REGRESE AL LLEGAR A LA DISTANCIA MAXIMA
    public SpriteRenderer spriteR;



    // Start is called before the first frame update
    void Start()
    {
        //SE HACE LLAMADA AL OBJECTO DE SPRITE RENDERER Y SE HACE USO DE UNA FÓRMULA PARA QUE CUANDOLLEGUE A LA DISTANCIA X O Y, DE LA VUELTA
        spriteR = gameObject.GetComponent<SpriteRenderer>();
        positionLeft = gameObject.transform.position.x - distance;
        positionRight = gameObject.transform.position.x + distance;
    }

    // Update is called once per frame
    void Update()
    {
        //SI SE MUEVE A LA DERECHA
        if (isMovingRight == true)
        { //ENTOCES SE HACE USO DE ESTA FORMULA PARA QUE DE LA VUELTA POR EL TIEMPO Y LA DISTANCIA QUE SE PONGA
            gameObject.transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else
        { //AQUI ES LO MISMO PERO PARA EL OTRO LADO
            gameObject.transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        if (transform.position.x >= positionRight)
        {
            spriteR.flipX = false;
            isMovingRight = false;
        }

        if (transform.position.x <= positionLeft)
        {
            spriteR.flipX = true;
            isMovingRight = true;
        }
    }
}