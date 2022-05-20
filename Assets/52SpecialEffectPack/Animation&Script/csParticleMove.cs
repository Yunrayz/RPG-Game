using UnityEngine;
using System.Collections;

public class csParticleMove : MonoBehaviour
{
    public float speed = 0.02f;
    public Vector3 casterPosition;
    public Vector3 targetPosition;
    public Transform myTransform;

    public void Start()
    {
        myTransform = GetComponent<Transform>();
    }

    void Update () {

        transform.Translate((targetPosition-casterPosition) * speed / Vector3.Distance(targetPosition, casterPosition), Space.World);
        if (Vector3.Distance(myTransform.position, targetPosition) < 0.5)
        {
            Destroy(gameObject);
        }
    }
}
