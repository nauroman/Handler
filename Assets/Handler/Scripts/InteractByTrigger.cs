using UnityEngine;
using System.Collections;
using System;

namespace Flashunity.Handler
{
    public abstract class InteractByTrigger : MonoBehaviour
    {
        protected float sphereColliderRadius;
        protected SphereCollider sphereCollider;

        void Awake()
        {
            sphereCollider = GetComponent<SphereCollider>();

            if (sphereCollider == null)
                throw new Exception("Add a sphereCollider first!");

            sphereColliderRadius = sphereCollider.radius;
            if (sphereColliderRadius == 0)
                throw new Exception("sphereCollider radius should be more than 0!");
            
        }

        void OnTriggerStay(Collider other)
        {
            if (sphereColliderRadius > 0)
            {
//                Debug.Log("sphereColliderRadius: " + sphereColliderRadius);

                var distance = Vector3.Distance(other.transform.position, transform.position);

                //              Debug.Log("1 - distance / sphereColliderRadius: " + (1 - distance / sphereColliderRadius));

                Interact(1 - distance / sphereColliderRadius);
            }
        }

        void OnTriggerExit(Collider other)
        {
            Interact(0);
        }

        abstract protected void Interact(float scale);
    }
}