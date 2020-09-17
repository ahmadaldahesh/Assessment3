using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public Transform outsideCorner;
    public Transform outsideWall;
    public Transform insideCorner;
    public Transform insideWall;
    public Transform standardPellet;
    public Transform powerPellet;
    public Transform tJunction;
    
    int[,] levelMap =
    {
        {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
        {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
        {2,5,3,4,4,3,5,3,4,4,4,3,5,4},
        {2,6,4,0,0,4,5,4,0,0,0,4,5,4},
        {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
        {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
        {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
        {2,5,3,4,4,3,5,4,4,5,3,4,4,3},
        {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
        {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
        {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
        {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
        {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
        {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
        {0,0,0,0,0,0,5,0,0,0,4,0,0,0},
    };
 
 // Start is called before the first frame update
    void Start()
    {
        //Instantiate(outsideWall, transform.position = new Vector3(-1f, -1f, -1f), Quaternion.Euler(0f, 0f, 90f));

        for(int row = 0; row < levelMap.GetLength(0); row++)
        {
            for(int col = 0; col < levelMap.GetLength(1); col++)
            {
                // Debug.Log(levelMap[col,row]);

                if(row == 0)
                {
                    switch(levelMap[row, col])
                    {
                        case 1:
                            Debug.Log("CASE IS 1");
                            Instantiate(outsideCorner, transform.position = new Vector3((col - 13), (row + 14), 0), transform.rotation);
                            break;
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col - 13), (row + 14), 0), Quaternion.Euler(0f, 0f, 90f));
                            break;
                        case 7:
                            Instantiate(tJunction, transform.position = new Vector3((col - 13), (row + 14), 0), transform.rotation);
                            break;
                    }
                }
            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
