using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour
{
    public static PlayerPrefsManager Instance { get; private set; }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

    }
    public void SaveVolume(float volume)
    {
        UnityEngine.PlayerPrefs.SetFloat("Volume", volume);
        UnityEngine.PlayerPrefs.Save();
    }
    public float LoadVolume()
    {
        return UnityEngine.PlayerPrefs.GetFloat("Volume", 1f);
    }
}