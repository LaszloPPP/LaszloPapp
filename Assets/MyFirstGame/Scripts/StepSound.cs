using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepSound : MonoBehaviour
{
    [SerializeField] AudioSource[] sources;

    private void OnValidate()
    {
        sources = GetComponentsInChildren<AudioSource>();
    }

    public void FootStepSound()
    {
        int randomIndex = Random.Range(0, sources.Length);
        AudioSource source = sources[randomIndex];
        source.Play();

        //sources[Random.Range(0, sources.Length)].Play();  ugyanaz mint az elõzõ 3 sor, csak egyben
        
    }
}
