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
        //private string autobusName; //nombre del autobus
        private int _number; //numero de ruta 
        private int _amount; //cantidad de asientos disponibles 

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
        //propiedad implementada
        public string autobusName { get; set; }

      
        /* public string getName()
         {
             return _autobusName;
         }

         public void setName(string Name)
         {
             _autobusName = Name;
         }*/

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
        public void serAmount( int Amount)
        {
            _amount = Amount;
        }
        

      


    }
}
