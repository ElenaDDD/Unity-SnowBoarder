using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float reloadDelay = 1f;
    [SerializeField] ParticleSystem bumpEffect;
    [SerializeField] AudioClip audioClip;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("Bam");
        if (other.tag == "Ground")
        {
            Invoke("ReloadScene",reloadDelay);
            bumpEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(audioClip);
        }
    }


    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
