using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMove : MonoBehaviour
{
    Transform nubesTransform;
    int startPos = 30;
    int endPos = -120;
    public double speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        nubesTransform = this.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        nubesTransform.position = new Vector3((float)(nubesTransform.position.x - speed * Time.deltaTime), nubesTransform.position.y, nubesTransform.position.z);
        if (nubesTransform.position.x <= endPos)
        {
            nubesTransform.position = new Vector3(startPos, nubesTransform.position.y, nubesTransform.position.z);
        }
    }
}
