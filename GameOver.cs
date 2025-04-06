using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
void OnTriggerEnter(Collider other)
    {
        GameObject.Find("FPSController").SendMessage("Finnish"); //to instruct timer script to stop the timer
        SceneManager.LoadScene("GameOver"); //To transition to the game over scene
    }
}
