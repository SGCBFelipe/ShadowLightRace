using UnityEngine;



public class playerMovement : MonoBehaviour
{
    private int pista = 1;
    private int[] pistas = new int[] { -11, 0, 11 };
    private int[] verticais = new int[] { 0, 10 };

    public int vertical = 0;
    private int velocidade = 35;
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (vertical == 1) 
            {
                vertical = 0; 
            }
            else if (vertical == 0)  
            { 
                vertical = 1; 
            }
        }
            

        Vector3 pos = transform.position; ;
        pos.x = Mathf.MoveTowards(pos.x, pistas[pista], velocidade * Time.deltaTime);
        pos.y = Mathf.MoveTowards(pos.y, verticais[vertical], velocidade * Time.deltaTime);

        transform.position = pos;
    }
}
