using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroPlusNormal : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioClip Intro;
    public AudioClip GhostNormal;

    void Start()
    {
        StartCoroutine(playAudio());
    }

    // Update is called once per frame
    IEnumerator playAudio()
    {
        GetComponent<AudioSource>().clip = Intro;
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
        GetComponent<AudioSource>().clip = GhostNormal;
        GetComponent<AudioSource>().Play();
    }
}
