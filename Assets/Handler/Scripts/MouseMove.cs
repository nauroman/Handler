using UnityEngine;
using System.Collections;

namespace Flashunity.Handler
{

    public class MouseMove : MonoBehaviour
    {
        void Update()
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            transform.position = ray.GetPoint(Mathf.Abs(Camera.main.transform.position.z));
        }
    }
}