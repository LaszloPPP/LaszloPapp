
using UnityEngine;

class PathMover : MonoBehaviour
{
    [SerializeField] Vector3 point1, point2;
    [SerializeField] float speed;

    [SerializeField, Range(0, 1)] float startPosition;

    [SerializeField] Color color1, color2;

    bool forward;

    void OnValidate()
    {

        transform.position = Vector3.Lerp(point1, point2, startPosition);
    }

    void Start()
    {
        //transform.position = point1;
        forward = true;
    }
    void Update()
    {

        //Vector3 target = forward ? point2 : point1;
        Vector3 target;
        if (forward)
        {
            target = point2;
        }
        else
        {
            target = point1;
        }
        
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if (transform.position == target)
        {
            forward = !forward;
        }
    }

    void OnDrawGizmos() //fejleszt� eszk�z. j�t�k k�zben nem fut
    {
        Gizmos.color = Color.Lerp(color1,color2,startPosition);
        Gizmos.DrawWireSphere(point1, 0.2f);
        Gizmos.DrawWireSphere(point2, 0.2f);
        Gizmos.DrawLine(point1, point2);
    }

}
