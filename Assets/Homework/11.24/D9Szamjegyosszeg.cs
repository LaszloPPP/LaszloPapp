
using UnityEngine;

public class D9Szamjegyosszeg : MonoBehaviour
{

    /*[SerializeField] int num;
    [SerializeField] int sumOfNum;

    private void OnValidate()
    {
        while (num >= 1)
        {
            int mod = num % 10;
            int remain = (num - mod)/10;
            sumOfNum = remain + mod;
            num = num / 10;
        }
        
    }
    */
    [SerializeField] int num;
    [SerializeField] int sumOfDigits;

    void OnValidate()
    {
        sumOfDigits = SumOfDigits(num);
    }

    // L�nyegi megold�s: 
    int SumOfDigits(int n)
    {
        int sum = 0;             // Az �sszeg null�r�l indul
        while (n != 0)           // Addig megyek el, amig a sz�mom nem nulla
        {
            int digit = n % 10;  // Veszem az utol� sz�mjegyet
            sum += digit;        // N�velem az �sszeget a sz�mjegy �rt�k�vel
            n /= 10;             // Lev�gom az utols� sz�mjegyet
        }
        return sum;
    }
}
