using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip fireSound, enemyDeathSound, playerDeathSound;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        fireSound = Resources.Load<AudioClip> ("ImpactBig8Bit GFX030903");
        enemyDeathSound = Resources.Load<AudioClip> ("mi_explosion_03_hpx");
        playerDeathSound = Resources.Load<AudioClip> ("Sad Trombone Wah Wah Wah Fail Sound Effect");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "fire":
                audioSrc.PlayOneShot (fireSound);
                break;
            case "enemyDeath":
                audioSrc.PlayOneShot (enemyDeathSound);
                break;
            case "playerDeathSound":
                audioSrc.PlayOneShot (playerDeathSound);
                break;
        }
    }
}
