using System;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    //public  event Action GameOverEvent;
    //public Button button;
    private void OnDestroy()
    {
        //GameData.score = 0;
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //GameOverEvent?.Invoke();
        //Time.timeScale = 0;
    }
}
