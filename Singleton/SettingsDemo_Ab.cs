using UnityEngine;

public class SettingsDemo_Ab : MonoBehaviour
{
    private void Start()
    {
        PreferencesService.Instance.SaveVolume(0.5f);

        float volume = PreferencesService.Instance.LoadVolume();

        Debug.Log("Volume: " + volume);

        PreferencesService.Instance.SavePlayerName("John Doe");

        string playerName = PreferencesService.Instance.LoadPlayerName();
        Debug.Log("Player Name: " + playerName);
    }
}