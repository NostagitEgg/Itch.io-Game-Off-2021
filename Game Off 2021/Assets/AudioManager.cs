using UnityEngine.Audio;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    //thx to brackey's yt tutorial on sound

    public Sound[] sounds;

    // Start is called before the first frame update
    void Awake()
    {
        foreach  (Sound s in sounds)
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

    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            return;
        }

        s.source.Stop();
    }

    void Start()
    {

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Menu"))
        {
            Play("MenuNCredits");
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Intermission"))
        {
            Stop("MenuNCredits");
            Play("Intro");
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Level1"))
        {
            Stop("Intro");
            Play("Spider");
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Intro"))
        {
            Stop("Spider");
            Play("BossIntro");
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("Boss Level"))
        {
            Stop("BossIntro");
            Play("Boss");
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("End Credits"))
        {
            Stop("Boss");
            Play("Credits");
        }


    }

}

