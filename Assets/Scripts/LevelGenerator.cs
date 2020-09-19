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
        //GENERATE TOP LEFT QUADRANT
        for(int row = 0; row < levelMap.GetLength(0); row++)
        {
            for(int col = 0; col < levelMap.GetLength(1); col++)
            {
                if(row == 0)
                {
                    switch(levelMap[row, col])
                    {
                        case 1:
                            Instantiate(outsideCorner, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 90f));
                            break;
                        case 7:
                            Instantiate(tJunction, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            break;
                    }
                }
                else if(row == 1)
                {
                    switch(levelMap[row, col])
                    {
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 4:
                            Instantiate(insideWall, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            break;
                    }
                }
                else if(row == 2)
                {
                    switch(levelMap[row, col])
                    {
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 3:
                            if(col == 5 || col == 11)
                                Instantiate(insideCorner, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, -90f));
                            else
                                Instantiate(insideCorner, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 4:
                            if(col == 13)
                                Instantiate(insideWall, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            else
                                Instantiate(insideWall, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, -90f));
                            break;
                    }
                }
                else if(row == 3)
                {
                    switch(levelMap[row, col])
                    {
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 6:
                            Instantiate(powerPellet, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 4:
                            if(col == 5 || col == 11)
                                Instantiate(insideWall, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            else
                                Instantiate(insideWall, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 0:
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            break;
                    }
                }
                else if(row == 4)
                {
                    switch(levelMap[row, col])
                    {
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 3:
                            if(col == 5 || col == 11)
                                Instantiate(insideCorner, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            else
                                Instantiate(insideCorner, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 90f));
                            break;
                        case 4:
                            Instantiate(insideWall, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 90f));
                            break;
                    }
                }
                else if(row == 5)
                {
                    switch(levelMap[row, col])
                    {
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            break;
                    }
                }
                else if(row == 6)
                {
                    switch(levelMap[row, col])
                    {
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 3:
                            if(col == 5 || col == 8)
                                Instantiate(insideCorner, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, -90f));
                            else
                                Instantiate(insideCorner, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 4:
                            Instantiate(insideWall, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, -90f));
                            break;
                    }
                }
                else if(row == 7)
                {
                    switch(levelMap[row, col])
                    {
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 3:
                            if(col == 5)
                                Instantiate(insideCorner, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            else if(col == 2 || col == 10)
                                Instantiate(insideCorner, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 90f));
                            else
                                Instantiate(insideCorner, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 4:
                            if(col == 7)
                                Instantiate(insideWall, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            else if(col == 8)
                                Instantiate(insideWall, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            else
                                Instantiate(insideWall, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 90f));
                            break;
                    }
                }
                else if(row == 8)
                {
                    switch(levelMap[row, col])
                    {
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 4:
                            if(col == 8)
                                Instantiate(insideWall, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            else
                                Instantiate(insideWall, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            break;
                    }
                }
                else if(row == 9)
                {
                    switch(levelMap[row, col])
                    {
                        case 1:
                            if(col == 5)
                                Instantiate(outsideCorner, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, -90f));
                            else
                                Instantiate(outsideCorner, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 90f));
                            break;                        
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 90f));
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 4:
                            if(col == 7 || col == 13)
                                Instantiate(insideWall, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            else
                                Instantiate(insideWall, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, -90f));
                            break;
                        case 3:
                            if(col == 8)
                                Instantiate(insideCorner, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            else
                                Instantiate(insideCorner, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, -90f));
                            break;
                        case 0:
                            break;
                    }
                }
                else if(row == 10)
                {
                    switch(levelMap[row, col])
                    {
                        case 0:
                            break;
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 4:
                            if(col == 7 || col == 13)
                                Instantiate(insideWall, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            else
                                Instantiate(insideWall, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 90f));
                            break;
                        case 3:
                            if(col == 11)
                                Instantiate(insideCorner, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            else
                                Instantiate(insideCorner, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 90f));
                            break;
                    }
                }
                else if(row == 11)
                {
                    switch(levelMap[row, col])
                    {
                        case 0:
                            break;
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 4:
                            if(col == 7)
                                Instantiate(insideWall, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            else
                                Instantiate(insideWall, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            break;
                    }
                }
                else if(row == 12)
                {
                    switch(levelMap[row, col])
                    {
                        case 0:
                            break;
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 4:
                            if(col == 7)
                                Instantiate(insideWall, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            else if(col == 8)
                                Instantiate(insideWall, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            else
                                Instantiate(insideWall, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, -90f));
                            break;
                        case 3:
                            Instantiate(insideCorner, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            break;
                    }
                }
                else if(row == 13)
                {
                    switch(levelMap[row, col])
                    {
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 90f));
                            break;
                        case 1:
                            Instantiate(outsideCorner, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, -180f));
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 3:
                            if(col == 7)
                                Instantiate(insideCorner, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 90f));
                            if(col == 8)
                                Instantiate(insideCorner, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            break;
                        case 0:
                            break;
                        case 4:
                            Instantiate(insideWall, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            break;
                    }
                }
                else if(row == 14)
                {
                    switch(levelMap[row, col])
                    {
                        case 0:
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 4:
                            Instantiate(insideWall, transform.position = new Vector3((col - 13), (row*-1 + 14), 0), transform.rotation);
                            break;
                    }
                }
            }
        }



        //GENERATE BOTTOM LEFT QUADRANT
        for(int row = 0; row < levelMap.GetLength(0); row++)
        {
            for(int col = 0; col < levelMap.GetLength(1); col++)
            {
                if(row == 0)
                {
                    switch(levelMap[row, col])
                    {
                        case 1:
                            Transform oC = Instantiate(outsideCorner, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            oC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            break;
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col - 13), (row - 14), 0), Quaternion.Euler(0f, 0f, 90f));
                            break;
                        case 7:
                            Transform tJ = Instantiate(tJunction, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            tJ.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            break;
                    }
                }
                else if(row == 1)
                {
                    switch(levelMap[row, col])
                    {
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            break;
                        case 4:
                            Instantiate(insideWall, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            break;
                    }
                }
                else if(row == 2)
                {
                    switch(levelMap[row, col])
                    {
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            break;
                        case 3:
                            if(col == 5 || col == 11)
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col - 13), (row - 14), 0), Quaternion.Euler(0f, 0f, 90f));
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            else
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            break;
                        case 4:
                            if(col == 13)
                                Instantiate(insideWall, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            else
                                Instantiate(insideWall, transform.position = new Vector3((col - 13), (row - 14), 0), Quaternion.Euler(0f, 0f, 90f));
                            break;
                    }
                }
                else if(row == 3)
                {
                    switch(levelMap[row, col])
                    {
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            break;
                        case 6:
                            Instantiate(powerPellet, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            break;
                        case 4:
                            if(col == 5 || col == 11)
                                Instantiate(insideWall, transform.position = new Vector3((col - 13), (row - 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            else
                                Instantiate(insideWall, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            break;
                        case 0:
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            break;
                    }
                }
                else if(row == 4)
                {
                    switch(levelMap[row, col])
                    {
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            break;
                        case 3:
                            if(col == 5 || col == 11)
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col - 13), (row - 14), 0), Quaternion.Euler(0f, 0f, 180f));
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            else
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col - 13), (row - 14), 0), Quaternion.Euler(0f, 0f, -90f));
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            break;
                        case 4:
                            Instantiate(insideWall, transform.position = new Vector3((col - 13), (row - 14), 0), Quaternion.Euler(0f, 0f, -90f));
                            break;
                    }
                }
                else if(row == 5)
                {
                    switch(levelMap[row, col])
                    {
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            break;
                    }
                }
                else if(row == 6)
                {
                    switch(levelMap[row, col])
                    {
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            break;
                        case 3:
                            if(col == 5 || col == 8)
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col - 13), (row - 14), 0), Quaternion.Euler(0f, 0f, 90f));
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            else
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            break;
                        case 4:
                            Instantiate(insideWall, transform.position = new Vector3((col - 13), (row - 14), 0), Quaternion.Euler(0f, 0f, 90f));
                            break;
                    }
                }
                else if(row == 7)
                {
                    switch(levelMap[row, col])
                    {
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            break;
                        case 3:
                            if(col == 5)
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col - 13), (row - 14), 0), Quaternion.Euler(0f, 0f, 180f));
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            else if(col == 2 || col == 10)
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col - 13), (row - 14), 0), Quaternion.Euler(0f, 0f, -90f));
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            else
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            break;
                        case 4:
                            if(col == 7)
                                Instantiate(insideWall, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            else if(col == 8)
                                Instantiate(insideWall, transform.position = new Vector3((col - 13), (row - 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            else
                                Instantiate(insideWall, transform.position = new Vector3((col - 13), (row - 14), 0), Quaternion.Euler(0f, 0f, -90f));
                            break;
                    }
                }
                else if(row == 8)
                {
                    switch(levelMap[row, col])
                    {
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            break;
                        case 4:
                            if(col == 8)
                                Instantiate(insideWall, transform.position = new Vector3((col - 13), (row - 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            else
                                Instantiate(insideWall, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            break;
                    }
                }
                else if(row == 9)
                {
                    switch(levelMap[row, col])
                    {
                        case 1:
                            if(col == 5)
                                Instantiate(outsideCorner, transform.position = new Vector3((col - 13), (row - 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            else
                                Instantiate(outsideCorner, transform.position = new Vector3((col - 13), (row - 14), 0), Quaternion.Euler(0f, 0f, 0f));
                            break;                        
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col - 13), (row - 14), 0), Quaternion.Euler(0f, 0f, 90f));
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            break;
                        case 4:
                            if(col == 7 || col == 13)
                                Instantiate(insideWall, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            else
                                Instantiate(insideWall, transform.position = new Vector3((col - 13), (row - 14), 0), Quaternion.Euler(0f, 0f, 90f));
                            break;
                        case 3:
                            if(col == 8)
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            else
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col - 13), (row - 14), 0), Quaternion.Euler(0f, 0f, 90f));
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            break;
                        case 0:
                            break;
                    }
                }
                else if(row == 10)
                {
                    switch(levelMap[row, col])
                    {
                        case 0:
                            break;
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            break;
                        case 4:
                            if(col == 7 || col == 13)
                                Instantiate(insideWall, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            else
                                Instantiate(insideWall, transform.position = new Vector3((col - 13), (row - 14), 0), Quaternion.Euler(0f, 0f, -90f));
                            break;
                        case 3:
                            if(col == 11)
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col - 13), (row - 14), 0), Quaternion.Euler(0f, 0f, 180f));
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            else
                            {
                                Instantiate(insideCorner, transform.position = new Vector3((col - 13), (row - 14), 0), Quaternion.Euler(0f, 0f, 0f));
                            }
                            break;
                    }
                }
                else if(row == 11)
                {
                    switch(levelMap[row, col])
                    {
                        case 0:
                            break;
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            break;
                        case 4:
                            if(col == 7)
                                Instantiate(insideWall, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            else
                                Instantiate(insideWall, transform.position = new Vector3((col - 13), (row - 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            break;
                    }
                }
                else if(row == 12)
                {
                    switch(levelMap[row, col])
                    {
                        case 0:
                            break;
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            break;
                        case 4:
                            if(col == 7)
                                Instantiate(insideWall, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            else if(col == 8)
                                Instantiate(insideWall, transform.position = new Vector3((col - 13), (row - 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            else
                                Instantiate(insideWall, transform.position = new Vector3((col - 13), (row - 14), 0), Quaternion.Euler(0f, 0f, 90f));
                            break;
                        case 3:
                            Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            break;
                    }
                }
                else if(row == 13)
                {
                    switch(levelMap[row, col])
                    {
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col - 13), (row - 14), 0), Quaternion.Euler(0f, 0f, 90f));
                            break;
                        case 1:
                            Transform oC = Instantiate(outsideCorner, transform.position = new Vector3((col - 13), (row - 14), 0), Quaternion.Euler(0f, 0f, -180f));
                            oC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            break;
                        case 3:
                            if(col == 7)
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col - 13), (row - 14), 0), Quaternion.Euler(0f, 0f, -90f));
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            if(col == 8)
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col - 13), (row - 14), 0), Quaternion.Euler(0f, 0f, 180f));
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            break;
                        case 0:
                            break;
                        case 4:
                            Instantiate(insideWall, transform.position = new Vector3((col - 13), (row - 14), 0), transform.rotation);
                            break;
                    }
                }
            }
        }



        //GENERATE TOP RIGHT QUADRANT
        for(int row = 0; row < levelMap.GetLength(0); row++)
        {
            for(int col = 0; col < levelMap.GetLength(1); col++)
            {
                if(row == 0)
                {
                    switch(levelMap[row, col])
                    {
                        case 1:
                            Transform oC = Instantiate(outsideCorner, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            oC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            break;
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 90f));
                            break;
                        case 7:
                            Transform tJ = Instantiate(tJunction, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            tJ.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            break;
                    }
                }
                else if(row == 1)
                {
                    switch(levelMap[row, col])
                    {
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 4:
                            Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            break;
                    }
                }
                else if(row == 2)
                {
                    switch(levelMap[row, col])
                    {
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 3:
                            if(col == 5 || col == 11)
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, -90f));
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            else
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 180f));
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            break;
                        case 4:
                            if(col == 13)
                                Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            else
                                Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, -90f));
                            break;
                    }
                }
                else if(row == 3)
                {
                    switch(levelMap[row, col])
                    {
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 6:
                            Instantiate(powerPellet, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 4:
                            if(col == 5 || col == 11)
                                Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), transform.rotation);
                            else
                                Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, -180f));
                            break;
                        case 0:
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), transform.rotation);
                            break;
                    }
                }
                else if(row == 4)
                {
                    switch(levelMap[row, col])
                    {
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 3:
                            if(col == 5 || col == 11)
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), transform.rotation);
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            else
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 90f));
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            break;
                        case 4:
                            Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 90f));
                            break;
                    }
                }
                else if(row == 5)
                {
                    switch(levelMap[row, col])
                    {
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), transform.rotation);
                            break;
                    }
                }
                else if(row == 6)
                {
                    switch(levelMap[row, col])
                    {
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 3:
                            if(col == 5 || col == 8)
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, -90f));
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            else
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 180f));
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            break;
                        case 4:
                            Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, -90f));
                            break;
                    }
                }
                else if(row == 7)
                {
                    switch(levelMap[row, col])
                    {
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 3:
                            if(col == 5)
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), transform.rotation);
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            else if(col == 2 || col == 10)
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 90f));
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            else
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 180f));
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            break;
                        case 4:
                            if(col == 7)
                                Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            else if(col == 8)
                                Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), transform.rotation);
                            else
                                Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 90f));
                            break;
                    }
                }
                else if(row == 8)
                {
                    switch(levelMap[row, col])
                    {
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 4:
                            if(col == 8)
                                Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), transform.rotation);
                            else
                                Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            break;
                    }
                }
                else if(row == 9)
                {
                    switch(levelMap[row, col])
                    {
                        case 1:
                            if(col == 5)
                            {
                                Transform oC = Instantiate(outsideCorner, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, -90f));
                                oC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            else
                            {
                                Transform oC = Instantiate(outsideCorner, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 90f));
                                oC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            break;                        
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 90f));
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 4:
                            if(col == 7 || col == 13)
                                Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            else
                                Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, -90f));
                            break;
                        case 3:
                            if(col == 8)
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 180f));
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            else
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, -90f));
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            break;
                        case 0:
                            break;
                    }
                }
                else if(row == 10)
                {
                    switch(levelMap[row, col])
                    {
                        case 0:
                            break;
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 4:
                            if(col == 7 || col == 13)
                                Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            else
                                Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 90f));
                            break;
                        case 3:
                            if(col == 11)
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), transform.rotation);
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            else
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 90f));
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            break;
                    }
                }
                else if(row == 11)
                {
                    switch(levelMap[row, col])
                    {
                        case 0:
                            break;
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 4:
                            if(col == 7)
                                Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            else
                                Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), transform.rotation);
                            break;
                    }
                }
                else if(row == 12)
                {
                    switch(levelMap[row, col])
                    {
                        case 0:
                            break;
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 4:
                            if(col == 7)
                                Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            else if(col == 8)
                                Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), transform.rotation);
                            else
                                Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, -90f));
                            break;
                        case 3:
                        {
                            Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                        }
                            break;
                    }
                }
                else if(row == 13)
                {
                    switch(levelMap[row, col])
                    {
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 90f));
                            break;
                        case 1:
                        {
                            Transform oC = Instantiate(outsideCorner, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), transform.rotation);
                            oC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                        }
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 3:
                            if(col == 7)
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 90f));
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            if(col == 8)
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), transform.rotation);
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            break;
                        case 0:
                            break;
                        case 4:
                            Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            break;
                    }
                }
                else if(row == 14)
                {
                    switch(levelMap[row, col])
                    {
                        case 0:
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), transform.rotation);
                            break;
                        case 4:
                            Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row*-1 + 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            break;
                    }
                }
            }
        }


        
        //GENERATE BOTTOM RIGHT QUADRANT
        for(int row = 0; row < levelMap.GetLength(0); row++)
        {
            for(int col = 0; col < levelMap.GetLength(1); col++)
            {
                if(row == 0)
                {
                    switch(levelMap[row, col])
                    {
                        case 1:
                            Instantiate(outsideCorner, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            break;
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), Quaternion.Euler(0f, 0f, 90f));
                            break;
                        case 7:
                            Instantiate(tJunction, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            break;
                    }
                }
                else if(row == 1)
                {
                    switch(levelMap[row, col])
                    {
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), transform.rotation);
                            break;
                        case 4:
                            Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            break;
                    }
                }
                else if(row == 2)
                {
                    switch(levelMap[row, col])
                    {
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), transform.rotation);
                            break;
                        case 3:
                            if(col == 5 || col == 11)
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), transform.rotation);
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            else
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), Quaternion.Euler(0f, 0f, 90f));
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            break;
                        case 4:
                            if(col == 13)
                                Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            else
                                Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), Quaternion.Euler(0f, 0f, 90f));
                            break;
                    }
                }
                else if(row == 3)
                {
                    switch(levelMap[row, col])
                    {
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), transform.rotation);
                            break;
                        case 6:
                            Instantiate(powerPellet, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), transform.rotation);
                            break;
                        case 4:
                            if(col == 5 || col == 11)
                                Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), transform.rotation);
                            else
                                Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            break;
                        case 0:
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), transform.rotation);
                            break;
                    }
                }
                else if(row == 4)
                {
                    switch(levelMap[row, col])
                    {
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), transform.rotation);
                            break;
                        case 3:
                            if(col == 5 || col == 11)
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), Quaternion.Euler(0f, 0f, -90f));
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            else
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), Quaternion.Euler(0f, 0f, 180f));
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            break;
                        case 4:
                            Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), Quaternion.Euler(0f, 0f, -90f));
                            break;
                    }
                }
                else if(row == 5)
                {
                    switch(levelMap[row, col])
                    {
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), transform.rotation);
                            break;
                    }
                }
                else if(row == 6)
                {
                    switch(levelMap[row, col])
                    {
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), transform.rotation);
                            break;
                        case 3:
                            if(col == 5 || col == 8)
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), transform.rotation);
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            else
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), Quaternion.Euler(0f, 0f, 90f));
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            break;
                        case 4:
                            Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), Quaternion.Euler(0f, 0f, 90f));
                            break;
                    }
                }
                else if(row == 7)
                {
                    switch(levelMap[row, col])
                    {
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), transform.rotation);
                            break;
                        case 3:
                            if(col == 5)
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), Quaternion.Euler(0f, 0f, -90f));
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            else if(col == 2 || col == 10)
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), Quaternion.Euler(0f, 0f, 180f));
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            else
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), Quaternion.Euler(0f, 0f, 90f));
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            break;
                        case 4:
                            if(col == 7)
                                Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            else if(col == 8)
                                Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), transform.rotation);
                            else
                                Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), Quaternion.Euler(0f, 0f, -90f));
                            break;
                    }
                }
                else if(row == 8)
                {
                    switch(levelMap[row, col])
                    {
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), transform.rotation);
                            break;
                        case 4:
                            if(col == 8)
                                Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), transform.rotation);
                            else
                                Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            break;
                    }
                }
                else if(row == 9)
                {
                    switch(levelMap[row, col])
                    {
                        case 1:
                            if(col == 5)
                                Instantiate(outsideCorner, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), Quaternion.Euler(0f, 0f, 90f));
                            else
                                Instantiate(outsideCorner, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), Quaternion.Euler(0f, 0f, -90f));
                            break;                        
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), Quaternion.Euler(0f, 0f, 90f));
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), transform.rotation);
                            break;
                        case 4:
                            if(col == 7 || col == 13)
                                Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            else
                                Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), Quaternion.Euler(0f, 0f, 90f));
                            break;
                        case 3:
                            if(col == 8)
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), Quaternion.Euler(0f, 0f, 90f));
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            else
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), transform.rotation);
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            break;
                        case 0:
                            break;
                    }
                }
                else if(row == 10)
                {
                    switch(levelMap[row, col])
                    {
                        case 0:
                            break;
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), transform.rotation);
                            break;
                        case 4:
                            if(col == 7 || col == 13)
                                Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            else
                                Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), Quaternion.Euler(0f, 0f, -90f));
                            break;
                        case 3:
                            if(col == 11)
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), Quaternion.Euler(0f, 0f, -90f));
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            else
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), Quaternion.Euler(0f, 0f, 180f));
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            break;
                    }
                }
                else if(row == 11)
                {
                    switch(levelMap[row, col])
                    {
                        case 0:
                            break;
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), transform.rotation);
                            break;
                        case 4:
                            if(col == 7)
                                Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            else
                                Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), transform.rotation);
                            break;
                    }
                }
                else if(row == 12)
                {
                    switch(levelMap[row, col])
                    {
                        case 0:
                            break;
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), transform.rotation);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), transform.rotation);
                            break;
                        case 4:
                            if(col == 7)
                                Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), Quaternion.Euler(0f, 0f, 180f));
                            else if(col == 8)
                                Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), transform.rotation);
                            else
                                Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), Quaternion.Euler(0f, 0f, 90f));
                            break;
                        case 3:
                            Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), Quaternion.Euler(0f, 0f, 90f));
                            iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            break;
                    }
                }
                else if(row == 13)
                {
                    switch(levelMap[row, col])
                    {
                        case 2:
                            Instantiate(outsideWall, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), Quaternion.Euler(0f, 0f, 90f));
                            break;
                        case 1:
                            Transform oC = Instantiate(outsideCorner, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), Quaternion.Euler(0f, 0f, -90f));
                            oC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            break;
                        case 5:
                            Instantiate(standardPellet, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), transform.rotation);
                            break;
                        case 3:
                            if(col == 7)
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), Quaternion.Euler(0f, 0f, 180f));
                                iC.transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y*-1, transform.localScale.z);
                            }
                            if(col == 8)
                            {
                                Transform iC = Instantiate(insideCorner, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), transform.rotation);
                            }
                            break;
                        case 0:
                            break;
                        case 4:
                            Instantiate(insideWall, transform.position = new Vector3((col*-1 + 14), (row - 14), 0), Quaternion.Euler(0f, 0f, 180f));
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
