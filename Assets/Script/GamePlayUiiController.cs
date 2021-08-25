using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayUiiController : MonoBehaviour
{
    
    public void RestartGame() {
        //SceneManager.LoadScene("Gameplay");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void HomeButton() {
        SceneManager.LoadScene("MainMenu");
    }



}
