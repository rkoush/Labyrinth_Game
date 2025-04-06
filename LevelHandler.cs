using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public void Level1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void exit()
    {
        SceneManager.LoadScene("Menu Screen");
    }
}
