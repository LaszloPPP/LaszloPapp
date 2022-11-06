
using UnityEngine;

class C8FizzBuzz : MonoBehaviour
{

    [SerializeField] int number;

    void Start()
    {
        string output;
        for (int i = 1; i <= number; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                output = $"FizzBuzz ({i})";
                Debug.Log(output);
            }
            else if (i % 5 == 0)
            {
                output = $"Buzz ({i})";
                Debug.Log(output);
            }
            else if (i % 3 == 0)
            {
                output = $"Fizz ({i})";
                Debug.Log(output);
            }
            else
            {
                Debug.Log(i);
            }
        }
    }

    /* Megoldas
    void Start()
    {
        for (int i = 1; i <= number; i++)
        {
						// Elõször tesztelem az oszthatóságot
            bool fizz = i % 3 == 0;
            bool buzz = i % 5 == 0;
            
						// többirányú elágazást használok
						// fontos, hogy a FizzBuzzal kezdjük (Gondold át, miért!)
            if(fizz && buzz)
                Debug.Log("FizzBuzz");
            else if (fizz)
                Debug.Log("Fizz");
            else if (buzz)
                Debug.Log("Buzz");
            else
                Debug.Log(i);
        }
    }
    */
}
