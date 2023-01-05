using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeTunnel : MonoBehaviour
{
    public GameObject tunnel;
    float timer = 0;
    public float timeDiff = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timeDiff)
        {
            timeDiff = Random.Range(2.0f, 3.0f);
            GameObject tunnelIns = Instantiate(tunnel);
            tunnelIns.transform.position = new Vector3(5, Random.Range(-0.2f, 2.5f), 0);
            timer = 0;
            Destroy(tunnelIns, 10.0f);
        }
    }
}
