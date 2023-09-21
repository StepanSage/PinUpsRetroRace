using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonReturnMainMenu : MonoBehaviour
{
    [SerializeField] private AudioPlay audioPlay;
    [SerializeField] private ButtonMusic buttonMusic;

    private void OnMouseUpAsButton()
    {
        audioPlay.play();
        buttonMusic.Save();
        SceneManager.LoadScene(0);
    }

    
}
