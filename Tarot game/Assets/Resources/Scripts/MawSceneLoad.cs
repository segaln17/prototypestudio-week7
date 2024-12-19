using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MawSceneLoad : MonoBehaviour
{
    private Scene currentScene;

    public Animator cameraAnimator;

    public AudioSource crunchHolder;
    public AudioClip crunch;

    public AudioSource screamHolder;
    public AudioClip scream;

    public GameObject cameraAnimationHolder;
    // Start is called before the first frame update
    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        cameraAnimator = cameraAnimationHolder.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(MawConsume());
        }
    }
    
    public void LoadNext()
    {
        SceneManager.LoadScene(currentScene.buildIndex + 1);
    }
    
    IEnumerator MawConsume()
    {
        cameraAnimator.SetTrigger("Active");
        yield return new WaitForSeconds(0.4f);
        screamHolder.PlayOneShot(scream);
        yield return new WaitForSeconds(0.4f);
        crunchHolder.PlayOneShot(crunch);
        //cameraAnimator.Play("CameraAnim");
        yield return new WaitForSeconds(10f);
        LoadNext();
    }
}
