using UnityEngine;

class BoolPractice : MonoBehaviour
{

    void Start()
    {
        bool b;
        b = true; //vagy egy sorban 8-9: bool b = true;
        b = false;

        int i1 = 23;
        int i2 = 30;

        bool areTheInsEqual = i1 + 7 == i2; //==�rt�kek egyenl�ek, == az opert�tor, �rt�kek az operandus
        Debug.Log(areTheInsEqual);

        string s1 = "AAA";
        string s2 = "AAA";

        bool areTheStringsEqual = s1 == s2;
        Debug.Log(areTheStringsEqual);

        int i3 = 4, i4 = 78;
        bool areTheInsNotEqual = i3 != i4; //!= nem egyenl�

        bool isTheFirstHigher = i3 > i4;
        bool isTheFirstLower = i3 < i4;
        bool isTheFirstHigherOrEqual = i3 >= i4; //>= <=, kisebb/nagyobb egyenl�
        bool isTheFirstLowerOrEqual = i3 <= i4;

        //-------------------------------------------

        bool isOnGround = true; //f�ld�n �llunk-e?
        int airJumpCount = 1; //h�nyat tudunk m�g a leveg�ben ugrani

        bool canJump = isOnGround || (airJumpCount > 0); //|| vagy m�velet jele

        int ammo = 23;
        float timeSinceLastShot = 3.4f;
        float shootCooldown = 1;

        bool coolDownover= timeSinceLastShot >= shootCooldown;
        bool canShoot = ammo > 0 && timeSinceLastShot >= shootCooldown; //bool canShoot = ammo > 0 && coolDownover;

        bool canNotShoot = !canShoot; //! neg�l�s m�velet

        //XOR
        bool xor = true ^ true; //kiz�r� vagy
    }
}
