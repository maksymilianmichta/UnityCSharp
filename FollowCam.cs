using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;

    // Update is called once per frame
    void LateUpdate()
    {
         transform.position = thingToFollow.transform.position + new Vector3 (0,0,-10); 
         // new Vector zmaist recznego ustwienia - 10 oddalenia kamery

    }
}
