using UnityEngine;

public class MissionManager : MonoBehaviour
{
    public static MissionManager Instance;

    [SerializeField]
    GameObject aiPlanePrefab;
    [SerializeField]
    Transform spawnPoint;
    [SerializeField]
    Target playerTarget;

    int totalTargets;
    int destroyedCount;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        totalTargets = FindObjectsOfType<GroundTarget>().Length;
        destroyedCount = 0;
    }

    public void OnGroundTargetDestroyed()
    {
        destroyedCount++;
        if (destroyedCount >= totalTargets)
        {
            SpawnBossPlane();
        }
    }

    void SpawnBossPlane()
    {
        var spawnedObj = Instantiate(aiPlanePrefab, spawnPoint.position, spawnPoint.rotation);
        var aiPlane = spawnedObj.GetComponent<Plane>();
        aiPlane.Target = playerTarget;
    }
}