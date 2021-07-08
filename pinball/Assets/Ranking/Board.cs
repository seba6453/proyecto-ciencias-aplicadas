using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

namespace Name.boards{
    public class Board : MonoBehaviour
    {
        [SerializeField] private int maxScoresEntries = 5;
        [SerializeField] private Transform highScoresHolder = null;
        [SerializeField] private GameObject boardEntryObject = null;

        private string SavePath => $"{Application.persistentDataPath}/highscores.json";

        private void Start(){
            SavedData savedData = GetSavedScores();

            UpdateUI(savedData);
            SaveScores(savedData);
        }

        public void AddNewEntry(string s, float f){
            EntryData entryData = new EntryData();
            entryData.entryName = s;
            entryData.entryscore = f;
            AddEntry(entryData);
        }

        public void AddEntry(EntryData entryData){
            SavedData savedData = GetSavedScores();

            bool scoreAdd = false;
            for (int i = 0; i < savedData.highscores.Count; i++)
            {   
                if(entryData.entryscore > savedData.highscores[i].entryscore){
                    savedData.highscores.Insert(i,entryData);
                    scoreAdd = true;
                    break;
                }
            }

            if(!scoreAdd && savedData.highscores.Count < maxScoresEntries){
                savedData.highscores.Add(entryData);
            }

            if(savedData.highscores.Count > maxScoresEntries){
                savedData.highscores.RemoveRange(maxScoresEntries,savedData.highscores.Count - maxScoresEntries);
            }

            UpdateUI(savedData);
            SaveScores(savedData);
        }

        private void UpdateUI(SavedData saveData){
            foreach(Transform child in highScoresHolder){
                DestroyImmediate(child.gameObject,true);
            }

            foreach(EntryData highscore in saveData.highscores){
                Instantiate(boardEntryObject,highScoresHolder).
                    GetComponent<EntryUI>().Initialise(highscore);
            }
        }

        private SavedData GetSavedScores(){
            if(!File.Exists(SavePath)){
                File.Create(SavePath).Dispose();
                return new SavedData();
            }

            using (StreamReader stream = new StreamReader(SavePath))
            {
                string json = stream.ReadToEnd();
                return JsonUtility.FromJson<SavedData>(json);
            }
        }

        private void SaveScores(SavedData savedData){
            using(StreamWriter stream = new StreamWriter(SavePath)){
                string json = JsonUtility.ToJson(savedData,true);
                stream.Write(json);
            }
                
        }
    }
}
