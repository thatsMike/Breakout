using UnityEngine;
using System.Collections;

namespace Prototypes.Backbone
{

    /// <summary>
    /// Backbone keeps all objects alive needed for the ingamemenu, 
    /// audiolistener and valuesavings.
    /// </summary>

    public class Backbone : MonoBehaviour
    {

        #region SINGLETON

        public static Backbone Instance { get { return _instance; } }
        private static Backbone _instance = null;

        #endregion

        private void Awake()
        {
            // keeps the backbone alive in all levels
            DontDestroyOnLoad(gameObject); 
        }
    }
}