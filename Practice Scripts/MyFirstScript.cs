using UnityEngine;

public class MyFirstScript : MonoBehaviour //class neve meg kell egyezni a script nev�vel Unityben
{

    void Start() //method. ez ami v�gre tud hajt�dni folymatosan. "fentr�l lefel�"
    {
        Debug.Log("ello World");
        Debug.Log("ello " + name); //"name" a game object nev�re hivatkozik

        // A Comment
        /* Also a Comment */

        int myFirstVariable; //deklar�ljuk a v�ltoz�t. tart�ly amibe mehet 1 inform�ci�

        myFirstVariable = 6; //a v�ltoz� �rt�ke. defin�ci�=�rt�kad�s a v�ltoz�nak
        myFirstVariable = 9; //v�ltoztathat� az �rt�ke
        Debug.Log(myFirstVariable);

        int aaa = 456; //lehet egy sorban deklar�lni �s defni�lni

        int x, y, z;

        int integerNumber = 231; //eg�sz sz�m
        float myFloatinPointNumber = 123.56f; //t�rt sz�m ~ lebeg� pontos. 'f' kell az �rt�k v�g�re
        string myFirstString = "Test String"; //string sz�veg
        bool myFirstBool = true; //2 �rt�k�. true v false 'eld�ntend� k�rd�s' - 'logikai t�pus'

        int a = 3, b = -1, c = 90;
        int summa = a + b; //p�lda �sszeg v�ltoz�
        Debug.Log(summa);

        int dif = -55; // p�lda k�l�nbs�g v�ltoz�ra
        dif = dif - 5; //p�lda v�ltoz� �jra felhaszn�l�s�ra

        int num = 6;
        num = num + 1;
        num += 1;
        num++;
        Debug.Log(num);

        int product = a * 5; //product=szorz�s
        int ratio = a / 5; //int osztva int lev�gja a t�rt �rt�ket
        int modulo = 34 % a; //modulo=ha osztjuk a sz�mot a megadott eg�sz int el a marad�kot adja vissza

        var iii = 3456; //var eset�n az els� deklar�lt t�pus "�rt�k"  adja meg a t�pust. pl eg�sz sz�mb�l int, sz�vegb�l string
        var sss = "Random Text";

        int xxx = 3 + 2 * 4; //C# tartja a matek sorrendet ,11
        xxx = (3 + 2) * 4; //20

        string s1 = "Hello";
        string s2 = "World";
        string s3 = s1 + " " + s2; //Hello World

        int i1 = 3, i2 = 7;
        string s4 = s1 + i1; //Hello3
        string s5 = s1 + i1 + i2; //Hello37 int �s string k�z�tt stringg� alak�tja az int-et
        string s6 = i2.ToString(); //sz�vegg� alak�t�s
        string s7 = i1 + i2 + s1; //10Hellofloat

        float ff1 = 3.5f;
        int ii1 = 4;

        int ii2 = (int)ff1; //t�pusv�lt�s. kasztol�s. explicit kasztol�s
        float ff2 = ii1; //implicit kasztol�s

        //stringb�l int = parse
        string numberText = "234";
        int ii3 = int.Parse(numberText);
    }
}
