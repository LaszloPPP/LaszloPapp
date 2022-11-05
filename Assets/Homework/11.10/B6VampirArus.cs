
using UnityEngine;

class B6VampirArus : MonoBehaviour

/* kimaradt az arany-HP 5 váltás
{
    [SerializeField] int hp;
    [SerializeField] int gold;
    [SerializeField] int priceMace = 10;
    [SerializeField] int priceDagger = 4;
    [SerializeField] int priceFang = 13;
    [SerializeField] bool canBuyMace;
    [SerializeField] bool canBuyDagger;
    [SerializeField] bool canBuyFang;

    private void OnValidate()
    {
        canBuyMace = hp > priceMace || gold >= priceMace;
        canBuyDagger = hp > priceDagger || gold >= priceDagger;
        canBuyFang = hp > priceFang || gold >= priceFang;
    }

}
*/

    //Megoldás alapján kiegészitve
{
    [SerializeField] int hp;
    [SerializeField] int gold;
    [SerializeField] int priceMace = 10;
    [SerializeField] int priceDagger = 4;
    [SerializeField] int priceFang = 13;
    [SerializeField] bool canBuyMace;
    [SerializeField] bool canBuyDagger;
    [SerializeField] bool canBuyFang;

    private void OnValidate()
    {
        int goldToHp = 5;
        canBuyMace = hp > priceMace * goldToHp || gold >= priceMace;
        canBuyDagger = hp > priceDagger * goldToHp || gold >= priceDagger;
        canBuyFang = hp > priceFang * goldToHp || gold >= priceFang;
    }

}