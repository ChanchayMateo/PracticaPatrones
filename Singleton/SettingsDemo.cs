using UnityEngine;

public class SettingsDemo : MonoBehaviour
{
    private void Start()
    {
        PlayerPrefsManager.Instance.SaveVolume(0.5f);

        float volume = PlayerPrefsManager.Instance.LoadVolume();
        Debug.Log("Volume: " + volume);
    }
}