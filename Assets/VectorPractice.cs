using UnityEngine;
class VectorPractice : MonoBehaviour
{
    [SerializeField] Vector2 vector2Field; //Vector2 2D vektor
    [SerializeField] Vector3 vector3Field; //Vector3 3D vektor
    private void OnValidate()
    {
        Vector2 vector2 = new Vector2(24, 2.5f); //ha Vector2() �res akkor 0,0 a default
        Vector3 vector3 = new Vector3(24, 2.5f, 5); //ha Vector3() �res akkor 0,0,0 a default

        Vector3 zeroVector = Vector3.zero; //null �rt�k lek�r�s 0,0,0
        Vector3 upVector = Vector3.up; //fel �rt�k lek�r�s 0,1,0
        Vector3 leftVector = Vector3.left; //bal �rt�k lek�r�s -1,0,0
        //van m�g le, jobb, el�re, h�tra
        //----------------

        float v3y= vector3.y; //egy konkr�t tengely �rt�ke
        Debug.Log(v3y);
        vector3.z = 0; //�rt�kad�s egy adott vektor adott tengely�n
        //-----

        Vector3 vecA = new Vector3(1, 2, 5.5f);
        Vector3 vecB = new Vector3(33, 0, -2);

        Vector3 summaVec = vecA + vecB;
        Vector3 differenceVec = vecA - vecB;
        Vector3 prodctVec = vecA * 2;
    }
}
