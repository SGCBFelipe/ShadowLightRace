using UnityEngine;
using UnityEngine.SceneManagement;

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

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Dead");
            print("colidiu");
        }
    }

}
