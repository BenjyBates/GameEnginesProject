using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City_Builder : MonoBehaviour
{

    public GameObject[] squares;
    public int mapWidth = 5;
    public int mapHeight = 5;
    private int _footprint = 3;

    void Start()
    {
        float seed = Random.Range(0, 500);
        for (int h = 0; h < mapHeight; h++)
        {
            for (int w = 0; w < mapWidth; w++)
            {
                int result = (int)(Mathf.PerlinNoise(w / 10.0f + seed, h / 10.0f + seed) * 10);
                Vector3 pos = new Vector3(w * _footprint, 0, h * _footprint);

                if (result < 2)
                    Instantiate(squares[0], pos, Quaternion.identity);
                else if (result < 3)
                    Instantiate(squares[1], pos, Quaternion.identity);
                else if (result < 4)
                    Instantiate(squares[2], pos, Quaternion.identity);
                else if (result < 5)
                    Instantiate(squares[3], pos, Quaternion.identity);
                else if (result < 6)
                    Instantiate(squares[4], pos, Quaternion.identity);
                else if (result < 7)
                    Instantiate(squares[5], pos, Quaternion.identity);
                else if (result < 8)
                    Instantiate(squares[6], pos, Quaternion.identity);
                else if (result < 9)
                    Instantiate(squares[7], pos, Quaternion.identity);
                else if (result < 10)
                    Instantiate(squares[8], pos, Quaternion.identity);

            }
        }
    }


    void Update()
    {
        
    }



}
