using UnityEngine;
class VectorPractice : MonoBehaviour
{
    [SerializeField] Vector2 vector2Field; //Vector2 2D vektor
    [SerializeField] Vector3 vector3Field; //Vector3 3D vektor
    private void OnValidate()
    {
        Vector2 vector2 = new Vector2(24, 2.5f); //ha Vector2() üres akkor 0,0 a default
        Vector3 vector3 = new Vector3(24, 2.5f, 5); //ha Vector3() üres akkor 0,0,0 a default

        Vector3 zeroVector = Vector3.zero; //null érték lekérés 0,0,0
        Vector3 upVector = Vector3.up; //fel érték lekérés 0,1,0
        Vector3 leftVector = Vector3.left; //bal érték lekérés -1,0,0
        //van még le, jobb, elõre, hátra
        //----------------

        float v3y= vector3.y; //egy konkrét tengely értéke
        Debug.Log(v3y);
        vector3.z = 0; //értékadás egy adott vektor adott tengelyén
        //-----

        Vector3 vecA = new Vector3(1, 2, 5.5f);
        Vector3 vecB = new Vector3(33, 0, -2);

        Vector3 summaVec = vecA + vecB;
        Vector3 differenceVec = vecA - vecB;
        Vector3 prodctVec = vecA * 2;
    }
}
