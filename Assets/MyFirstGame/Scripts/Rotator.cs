
using UnityEngine;

class Rotator : MonoBehaviour
{
    [SerializeField] float angularSpeed;
    [SerializeField] Space rotationSpace;
    [SerializeField] Vector3 axis=Vector3.up;

    void Update()
    {
        float angle = angularSpeed * Time.deltaTime;
        transform.Rotate(axis, angle,rotationSpace);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Vector3 center = transform.position;

        Vector3 dir = axis.normalized;

        if (rotationSpace == Space.Self)
        {
            dir=transform.TransformDirection(dir); //lokális koordinátából csinál világkoordinátát. fordítva pedig InverseTransformDirection
        }

        Vector3 a =center+dir;
        Vector3 b =center-dir;
        Gizmos.DrawLine(a, b);
    }
}
