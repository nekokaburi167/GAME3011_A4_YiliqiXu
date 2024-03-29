﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace LinePaint
{
    [CreateAssetMenu(fileName = "Pattern", menuName = "ScriptableObjects/Create PatternSO", order = 1)]
    public class PatternDataScriptable : ScriptableObject
    {
        public int width, height;
        public Vector2Int brushStartCoords;
        public List<ConnectedLine> completePattern = new List<ConnectedLine>();
    }

    [System.Serializable]
    public class ConnectedLine
    {
        public Vector2Int startCoord;
        public Vector2Int endCoord;

        public ConnectedLine(Vector2Int startCoord, Vector2Int endCoord)
        {
            this.startCoord = startCoord;
            this.endCoord = endCoord;
        }
    }

}