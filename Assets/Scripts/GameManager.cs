using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake(){
        if (instance == null){
        instance = this;
        DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }

    public void NextLevel(){
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadScene(string sceneName){
        SceneManager.LoadSceneAsync(sceneName);
    }

}