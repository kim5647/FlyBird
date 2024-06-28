using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Texr : MonoBehaviour
{
    public GameObject GameObject1;
    public GameObject GameObject2;
    public GameObject GameObject3;
    public TMP_Text text1;
    public TMP_Text text2;
    public TMP_Text text3;

    void Start()
    {
        gen ganirat = new gen();
        bool log = false;

        text1.text = RandomText(ganirat, ref log, GameObject1);
        text2.text = RandomText(ganirat, ref log, GameObject2);
        text3.text = RandomText(ganirat, ref log, GameObject3);
    }

    private string RandomText(gen ganirat, ref bool log, GameObject obj)
    {
        if (!log && Random.Range(0, 2) == 0)
        {
            log = true;
            obj.tag = "Finish";
            return ganirat.gengenneprav();
        }
        else
        {
            obj.tag = "TEXT";
            return ganirat.genprav();
        }
    }
    public class gen
    {
        public char[] list = { '+', '-', '*' };
        private float result;
        public string ganirat()
        {

            int i1 = Random.Range(1, 10);
            int i2 = Random.Range(1, 10);

            char operation = list[Random.Range(0, list.Length)]; // ¬ыбор случайной операции из массива

            switch (operation)
            {
                case '+':
                    result = i1 + i2;
                    break;
                case '-':
                    result = i1 - i2;
                    break;
                case '*':
                    result = i1 * i2;
                    break;
            }

            return $"{i1} {operation} {i2} = ";

        }

        public string genprav()
        {
            return ganirat() + $"{result}";
        }
        public string gengenneprav()
        {
            int ll = Random.Range(-20, 100);
            while (result == ll)
            {
                ll = Random.Range(-20, 100);
            }

            return ganirat() + $"{ll}";
        }
    }


}
