using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallAnimEvents : MonoBehaviour
{
    [SerializeField]
    public ParticleSystem jumpPS, shakePS, explodePS;

    [SerializeField]
    public GameObject cloud;

    [SerializeField]
    public AudioSource jumpAS1, jumpAS2, shakeAS, explodeAS1, explodeAS2;

        //audioSource.Play();

    void PlayFirstJumpParticle(){
        jumpAS1.Play();
        jumpPS.Play();
    }

    void PlaySecondJumpParticle(){
        jumpAS2.Play();
        jumpPS.Play();
    }

    void PlayShakeParticle(){
        cloud.SetActive(true);
        shakeAS.Play();
        shakePS.Play();
    }

    void HideCloud(){
        cloud.SetActive(false);
    }

    void PlayInflateSound(){
        explodeAS1.Play();
    }

    void PlayExplodeParticle(){
        explodeAS2.Play();
        explodePS.Play();
    }
}
