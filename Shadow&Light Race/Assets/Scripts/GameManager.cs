using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("GameObjects de Spawn (at� 6)")]
    public GameObject[] spawnPoints = new GameObject[6];

    [Header("Prefab a ser Instanciado")]
    public GameObject prefab;

    [Header("For�a Aplicada")]
    public float force = 500f;

    public int Score;

    void Start()
    {

        InvokeRepeating("SpawnPrefab", 2f, 1f);
        InvokeRepeating("pontuacao", 0.1f, 0.1f);
    }


    public void pontuacao()
    {
        Score++;
    }

    public void SpawnPrefab()
    {
        // Verifica se h� pelo menos um ponto de spawn configurado
        if (spawnPoints.Length == 0)
        {
            Debug.LogError("Nenhum ponto de spawn foi configurado!");
            return;
        }

        // Escolhe aleatoriamente um dos pontos de spawn
        int randomIndex = Random.Range(0, spawnPoints.Length);
        GameObject chosenSpawnPoint = spawnPoints[randomIndex];

        // Instancia o prefab na posi��o e rota��o do ponto escolhido
        GameObject spawnedObject = Instantiate(prefab, chosenSpawnPoint.transform.position, chosenSpawnPoint.transform.rotation);

        // Verifica se o objeto instanciado possui um Rigidbody
        Rigidbody rb = spawnedObject.GetComponent<Rigidbody>();
        if (rb != null)
        {
            // Aplica uma for�a na dire��o negativa do eixo Z
            rb.AddForce(Vector3.back * force);
        }
        else
        {
            Debug.LogWarning("O prefab instanciado n�o possui um Rigidbody para aplicar a for�a.");
        }
    }
}
