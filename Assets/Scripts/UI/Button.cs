using System;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    private PlayerDead _playerDead;
    private static Button _instance;
    public void OnClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        GameData.ReloadScore();
        Time.timeScale = 1;
        Debug.Log("кнопка нажата");
    }

    private void Start()
    {
//        _playerDead.GameOverEvent += Show;
       // ShowStatic();
       // Time.timeScale = 0;
    }

    private void Awake()
    { 
       _instance = this;
       
    }

    private void Show()
    {
        gameObject.SetActive(true);

    }
    
    private void Hide()
    {
        gameObject.SetActive(false);
    }

    public static void ShowStatic()
    {
        //_instance.Show();
    }
}