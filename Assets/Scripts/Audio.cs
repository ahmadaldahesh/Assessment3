using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    [SerializeField] private AudioSource foxMoving;
    private float globalCounter = 0f;
    private bool soundOn = false;
    
    // Start is called before the first frame update
    void Start()
    {
        foxMoving.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        globalCounter += Time.deltaTime;
        
        if(globalCounter > 5)
        {        
            if(soundOn == false)
            {
                soundOn = true;
                foxMoving.Play();
            }
        }
    }
}
