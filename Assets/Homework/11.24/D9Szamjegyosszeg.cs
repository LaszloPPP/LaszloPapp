
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

    // Lényegi megoldás: 
    int SumOfDigits(int n)
    {
        int sum = 0;             // Az összeg nulláról indul
        while (n != 0)           // Addig megyek el, amig a számom nem nulla
        {
            int digit = n % 10;  // Veszem az utoló számjegyet
            sum += digit;        // Növelem az összeget a számjegy értékével
            n /= 10;             // Levágom az utolsó számjegyet
        }
        return sum;
    }
}
