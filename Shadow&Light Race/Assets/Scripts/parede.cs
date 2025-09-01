using UnityEngine;

public class parede : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("Despawn", 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Despawn()
    {
        Destroy(gameObject);
    }
}
