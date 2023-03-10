using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class tree : MonoBehaviour
{

    public AudioSource treeHitSound;
    public Color hitColor;      // The color we want to set when we get hit.
    public MeshRenderer mr;     // A reference to the MeshRenderer component.
                                // Called when another object collides with us.
    void Start()
    {
        treeHitSound = GetComponent<AudioSource>();
    }

    void OnCollisionEnter(Collision collision)
    {
        // Set our color to be "hitColor".
        mr.material.color = hitColor;
        
        treeHitSound.Play();
    }
}
