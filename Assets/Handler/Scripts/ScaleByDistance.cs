using UnityEngine;
using System.Collections;

namespace Flashunity.Handler
{
    public class ScaleByDistance : InteractByTrigger
    {
        override protected void Interact(float scale)
        {
            var s = 1 - scale;
            transform.localScale = new Vector3(s, s, s);
            sphereCollider.radius = sphereColliderRadius / s;
        }
    }
}