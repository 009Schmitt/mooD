using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButtonStage01 : MonoBehaviour
{
    
    public void Restart()
    {
        Scene cena = SceneManager.GetActiveScene();

        SceneManager.UnloadSceneAsync(cena);
        SceneManager.LoadScene(cena.buildIndex);
    }

}
