
using UnityEngine;

public class C14LKKT : MonoBehaviour

{
    // Vigyázok arra, hogy ne kerülhessek végtelen ciklusba
    [SerializeField, Min(1)] int a, b;   // Bemeneti változók
    [SerializeField] int result;         // Kimeneti változó

    void OnValidate()
    {
        // a minden többszörösét megnézem, hogy osztható-e b-vel
        // Ha találok egy ilyet, kilépek a ciklusból

        int numberToTest = a;

        while (numberToTest % b != 0)
        {
            numberToTest += a;
        }

        result = numberToTest;
    }
}
    /*[SerializeField] int numA, numB, lkkt, lnko;

    private void OnValidate()
    {

        lnko = Lnko(numA, numB);
        lkkt = Lkkt(numA, numB);
        
    }
    int Lkkt(int a, int b)
    {
        
        int lkkt = (a * b) / Lnko(a, b);
        return lkkt;
        
    }
    

    int Lnko(int a, int b)

    /*
     * Elegánsabban fogalmazva a módszer a következõ: elosztjuk a-t b-vel (a nagyobb számot a kisebbel - ha a két szám egyenlõ, akkor ln. k. o.-juk a=b), majd az osztási maradékkal b-t, és így tovább, akkor az utolsó nem nulla maradék maga az lnko lesz.[2]

Példa:

lnko(84, 18) = ?

Ekkor elosztjuk 84-et 18-cal
a hányados 4, a maradék 12
elosztjuk 18-at 12-vel
a hányados 1, a maradék 6
elosztjuk 12-t 6-tal
a hányados 2, a maradék 0,
     */
    /*{
        if (a > b)
        {
            
            int remain = 0;
            while (a % b > 0)
            {
                int mod = a % b;
                remain = mod;
                a = b;
                b = mod;

            }
            return remain;
        }
        else if (b > a)
        {

            int remain = 0;
            while (b % a > 0)
            {
                int mod = b % a;
                remain = mod;
                b = a;
                a = mod;

            }
            return remain;
        }
         return a;
        

    }
    */



