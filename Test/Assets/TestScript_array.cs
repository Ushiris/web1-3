using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//classを作ってみよう
public class Player
{
    private int
        HP = 100,
        power = 50;

    public void Attack()
    {
        Debug.Log(power + "　ダメージを与えた");
    }

    public void Damege(int damage)
    {
        HP -= damage;
        Debug.Log(damage + "　のダメージを受けた");
    }
}


public class TestScript_array : MonoBehaviour {


    //メソッド入門（返り値なし）
    void SayHello()
    {
        Debug.Log("Hello");
    }

    //メソッド入門（返り値あり）
    int Add(int a,int b)
    {
        return a + b;
    }

	// Use this for initialization
	void Start () {
        int[] array = new int[5];

        //便利！int[]型！
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i * 2;
            Debug.Log(array[i]);
        }

        //メソッドを呼び出してみよう
        SayHello();

        int x = 10,
            y = 3;
        Debug.Log(Add(x, y));

        //クラスをインスタンス化してみよう
        Player player = new Player();
        player.Attack();
        player.Damege(5);

        //Vectorクラスを使ってみよう
        Vector2 PlayerPosition = new Vector2(3.0f, 4.0f);
        PlayerPosition.x *= 2;
        PlayerPosition.y *= 2;
        Debug.Log(PlayerPosition);

        Vector2
            EnemyPosition = new Vector2(9.5f, 9.2f),
            dir = PlayerPosition - EnemyPosition;
        Debug.Log(dir);

        float len = dir.magnitude;
        Debug.Log(len);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
