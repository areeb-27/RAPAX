using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField]
    Plane playerPlane;
    [SerializeField]
    Plane enemyPlane;
    [SerializeField]
    GameObject winPanel;
    [SerializeField]
    GameObject losePanel;
    [SerializeField]
    GameObject hud;

    bool gameOver;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        winPanel.SetActive(false);
        losePanel.SetActive(false);
    }

    public void SetEnemyPlane(Plane plane)
    {
        enemyPlane = plane;
    }

    void Update()
    {
        if (gameOver) return;

        if (playerPlane.Dead)
        {
            gameOver = true;
            hud.SetActive(false);
            losePanel.SetActive(true);
            return;
        }

        if (enemyPlane != null && enemyPlane.Dead)
        {
            gameOver = true;
            winPanel.SetActive(true);
        }
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}