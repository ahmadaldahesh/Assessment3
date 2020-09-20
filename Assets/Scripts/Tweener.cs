using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tweener : MonoBehaviour
{
    private GameObject quacman;
    private float counter = 0f;
    private float startTime = 0f;
    private float timeFraction = 0f;
    private Vector3 topLeft = new Vector3(-12f, 13f, 0f);
    private Vector3 topRight = new Vector3(-7f, 13f, 0f);
    private Vector3 bottomLeft = new Vector3(-12f, 9f, 0f);
    private Vector3 bottomRight = new Vector3(-7f, 9f, 0f);
    private float position = 0f;

    [SerializeField] private AudioSource quacmanMoving;
    private float globalCounter = 0f;

    private bool soundOn = false;

    
    // Start is called before the first frame update
    void Start()
    {
        quacman = GameObject.Find("Quac-Man");
        quacmanMoving.Stop();
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
                quacmanMoving.Play();
            }
            
            if(quacman.transform.position == topLeft)
            {
                counter = 0;
                position = 1;
                quacman.transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                quacman.transform.localScale = new Vector3(1f, 1f, 1f);
            }
            else if(quacman.transform.position == topRight)
            {
                counter = 0;
                position = 2;
                quacman.transform.rotation = Quaternion.Euler(0f, 0f, -90f);
            }
            else if(quacman.transform.position == bottomRight)
            {
                counter = 0;
                position = 3;
                quacman.transform.rotation = Quaternion.Euler(0f, 0f, 180f);
                quacman.transform.localScale = new Vector3(1f, -1f, 1f);
            }
            else if(quacman.transform.position == bottomLeft)
            {
                counter = 0;
                position = 4;
                quacman.transform.rotation = Quaternion.Euler(0f, 0f, 90f);
            }
            
            switch(position)
            {
                case 1:
                    {
                        counter += Time.deltaTime;
                        timeFraction = (counter - startTime)/ 10f;
                        quacman.transform.position = Vector3.Lerp(quacman.transform.position, topRight, timeFraction);
                    }
                    break;
                case 2:
                    {
                        counter += Time.deltaTime;
                        timeFraction = (counter - startTime)/ 10f;
                        quacman.transform.position = Vector3.Lerp(quacman.transform.position, bottomRight, timeFraction);
                    }
                    break;
                case 3:
                    {
                        counter += Time.deltaTime;
                        timeFraction = (counter - startTime)/ 10f;
                        quacman.transform.position = Vector3.Lerp(quacman.transform.position, bottomLeft, timeFraction);
                    }
                    break;
                case 4:
                    {
                        counter += Time.deltaTime;
                        timeFraction = (counter - startTime)/ 10f;
                        quacman.transform.position = Vector3.Lerp(quacman.transform.position, topLeft, timeFraction);
                    }
                    break;
            }
        }
    }
}
