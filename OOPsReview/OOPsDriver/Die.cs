using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsDriver
{
    //classes by default have a access previlege of private 
    //you MUST add puplic to your classes

    public class Die
    {
        //create a new instance af the math object Random
        //this will be shared by each instance of Die
        //the instance of Random object will be created when
        //the first instance of Die is created

        private static Random _rnd = new Random();

        //classes have 
        // a) data members
        // b) properties
        // c) constuctors
        // d) behaviours (methods)

        //data members may be private for the class for use only
        //   within the class

        //the interface with a class is done via properties and behaviours

        //properties
        //can be fully implemented
        //  -a private data member
        //  -a public property
        private int _Sides;
        public int Sides
        {
            get
            {
                //this will return the private data member
                return _Sides;
            }
            private set //changed it to private because of the public void SetSides(int sides) method
            {
                //the reserved key word 'value' is used to obtain the incoming data value to the property, 
                //save the income data value to your private data member

                _Sides = value;  //the incoming data is a value, that needs to be stored into something, in our case _Sides
            }
        }

        //can be auto implemented
        // does not have a private data member
        // the system creates an internal data storage member for the property
        
        public int FaceValue { get; private set; } //changed set to private at the very end
        //for the outside user, this property is now readonly
        //methods and code WITHIN the class still have access to set

        //within a property you can validate that the incoming data value is "what is expected"
        private string _Color;
        public string Color
        {
            get
            {
                return _Color;          
            }

            set
            {
                //sample validation
                //there MUST be data within the incoming value
                //so an empty string is invalid
                if(string.IsNullOrEmpty(value)) //ALWAYS use this method to test if value is null or empty string!!!
                {
                    //incoming data value is incorrect
                    // a) you could send a message to the outside user
                    //throw new Exception("Color must have a value");

                    //OR
                    // b) you could allow the storage of a null value within the string data member
                    _Color = null;

                    //DO a) OR b), NOT both together
                }
                else
                {
                    _Color = value;
                }
            }
        }

        //Constructors
        //constructors are NOT directrly called by the outside user
        //constructors are called indirectly when the ouside user creates the instance of the class
        //to create an instance of the class the outside user will declare the Class variablename = new Class();
        //it is the 'new' that calles the constructor
        
        //you may or may not have a constructor for your class
        //IF you do NOT code a constructor for your class then a Default System Constructor is executed
        //This default system constructor initializes your locate data members to their default C# values.

        //If you do code a constructor for your class then YOU are responsible for all/any constructor in the class

        //"Default" constructor
        //This constructor is similar to the system constructor
        //this constructor would be called for --> new classname();
        public Die()
        {
            //even though the Sides would be set to a valid numeric within this class, a more logical value would be 6 (commented after public void Roll() was added)
            Sides = 6;
            Color = "White";
            Roll();
        }

        //"Greedy" constructor
        //This constructor usually receives a list of parameters,
        // one for each data member in the class
        //the constructor takes the parameter values and assignes the value to the appropriate data member
        //this constructor would be called for --> new Classname(value1, value2, ...);
        public Die(int sides, string color)
        {
            Sides = sides; //the set{} of the property Sides is used
            Color = color;
            Roll();
        }

        //Behaviours
        //these are methods
        public void Roll()
        {
            //will be used to generate a new facevalue for the instance
            //an instance of the math class Random() has been coded at the top of this class
            //the method in the class Random that will be called is
            //  .Next(inclusive lowest number, axclusive highest number)
            FaceValue = _rnd.Next(1, Sides + 1);
        }

        public void SetSides(int sides)
        {
            //let us assume only 6 to 20 sided dice are allowed
            if(sides > 5 && sides < 21)
            {
                Sides = sides;
                Roll();
            }
            else
            {
                //bad input
                throw new Exception("Invalid number of sides for the dice!");
            }
        }
    }
}

//ALWAYS close Visual Studio before pushing to Gitlab!!
