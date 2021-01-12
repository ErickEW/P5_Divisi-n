// Encender*
// 2 -> Presionar2() / PresionarNumero(2)
// + -> PresionarMas() / Mas()
// 3 -> Presionar3()
// Pantalla: 2+3 -> string GetMensajePantalla()
// =
// Pantalla: 5
using System;
using System.Collections.Generic;

namespace Calculator
{
    class Calculator
    {
        bool on = false;
        List<string> numbers = new List<string>();
        List<string> operators = new List<string>();
        bool continueCurrentNumber = false;
        string screenMessage = "";

        // Encender
        public void TurnOn()
        {
            this.on = true;
        }

        // Apagar
        public void TurnOff()
        {
            this.on = false;
            this.screenMessage = "";
        }

        public bool IsOn()
        {
            return this.on;
        }

        public void PressNumber(int num)
        {
            //Si la calculadora está apagada, no hacer nada
            if (!this.on)
            {
                return;
            }
            if (this.continueCurrentNumber)
            {
                //Modificar número actual, agregándole el número introducido
                string currentNumber = numbers[numbers.Count - 1];
                currentNumber = currentNumber + num.ToString();
                numbers[numbers.Count - 1] = currentNumber;
            }
            else
            {
                //Agregar nuevo número
                numbers.Add(num.ToString());
                this.continueCurrentNumber = true;
            }
            this.screenMessage += num.ToString();
        }

        public void Sum()
        {
            //Si la calculadora está apagada, no hacer nada
            if (!this.on)
            {
                return;
            }
            this.continueCurrentNumber = false;
            operators.Add("+");
            this.screenMessage += "+";
        }

        public void Substract()
        { }

        public void Multiply()
        { }

        public void Divide()
        { }

        public void CalculateResult()
        {
            if (!this.on)
            {
                return;
            }
            //numbers: ["2", "3"]
            //operators: ["+"]
            //resultado: "5"
            if (numbers.Count == 2 && operators.Count == 1)
            {
                //operator es una palabra reservada
                string op = operators[0];
                if (op == "+")
                {
                    int num1 = Convert.ToInt32(numbers[0]);   
                    int num2 = Convert.ToInt32(numbers[1]);
                    int result = num1 + num2;
                    this.screenMessage = result.ToString();
                }
            }
            this.numbers.Clear();
            this.operators.Clear();
            this.continueCurrentNumber = false;
        }

        public string GetScreenMessage()
        {
            return this.screenMessage;
        }

        // Borrar
        public void Delete()
        { }
        // Exponente -> AgregarExponente
        public void AddExponent()
        { }

        // Raiz -> AgregarRaizCuadrada
        public void AddSquareRoot()
        { }

        // Pi
        public void PressPi()
        { }

        // e
        public void PressE()
        { }
    }
}
