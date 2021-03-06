﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diary : MonoBehaviour {

    TextMesh textMesh;
    Timer timer;

	void Awake () {
        textMesh = GetComponentInChildren<TextMesh>();
        timer = FindObjectOfType<Timer>();
	}

    public void WriteToDiary(string message, bool noDate = false)
    {
        string messageToWrite = "";
        if (!noDate)
            messageToWrite += timer.GetDateForDiary();

        messageToWrite += message + "\n";
        textMesh.text = messageToWrite + "\n" + textMesh.text;
    }
}
