using System;
using Unity.VisualScripting;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem trailEffect;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    /*void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/


    void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        Debug.Log($"trigger enter" + collision.gameObject.tag);
        if (collision.gameObject.tag == "Ground")
        {
            Debug.Log("play particles");
            trailEffect.Play();
        }
    }

    void OnCollisionExit2D(UnityEngine.Collision2D collision)
    {
        Debug.Log($"trigger exit" + collision.gameObject.tag);
        if (collision.gameObject.tag == "Ground")
        {
            trailEffect.Stop();
        }
    }
    
}
