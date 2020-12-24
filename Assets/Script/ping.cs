using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ping : MonoBehaviour
{

    private int _pingNumber;
    private float _timer;
    public Text pingText;

    public GameObject pingMarker;
    public GameObject[] pingLocations;

    private int _pingPicker;

    void Start()
    {
        PingNum();
        _pingPicker = Random.RandomRange(0, pingLocations.Length);

        pingMarker.transform.position = pingLocations[_pingPicker].transform.position;
    }

    void Update()
    {
        _timer += 1 * Time.deltaTime;
        if(_timer >= 1)
        {
            PingNum();
            _timer = 0;
        }
    }

    void PingNum()
    {
        _pingNumber = Random.RandomRange(10, 99);
        pingText.text = "C " + _pingNumber;
    }



}
