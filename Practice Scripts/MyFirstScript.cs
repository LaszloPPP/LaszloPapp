using UnityEngine;

public class MyFirstScript : MonoBehaviour //class neve meg kell egyezni a script nevével Unityben
{

    void Start() //method. ez ami végre tud hajtódni folymatosan. "fentrõl lefelé"
    {
        Debug.Log("ello World");
        Debug.Log("ello " + name); //"name" a game object nevére hivatkozik

        // A Comment
        /* Also a Comment */

        int myFirstVariable; //deklaráljuk a változót. tartály amibe mehet 1 információ

        myFirstVariable = 6; //a változó értéke. definíció=értékadás a változónak
        myFirstVariable = 9; //változtatható az értéke
        Debug.Log(myFirstVariable);

        int aaa = 456; //lehet egy sorban deklarálni és defniálni

        int x, y, z;

        int integerNumber = 231; //egész szám
        float myFloatinPointNumber = 123.56f; //tört szám ~ lebegõ pontos. 'f' kell az érték végére
        string myFirstString = "Test String"; //string szöveg
        bool myFirstBool = true; //2 értékû. true v false 'eldöntendõ kérdés' - 'logikai típus'

        int a = 3, b = -1, c = 90;
        int summa = a + b; //példa összeg változó
        Debug.Log(summa);

        int dif = -55; // példa különbség változóra
        dif = dif - 5; //példa változó újra felhasználására

        int num = 6;
        num = num + 1;
        num += 1;
        num++;
        Debug.Log(num);

        int product = a * 5; //product=szorzás
        int ratio = a / 5; //int osztva int levágja a tört értéket
        int modulo = 34 % a; //modulo=ha osztjuk a számot a megadott egész int el a maradékot adja vissza

        var iii = 3456; //var esetén az elsõ deklarált típus "érték"  adja meg a típust. pl egész számból int, szövegbõl string
        var sss = "Random Text";

        int xxx = 3 + 2 * 4; //C# tartja a matek sorrendet ,11
        xxx = (3 + 2) * 4; //20

        string s1 = "Hello";
        string s2 = "World";
        string s3 = s1 + " " + s2; //Hello World

        int i1 = 3, i2 = 7;
        string s4 = s1 + i1; //Hello3
        string s5 = s1 + i1 + i2; //Hello37 int és string között stringgé alakítja az int-et
        string s6 = i2.ToString(); //szöveggé alakítás
        string s7 = i1 + i2 + s1; //10Hellofloat

        float ff1 = 3.5f;
        int ii1 = 4;

        int ii2 = (int)ff1; //típusváltás. kasztolás. explicit kasztolás
        float ff2 = ii1; //implicit kasztolás

        //stringbõl int = parse
        string numberText = "234";
        int ii3 = int.Parse(numberText);
    }
}
