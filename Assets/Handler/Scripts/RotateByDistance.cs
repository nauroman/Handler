using UnityEngine;
using System.Collections;

namespace Flashunity.Handler
{
    public class RotateByDistance : InteractByTrigger
    {
        override protected void Interact(float scale)
        {
//            var s = 1 - scale;

            transform.Rotate(Vector3.up, scale * 5);

//            transform.localRotation = new Quaternion(1, 1, 1, s);
            //         sphereCollider.radius = sphereColliderRadius / s;
        }
    }
}