using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GizmoThumper : MonoBehaviour
{
    [SerializeField] Transform aimingPoint;
    [SerializeField] float maxExplosionForce;
    [SerializeField] float explosionRange;
    [SerializeField] float upwardModifier;
    [SerializeField] float maxGizmoDistance;
    [SerializeField] Color lineColor;
    private void Update()
    {

        Vector3 clickPosition = Input.mousePosition;
        Ray ray = Camera.main.ScreenPointToRay(clickPosition);

        bool isHit = Physics.Raycast(ray, out RaycastHit hitInfo);

        if (isHit)
        {
            //Debug.Log($"Hit: {hitInfo.collider.name}");
            aimingPoint.position = hitInfo.point;
        }
        else
        {
            aimingPoint.position = Vector3.up * 1000;
        }

        bool click = Input.GetMouseButtonDown(0); 

        if (isHit && click)
        {
            //itt robbantunk kattintásra

            Rigidbody[] rbs = FindObjectsOfType<Rigidbody>(); 

            for (int i = 0; i < rbs.Length; i++)
            {
                Rigidbody rb = rbs[i]; 

                //rb.AddForce(new Vector3((rb.transform.position.x/3), upwardModifier, (rb.transform.position.z/3)),ForceMode.Impulse);
                rb.AddExplosionForce(maxExplosionForce, hitInfo.point, explosionRange,upwardModifier);

            }
        }
    }

    private void OnDrawGizmos()
    {

        Rigidbody[] rbs = FindObjectsOfType<Rigidbody>();

        for (int i = 0; i < rbs.Length; i++)
        {
            Gizmos.color = lineColor;
            Rigidbody rb = rbs[i];
            float distance = Vector3.Distance(transform.position, rb.transform.position);
            //Debug.Log(distance);
            if(distance<maxGizmoDistance)
            Gizmos.DrawLine(transform.position, rb.transform.position);

        }

    }
}
