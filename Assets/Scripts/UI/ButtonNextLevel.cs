using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonNextLevel : MonoBehaviour
{
    [SerializeField] private int _nextLevel;

    private void OnMouseUpAsButton()
    {
        SceneManager.LoadScene(_nextLevel);
    }
}
