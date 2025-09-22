using UnityEngine;
using System.Collections.Generic;


public class playerMovement : MonoBehaviour
{
    private int pista = 1;
    private int[] pistas = new int[] { -11, 0, 11 };
    private int[] verticais = new int[] { 0, 10 };
    public Transform model;
    public int vertical = 0;
    public float rotacao = 0f;
    public Quaternion myrotation;
    private int velocidade = 35;
    private bool podetrocar = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            if (pista > 0)
            {
                pista--;
            }
        }
      
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            if(pista < 2)
            {
                pista++;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) && podetrocar)
        {
            podetrocar = false;
            Invoke(nameof(PodeVirar), 0.5f);
            if (vertical == 1) 
            {
                vertical = 0;
                rotacao = 0f;
            }
            else if (vertical == 0)  
            { 
                vertical = 1;
                rotacao = 180f;
            }
        }

        Vector3 pos = transform.position; 
        pos.x = Mathf.MoveTowards(pos.x, pistas[pista], velocidade * Time.deltaTime);
        pos.y = Mathf.MoveTowards(pos.y, verticais[vertical], velocidade * Time.deltaTime);
        model.transform.rotation = Quaternion.RotateTowards(model.transform.rotation, Quaternion.Euler(0,0,rotacao), 600 * Time.deltaTime);
        transform.position = pos;
    }

    void PodeVirar()
    {
        podetrocar = true;
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 1);
        Gizmos.DrawSphere(transform.position, 2f);
    }

}
