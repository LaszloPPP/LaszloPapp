using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    [SerializeField] int[] intArray;
    [SerializeField] List<int> intList;
    [SerializeField] List<int> intList2=new List<int>();

    private void Start()
    {

        for (int i = 0; i < intArray.Length; i++)
        {
            int element = intArray[i];
            Debug.Log(element);
        }

        foreach (int element in intArray) //for egyszerûbb változata olyan elemeken amiken "végig lehet menni" pl tömb(array)
        {
            Debug.Log(element);


        }

        //kiíratni sorrendben az array elemeit érték szerint
        for (int i = intArray.Length - 11; i >= 0; i--)
        {
            int element = intArray[i];
            Debug.Log(element);
        }

        int[] intArray2 = new int[10];

        /*for (int i = 1; i <= intArray2.Length; i++)

        {
            intArray2[i - 1] = i * i;
            Debug.Log("intArray2 " + intArray2[i]);
        }

        //fibonacci

        int[] fibonacci = new int[10];



        for (int i = 1; i < fibonacci.Length; i++)
        {
            int prevValue = 0;

            int result = prevValue + fibonacci[i];
            //int result = fibonacci[i] + fibonacci[i - 1];
            //int prevValue+= fibonacci[i];
            Debug.Log("Fibo: " + result);



        }
        */

        //Lists--------------------------------
        //
        List<string> stringList = new List<string>();
        for (int i = 0; i < 10; i++)
        {
            int num = (i + 1) * (i + 1);
            stringList.Add(num.ToString());
        }

        foreach (string e in stringList)
        {
            Debug.Log(e);
        }

        bool successfulRemove = stringList.Remove("50"); //meghatározott lista érték kivétele
        stringList.RemoveAt(3); //lista megadott számadik eleme kivétele

        //egész list törlése
        stringList.Clear();
        //ugyanez ciklussal
        for (int i = 0; i < stringList.Count; i++)
        {
            stringList.RemoveAt(0);
        }

        //lista feltültése random elemekkel

        for (int i = 0; i < 100; i++)
        {
            int random = Random.Range(1, 101);

            intList2.Add(random);

        }

        //páros elemek törlése listából
        for (int i = intList2.Count - 1; i >= 0; i--)
        {
            int element = intList2[i];
            if (element % 2 == 0)
            {
                intList2.RemoveAt(i);
            }
        }

        intList2.Sort();

    }
}
