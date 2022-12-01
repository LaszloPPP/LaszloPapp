using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickExplosion : MonoBehaviour
{
    [SerializeField] Transform aimingPoint;
    [SerializeField] float maxExplosionForce;
    [SerializeField] float explosionRange;
    [SerializeField] float upwardModifier;
    private void Update()
    {
        Cursor.visible = false;

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

        bool click = Input.GetMouseButtonDown(0); //0 bal eg�rgomb, 1 jobb

        if (isHit && click)
        {
            //itt robbantunk kattint�sra

            Rigidbody[] rbs = FindObjectsOfType<Rigidbody>(); //[] itt t�mb�t jelent (array). t�mb elemei indexelve vannak. 0-t�l kezd�dik a sz�moz�s

            for (int i = 0; i < rbs.Length; i++)
            {
                Rigidbody rb = rbs[i]; //rigidbody t�mb i-edik elem�t n�zi

                rb.AddExplosionForce(maxExplosionForce, hitInfo.point, explosionRange);
            }
            aimingPoint.GetComponent<ParticleSystem>().Play();
        }
    }
}
