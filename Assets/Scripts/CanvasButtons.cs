using UnityEngine;
using UnityEngine.SceneManagement;
public class CanvasButtons : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void toYoutube()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=VFz9GkGTGRU&t=635s&ab_channel=A.I.Channel");
    }

}
