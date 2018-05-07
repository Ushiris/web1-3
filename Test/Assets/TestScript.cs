using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

        //いつもの
        Debug.Log("Hello World");

        //変数を使おう
        int age = 30;

        Debug.Log(age);

        //変数に変数の値を代入しよう
        float height1 = 160.5f;
        float height2 = height1;

        Debug.Log(height2);

        //string型を使おう
        string name = "Ushiris";

        Debug.Log(name);

        //計算をしよう（定数リテラル編）
        int sum = 1 + 2,
            sub = 3 - 2,
            mul = 2 * 5,
            div = 8 / 2;

        Debug.Log("sum=" + sum);
        Debug.Log("sub=" + sub);
        Debug.Log("mul=" + mul);
        Debug.Log("div=" + div);

        //計算をしよう（変数編）
        int num1 = 5,
            num2 = 6,
            answar = num1 + num2;

        Debug.Log(answar);

        //プログラミングで用意されている省略記法
        answar += 4;
        Debug.Log("+=:" + answar);
        answar++;
        Debug.Log("++:" + answar);

        //文字列の足し算
        string str1 = "Hello";
        string str2 = "World";

        Debug.Log(str1 + str2);

        //if文を使ってみよう
        bool t = false;
        if (t)
            Debug.Log("true!");
        else if (!t)
            Debug.Log("false!");

        //for文を使ってみよう
        for (int i = 0; i < 10; i++)
            if (i % 2 == 0)
                Debug.Log(i);

        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
