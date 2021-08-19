using UnityEngine;
using UnityEngine.SceneManagement;

public class ZoneOut : MonoBehaviour, IZoneOut
{
    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+0);
    }
}
