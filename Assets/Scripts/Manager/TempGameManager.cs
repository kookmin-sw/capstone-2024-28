﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempGameManager : MonoBehaviour
{
    public static TempGameManager instance;

    public bool isPause = false;

    public int curHp = 10;
    public int maxHp = 10;
    public int curLevel = 1;
    public float curExp = 0;
    public float[] listExp = new float[50];
    public int killCount = 0;

    public LevelUp uiLevelUp;
    public Player player;
    public PoolManager poolManager;
    public WeaponManager weaponManager;
    public ActorController actorController;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }


        float exp = 10;
        for (int i = 0; i < listExp.Length; i++)
        {
            listExp[i] = exp;
            exp *= 1.1f;
        }

    }

    

    public void GetExp(float plusExp)
    {
        curExp += plusExp;
        if (curExp >= listExp[curLevel - 1])
        {
            curExp -= listExp[curLevel - 1];
            curLevel++;
            uiLevelUp.Show();
        }
    }

    public void GetDamage(int damage)
    {
        curHp -= damage;
        if (curHp <= 0)
        {
            
        }
    }

    public void GetHp(int heal)
    {
        curHp = Mathf.Min(curHp + heal, maxHp);
    }


    //////////////////////////
    // 삭제 예정             //
    /////////////////////////
    private void Update()
    {
        // q Ŭ���� ����ġ 2�� ����
        if (Input.GetKeyDown(KeyCode.Q))
        {
            GetExp(2);
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            GetDamage(1);
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            GetHp(1);
            poolManager.Get(0);
        }
    }
    //////////////////////////
    // 삭제 예정             //
    /////////////////////////
}
