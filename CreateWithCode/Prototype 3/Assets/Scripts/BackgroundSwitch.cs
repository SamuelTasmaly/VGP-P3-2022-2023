using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSwitch : MonoBehaviour
{
    private RepeatBackground ForestBackground;
     private Vector3 startPos;
    private float repeatWidth = 50.0f;
    public float backCount =0;
    // Start is called before the first frame update
    void Start()
    {
    ForestBackground =
      GameObject.Find("Background").GetComponent<RepeatBackground>();
      startPos = transform.position;
      repeatWidth =GetComponent<BoxCollider>().size.x / 2;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (backCount == 10){
            if (transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;}
            
        }
        
    }
}
