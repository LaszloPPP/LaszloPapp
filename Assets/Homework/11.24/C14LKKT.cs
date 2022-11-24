
using UnityEngine;

public class C14LKKT : MonoBehaviour

{
    // Vigy�zok arra, hogy ne ker�lhessek v�gtelen ciklusba
    [SerializeField, Min(1)] int a, b;   // Bemeneti v�ltoz�k
    [SerializeField] int result;         // Kimeneti v�ltoz�

    void OnValidate()
    {
        // a minden t�bbsz�r�s�t megn�zem, hogy oszthat�-e b-vel
        // Ha tal�lok egy ilyet, kil�pek a ciklusb�l

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
     * Eleg�nsabban fogalmazva a m�dszer a k�vetkez�: elosztjuk a-t b-vel (a nagyobb sz�mot a kisebbel - ha a k�t sz�m egyenl�, akkor ln. k. o.-juk a=b), majd az oszt�si marad�kkal b-t, �s �gy tov�bb, akkor az utols� nem nulla marad�k maga az lnko lesz.[2]

P�lda:

lnko(84, 18) = ?

Ekkor elosztjuk 84-et 18-cal
a h�nyados 4, a marad�k 12
elosztjuk 18-at 12-vel
a h�nyados 1, a marad�k 6
elosztjuk 12-t 6-tal
a h�nyados 2, a marad�k 0,
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



