using UnityEngine.Audio;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManagerMenu : MonoBehaviour
{
    //thx to brackey's yt tutorial on sound

    public Sound[] sounds;

    public static AudioManagerMenu instance;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.loop = s.loop;
        }
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            return;
        }

        s.source.Play();
    }

    public void Start()
    {
        Play("MenuNCredits");
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Intermission"))
        {
            Destroy(gameObject);
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1"))
        {
            Destroy(gameObject);
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Boss Level"))
        {
            Destroy(gameObject);
        }
    }
}
