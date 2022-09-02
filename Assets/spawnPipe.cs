using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using static UnityEditor.UIElements.ToolbarMenu;

public class spawnPipe : MonoBehaviour
{
    public float spawnTimer = 2f;
    public float timerCount;
    public GameObject spawnedItem;
    private float variance; 
    // Start is called before the first frame update

    public void spawnPipes()
    {
        variance = Random.Range(1.5f, 6.3f);

        Vector3 pos = new Vector3(this.transform.position.x, this.transform.position.y + variance, 1.0f);
        Quaternion q = this.transform.rotation;

        Instantiate(spawnedItem, pos, q);
    }

    void Start()
    {
        timerCount = Time.time;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        timerCount += Time.deltaTime;
        if (timerCount >= spawnTimer)
        {

            spawnPipes();
            timerCount = 0;
        }
    }
}
