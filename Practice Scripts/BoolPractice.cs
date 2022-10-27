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

        bool areTheInsEqual = i1 + 7 == i2; //==értékek egyenlõek, == az opertátor, értékek az operandus
        Debug.Log(areTheInsEqual);

        string s1 = "AAA";
        string s2 = "AAA";

        bool areTheStringsEqual = s1 == s2;
        Debug.Log(areTheStringsEqual);

        int i3 = 4, i4 = 78;
        bool areTheInsNotEqual = i3 != i4; //!= nem egyenlõ

        bool isTheFirstHigher = i3 > i4;
        bool isTheFirstLower = i3 < i4;
        bool isTheFirstHigherOrEqual = i3 >= i4; //>= <=, kisebb/nagyobb egyenlõ
        bool isTheFirstLowerOrEqual = i3 <= i4;

        //-------------------------------------------

        bool isOnGround = true; //földön állunk-e?
        int airJumpCount = 1; //hányat tudunk még a levegõben ugrani

        bool canJump = isOnGround || (airJumpCount > 0); //|| vagy mûvelet jele

        int ammo = 23;
        float timeSinceLastShot = 3.4f;
        float shootCooldown = 1;

        bool coolDownover= timeSinceLastShot >= shootCooldown;
        bool canShoot = ammo > 0 && timeSinceLastShot >= shootCooldown; //bool canShoot = ammo > 0 && coolDownover;

        bool canNotShoot = !canShoot; //! negálás mûvelet

        //XOR
        bool xor = true ^ true; //kizáró vagy
    }
}
