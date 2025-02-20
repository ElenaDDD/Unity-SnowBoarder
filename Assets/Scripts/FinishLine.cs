using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

    [SerializeField] float reloadDelay = 1f;
    [SerializeField] ParticleSystem finishEffect;
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
        if (other.tag == "Player")
        {
            Debug.Log("You finished!");
           Invoke("ReloadScene", reloadDelay);
           finishEffect.Play();
        }
    }

    
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
