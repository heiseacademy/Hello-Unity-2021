using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class HelloSpielzyklus : MonoBehaviour
{
    public Spielstand spielstand = new Spielstand();

    public Transform sonne;

    public Farbschema farbschema;

    private void Start()
    {
        if (farbschema == null)
            Debug.LogError("Du hast vergessen ein Farbschema einzutragen!");

        Laden(); //AktualisiereSonne();
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            spielstand.uhrzeit = (spielstand.uhrzeit + 1) % 24;
            AktualisiereSonne();
        }
        else if (Input.GetKeyUp(KeyCode.S))
            Speichern();
        else if (Input.GetKeyUp(KeyCode.L))
            Laden();
    }

    private void AktualisiereSonne()
    {
        sonne.localRotation = Quaternion.Euler( (spielstand.uhrzeit / 24) * 360 ,0,0);

        Light light = sonne.GetComponent<Light>();
        light.color = farbschema.sonnenfarbe;
        light.intensity = farbschema.intensitaet;
    }


    private void Speichern()
    {
        string speicherdaten = JsonUtility.ToJson(spielstand);
        Debug.Log(speicherdaten);
        File.WriteAllText(Path.Combine( Application.persistentDataPath, "savegame1.json"), speicherdaten);
        Debug.Log("Gespeichert wurde nach: "+ Path.Combine(Application.persistentDataPath, "savegame1.json"));
    }

    private void Laden()
    {
        if (File.Exists(Path.Combine(Application.persistentDataPath, "savegame1.json")))
        {
            string speicherdaten = File.ReadAllText(Path.Combine(Application.persistentDataPath, "savegame1.json"));
            spielstand = JsonUtility.FromJson<Spielstand>(speicherdaten);
            AktualisiereSonne();
        }
    }

}
