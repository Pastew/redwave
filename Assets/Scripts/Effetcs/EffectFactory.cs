﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectFactory : MonoBehaviour {

    protected static EffectFactory instance;
    private GameObject[] effects;
    private int effectsNum = 2;

    void Start()
    {
        instance = this;
        effects = new GameObject[effectsNum+1];
        for (int i = 0; i < effectsNum; ++i)
            effects[i] = new GameObject();

        effects[0].AddComponent<EffectTemplate>();
        effects[1].AddComponent<Effect101>();
    }

    public EffectTemplate CreateEffect(int id)
    {
        GameObject go = Instantiate(instance.effects[id]);
        go.name = "Effect_" + id;
        return go.GetComponent<EffectTemplate>(); ;
    }
}
