using UnityEngine;
using System.Collections;

namespace Prototypes.Backbone
{

    /// <summary>
    /// InputContainer gets instantiated by the InputController, 
    /// gets values overwritten by the InputReader and 
    /// and updates all classes through the InputController
    /// </summary>

    public class InputContainer : MonoBehaviour
    {
        public struct InputValues
        {
           //bool touch = false;

        }

        private InputValues _inputValues;

        private void Awake()
        {
            //_inputValues = new InputValues();
        }

        public void ResetInputContainer()
        {
            // reset all values before getting new ones

            //_inputValues.touch = false;
        }
    }
}