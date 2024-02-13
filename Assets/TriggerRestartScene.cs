using UnityEngine.SceneManagement;
using UnityEngine;

public class TriggerRestartScene : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(2);
    }
}
