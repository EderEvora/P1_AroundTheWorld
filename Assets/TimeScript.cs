using UnityEngine;
using TMPro;
using System;
using System.Globalization;

public class TimeScript : MonoBehaviour
{
    public int utcOffset = -1;   // Cabo Verde = UTC-1
    TextMeshPro txt;

    void Start()
    {
        txt = GetComponent<TextMeshPro>();
    }

    void Update()
    {
        DateTime t = DateTime.UtcNow.AddHours(utcOffset);
        txt.text = t.ToString("h:mm tt", CultureInfo.InvariantCulture);
    }
}