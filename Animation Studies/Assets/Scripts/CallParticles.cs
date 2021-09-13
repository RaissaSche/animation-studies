using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallParticles : MonoBehaviour
{
    [SerializeField]
    public ParticleSystem jumpPS, shakePS, explodePS;

    [SerializeField]
    public GameObject cloud;

    void PlayJumpParticle(){
        jumpPS.Play();
    }

    void PlayShakeParticle(){
        cloud.SetActive(true);
        shakePS.Play();

    }

    void HideCloud(){
        cloud.SetActive(false);
    }

    void PlayExplodeParticle(){
        explodePS.Play();
    }
}
