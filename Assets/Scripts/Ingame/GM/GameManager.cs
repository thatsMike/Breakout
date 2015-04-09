using UnityEngine;
using System.Collections;

namespace Prototypes.Ingame
{

    /// <summary>
    /// the GameManager 
    /// collects the points from the bricks, 
    /// counts the lives left to check if a ball can be spawned 
    /// saves the values in the backbone on levelpause
    /// </summary>

    public class GameManager : MonoBehaviour
    {
        #region singleton

        public static GameManager Instance { get { return _instance; } }
        private static GameManager _instance = null;

        #endregion singleton

        #region private values
        
        private bool _pause = true;
        
        #endregion private values

        #region interface

        public bool Pause { get { return _pause; } }

        #endregion interface

        #region init

        private void Awake()
        {  
            _instance = this;
        }

        private void Start()
        {

        }

        #endregion init

        #region update cycle

        private void Update()
        {

        }

        #endregion update cycle
    }
}