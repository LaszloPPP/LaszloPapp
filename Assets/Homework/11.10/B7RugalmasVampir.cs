using UnityEngine;

public class B7RugalmasVampir : MonoBehaviour

/*
{
    [SerializeField] int hp;
    [SerializeField] int gold;
    [SerializeField] int priceMace = 10;
    [SerializeField] int priceDagger = 4;
    [SerializeField] int priceFang = 13;
    [SerializeField] bool canBuyMace;
    [SerializeField] bool canBuyDagger;
    [SerializeField] bool canBuyFang;
    [SerializeField] bool canBuyAll;

    private void OnValidate()
    {
        int goldToHp = 5;
        canBuyMace = (hp / goldToHp) + gold >= priceMace;
        canBuyDagger = (hp / goldToHp) + gold >= priceDagger;
        canBuyFang = (hp / goldToHp) + gold >= priceFang;
        canBuyAll = canBuyMace && canBuyDagger && canBuyFang;
    }

}
*/

//Helyes megoldás

{
    [SerializeField] int hp;
    [SerializeField] int gold;
    [SerializeField] int priceMace = 10;
    [SerializeField] int priceDagger = 4;
    [SerializeField] int priceFang = 13;
    [SerializeField] bool canBuyMace;
    [SerializeField] bool canBuyDagger;
    [SerializeField] bool canBuyFang;
    [SerializeField] bool canBuyAll;

    private void OnValidate()
    {
        int goldToHp = 5;
        canBuyMace = (priceMace-gold)*goldToHp<hp;
        canBuyDagger = (priceDagger - gold) * goldToHp < hp;
        canBuyFang = (priceFang - gold) * goldToHp < hp;
        int priceAll = (priceMace + priceDagger + priceFang);
        canBuyAll = (priceAll - gold) * goldToHp < hp;
    }

}
