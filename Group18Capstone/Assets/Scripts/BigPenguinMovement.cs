// code source
// https://forum.unity.com/threads/how-to-make-an-object-move-up-and-down-on-a-loop.380159/

using UnityEngine;
using System.Collections;

public class BigPenguinMovement : MonoBehaviour
{
    public AnimationCurve myCurve;

    void Update()
    {
        transform.position = new Vector3(transform.position.x, myCurve.Evaluate((Time.time % myCurve.length)), transform.position.z);
    }
}