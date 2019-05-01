using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour { //class for management sounds


    public static AudioClip blaster, stone, death, bonus, comet;
    static AudioSource audioSrc;

	void Start () {
        blaster = Resources.Load<AudioClip>("blaster");
        stone = Resources.Load<AudioClip>("stone");
        death = Resources.Load<AudioClip>("death");
        bonus = Resources.Load<AudioClip>("bonus");
        comet = Resources.Load<AudioClip>("comet");
        audioSrc = GetComponent<AudioSource>();
    }
	

	void Update () {
		
	}

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "blaster":
                audioSrc.PlayOneShot(blaster);
                break;
            case "stone":
                audioSrc.PlayOneShot(stone);
                break;
            case "death":
                audioSrc.PlayOneShot(death);
                break;
            case "bonus":
                audioSrc.PlayOneShot(bonus);
                break;
            case "comet":
                audioSrc.PlayOneShot(comet);
                break;
        }

    }
}
