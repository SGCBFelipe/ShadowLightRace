using UnityEngine;

public class revisao : MonoBehaviour
{
    bool _Bool = true;
    int _Int = 10;
    float _Float = 5.5f;
    string _String = "Gustavo";

    void Start()
    {
        Welcome();
        CaucularIdade(20);
        CaucularIdade(10);
    }
    void Update()
    {
        for (int i = 0; i < _Int; i++)
        {


        

        }
    }
    void Welcome()
    {
        print("Olá, bom dia");


    }

    void CaucularIdade(int idade)
    {
        if (idade >= 18)
        {
            print("você já é um adulto!");
        }
        else
        {

            print("você ainda é uma criança");
        }


    }
}