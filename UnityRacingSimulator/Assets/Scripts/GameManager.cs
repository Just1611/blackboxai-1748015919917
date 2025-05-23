using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Manages game flow: main menu, car selection, career progression, and scene loading.
/// </summary>
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int selectedCarIndex = 0;
    public int currentCareerProgress = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void StartGame()
    {
        // Load the first race scene or main gameplay scene
        SceneManager.LoadScene("RaceTrack");
    }

    public void SelectCar(int carIndex)
    {
        selectedCarIndex = carIndex;
        // TODO: Update car selection UI and load car prefab
    }

    public void ProgressCareer()
    {
        currentCareerProgress++;
        // TODO: Save progress and unlock new content
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
