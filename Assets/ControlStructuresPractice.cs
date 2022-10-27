using UnityEngine;

class ControlStructuresPractice : MonoBehaviour
{

    //ELÁGAZÁSOK

    [SerializeField] int number;
    [SerializeField] string parity;
    [SerializeField] string domain;
    [SerializeField] string danger;
    [SerializeField] string divisibleBy3;

    void OnValidate()
    {
        bool isEven = number % 2 == 0;

        if (isEven)
        {
            parity = "paros";
        }
        /*if (isEven==false)
        {
            parity = "paratlan";
        }*/
        else
        {
            parity = "paratlan";
        }

        //---------
        if (number > 0)
        {
            domain = "positive";
        }
        /*else
        {
            domain = "negative";
        }*/
        else if (number < 0)
        {
            domain = "negative";
        }
        else
        {
            domain = "zero";
        }
        //-------------
        if (number < 10)
        {
            danger = "low";
        }
        else if (number < 35)
        {
            danger = "medium";
        }
        else if (number < 50)
        {
            danger = "high";
        }
        else
        {
            danger = "run!";
        }

        //-----------------------
        divisibleBy3 = number % 3 == 0 ? "oszthato" : "nem oszthato"; // = feltétel ? opciók

        //ELÁGAZÁSOK
    }
    void Start()
    {
        //CIKLUSOK-----------------

        int i = 1;
        while (i <= 5)
        {
            Debug.Log(i);
            i++;
        }
        //alternatíva
        for (int j = 1; j < 5; j++)
        {
            Debug.Log(j);
        }
        for (int j = 10; j >= 1; j--)
        {
            Debug.Log(j);
        }

        for (int h = 0; h <= 100; h += 3)
        {
            Debug.Log(h);
        }

        //for (int m=0; m<=100; m%3)
        /*while (i % 3 == 0 && i % 7 == 0 && i <= 100)
        {
            Debug.Log(i);
            i++;
        }*/
        /*for (i = 1; i < 100; i++)
        {
            if (i % 3 == 0 && i % 7 == 0)
            {
                Debug.Log(i);
            }
        }*/
        for (i = 0; i < 100; i+=7)
        {
            if (i % 3 == 0)
            {
                Debug.Log(i);
            }
        }
    }
}
