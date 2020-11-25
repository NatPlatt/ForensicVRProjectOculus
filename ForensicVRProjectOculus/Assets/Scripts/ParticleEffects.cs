using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ParticleEffects : MonoBehaviour
{
    public ParticleSystem particleSystem;
    
    // Start is called before the first frame update
    void Start()
    {
        //Simple particle system with no texture
        Material particleMaterial = new Material(Shader.Find("Particles/Standard Unlit"));
        
        //Create a new cyan particle system
        var go = new GameObject("Particle System");
        particleSystem = go.AddComponent<ParticleSystem>();
        go.GetComponent<ParticleSystemRenderer>().material = particleMaterial;
        var mainModule = particleSystem.main;
        mainModule.startColor = Color.cyan;
        mainModule.startSize = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DoEmit()
    {
        //any parameters we assign in emitParams will override the current systems when we call Emit
        //here we are currently overriding the start color and size
        var emitParams = new ParticleSystem.EmitParams();
        emitParams.startColor = Color.clear;
        emitParams.startSize = 0.2f;
        particleSystem.Emit(emitParams, 10);
        particleSystem.Play();
    }
}
