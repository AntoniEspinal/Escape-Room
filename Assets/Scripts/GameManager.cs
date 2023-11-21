using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject door;
    public GameObject key;
    public bool keyStatus = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (key == false)
        {
            keyStatus = false;
        }
        
        if (keyStatus == false)
        {
            Destroy(door);
        }
    }
}
