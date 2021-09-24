using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introduccion_POO
{
    class Autobus
    {
        //definir los miembros de la clase 
        //propiedades
        private int _cod;
        private string _autobusName; //nombre del autobus
        private int _number; //numero de ruta 
        private int _amount; //cantidad de asientos disponibles 


        //METODO CONTRUCTOR 
        public Autobus()//metodo vacio 
        { }

        //soporte de sobre carga de contructor 
        public Autobus(int cod, string autobusName, int number,int amount, string color)
        {
            _cod = cod;
            _autobusName = autobusName;
            _number = number;
            _amount = amount;
            _Color = color; 
        }


        //metodos de propiedad 

        //codigo 
        // get 
        public int getCod()
        {
            return _cod;
        }

        // set 
        public void setCod (int Cod)
            {
            _cod = Cod;
        }
        // nombre del autobus 
       

      
         public string getName()
         {
             return _autobusName;
        }

         public void setName(string Name)
         {
            _autobusName = Name;
         }

        // numero de ruta 
        public int getNumber()
        {
            return _number;
        }
        public void setNumber(int Number)
        {
            _number = Number;
        }

        //cantidad de asientos disponibles 
       public int getAmount()
        {
            return _amount;
        }
        public void setAmount( int Amount)
        {
            _amount = Amount;
        }

        //Se agrego otra propiedad, y es implementada 
        //propiedad color de autobus 

        //propiedad implementada
         public string _Color { get; set; }

        public string getAutobusInfo()
        {
            return "Cod: " +  _cod + "Nombre: " +  _autobusName +
                "Ruta: " +  _number + "Asientos disponibles: " + _amount + "Color: " + _Color; 
        }



    }
}
