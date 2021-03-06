﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Antennas : MonoBehaviour {

    Antenna[] antennas;

	void Start () {
        RefreshAntennaList();
    }
	
    internal void TickAntennas()
    {
        foreach (Antenna antenna in antennas)
        {
            antenna.Tick();
        }
    }
    
    public void RefreshAntennaList()
    {
        antennas = GetComponentsInChildren<Antenna>();
    }
}
