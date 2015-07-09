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

        #region singleton

        public static Backbone Instance { get { return _instance; } }
        private static Backbone _instance = null;

        #endregion singleton

        #region init

        private void Awake()
        {
            // keeps the backbone alive in all levels
            DontDestroyOnLoad(gameObject);

            _instance = this;
        }

        #endregion init

    }
}