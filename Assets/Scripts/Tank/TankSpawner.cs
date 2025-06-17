using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public GameObject tankPrefab;   // El prefab del tanque
    public int numberOfTanks = 10;  // Número de tanques a crear
    public Vector3 mapSize = new Vector3(100f, 0f, 100f);  // Tamaño del mapa (ajusta según tu mapa)

    void Start()
    {
        SpawnTanks();
    }

    void SpawnTanks()
    {
        for (int i = 0; i < numberOfTanks; i++)
        {
            Vector3 randomPosition = new Vector3(
                Random.Range(-mapSize.x / 2, mapSize.x / 2),
                0f,  // Y fijo para el suelo
                Random.Range(-mapSize.z / 2, mapSize.z / 2)
            );

            Instantiate(tankPrefab, randomPosition, Quaternion.identity);
        }
    }
}
