using UnityEngine;
using TMPro;
using System;
using System.Globalization;

public class TimeScript : MonoBehaviour
{
    public int utcOffset = -1;   // Cabo Verde = UTC-1
    public bool use24h = false;  // ligar no cubo 2
    TextMeshPro txt;

    void Start()
    {
        txt = GetComponent<TextMeshPro>();
    }

    void Update()
    {
        DateTime t = DateTime.UtcNow.AddHours(utcOffset);
        txt.text = t.ToString(use24h ? "HH:mm" : "h:mm tt", CultureInfo.InvariantCulture);
    }
}