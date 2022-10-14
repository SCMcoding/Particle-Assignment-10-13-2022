using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public ParticleSystem particles;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            particles.Play();
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            particles.Stop();
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            particles.Play();
        }

        if (Input.GetKeyUp(KeyCode.B))
        {
            particles.Stop();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            particles.Play();
        }

        if (Input.GetKeyUp(KeyCode.C))
        {
            particles.Stop();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            particles.Play();
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            particles.Stop();
        }


    }
}
