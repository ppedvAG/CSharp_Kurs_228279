﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{
    public abstract class Fahrzeug
    {
        #region Lab 06: Properties, Methoden, Konstruktor

        //Properties
        public string Name { get; set; }
        public int MaxGeschwindigkeit { get; set; }
        public int AktGeschwindigkeit { get; set; }
        public double Preis { get; set; }
        public bool MotorLäuft { get; set; }

        //Konstruktor mit Übergabeparametern und Standartwerten
        public Fahrzeug(string name, int maxG, double preis) : this()
        {
            this.Name = name;
            this.MaxGeschwindigkeit = maxG;
            this.Preis = preis;
            this.AktGeschwindigkeit = 0;
            this.MotorLäuft = false;
        }

        public Fahrzeug()
        {
            Fahrzeug.AnzahlAllerFahrzeuge++;
        }
        //Methode zur Ausgabe von Objektinformationen | virtual erlaubt das Überschreiben durch erbende Klassen
        public virtual string Info()
        {
            if (this.MotorLäuft)
                return $"{this.Name} kostet {this.Preis}€ und fährt momentan mit {this.AktGeschwindigkeit} von maximal {this.MaxGeschwindigkeit}km/h.";
            else
                return $"{this.Name} kostet {this.Preis}€ und könnte maximal {this.MaxGeschwindigkeit}km/h fahren.";
        }

        //Methode zum Starten des Motors
        public void StarteMotor()
        {
            if (this.MotorLäuft)
                Console.WriteLine($"Der Motor von {this.Name} läuft bereits.");
            else
            {
                this.MotorLäuft = true;
                Console.WriteLine($"Der Motor von {this.Name} wurde gestartet.");
            }
        }

        //Methode zum Stoppen des Motors
        public void StoppeMotor()
        {
            if (!this.MotorLäuft)
                Console.WriteLine($"Der Motor von {this.Name} ist bereits gestoppt");
            else if (this.AktGeschwindigkeit > 0)
                Console.WriteLine($"Der Motor kann nicht gestoppt werden, da sich {this.Name} noch bewegt");
            else
            {
                this.MotorLäuft = false;
                Console.WriteLine($"Der Motor von {this.Name} wurde gestoppt.");
            }
        }

        //Methode zum Beschleunigen und Bremsen
        public void Beschleunige(int a)
        {
            if (this.MotorLäuft)
            {
                if (this.AktGeschwindigkeit + a > this.MaxGeschwindigkeit)
                    this.AktGeschwindigkeit = this.MaxGeschwindigkeit;
                else if (this.AktGeschwindigkeit + a < 0)
                    this.AktGeschwindigkeit = 0;
                else
                    this.AktGeschwindigkeit += a;

                Console.WriteLine($"{this.Name} bewegt sich jetzt mit {this.AktGeschwindigkeit}km/h");
            }
        }

        #endregion

        #region Lab 07: Statische Member, Destruktor
        //Der optionale DESTRUCTOR wird von der GaebageCollection bei Zerstörung (Speicherferigabe) des Objekts aufgerufen.
        ~Fahrzeug()
        {
            Console.WriteLine($"{this.Name} ist verschrottet worden.");
            AnzahlAllerFahrzeuge--;
        }


        //STATIC markiert statische Member. D.h. diese gelten für die Gesamtheit aller Objekte dieser Art und werden nicht für
        //jedes Objekt einzeln erstellt.
        public static int AnzahlAllerFahrzeuge { get; private set; } = 0;

        public static string BeschreibeAnzahlAllerFahrzeuge()
        {
            return $"Es wurden bist jetzt {AnzahlAllerFahrzeuge} Fahrzeuge produziert.";
        }

        #endregion

        #region Lab 09: Polymorphismus

        //statisches Feld für Zufallsgenerator
        protected static Random generator = new Random();
        //Methode zur zufälligen Generierung eines Fahrzeugs
        public static Fahrzeug GeneriereFahrzeug(string nameSuffix = "")
        {
            switch (generator.Next(1, 4))
            {
                //Instanziierung der jeweiligen spezifischen Fahrzeuge
                case 1:
                    return PKW.ErzeugeZufälligenPKW(nameSuffix);
                case 2:
                    return new Schiff("Titanic" + nameSuffix, 40, 25000000, Schiff.SchiffsTreibstoff.Dampf);
                default:
                    return new Flugzeug("Boing" + nameSuffix, 350, 90000000, 9800);
            }
        }

        //Definition einer abstrakten Methode
        public abstract void Hupen();

        //override ToString() überschreibt die Standart-ToString()-Methode
        public override string ToString()
        {
            return this.GetType().Name + ": " + this.Name;
        }

        #endregion


        #region Operatoren
        //Für Klassen können die bekannten Operatoren mittels des OPERATOR-Stichworts neu definiert werden.
        //Hier gilt ein Fahrzeug als größer, wenn seine MaxGeschwindigkeit größer ist
        public static bool operator >(Fahrzeug fz1, Fahrzeug fz2)
        {
            return fz1.MaxGeschwindigkeit > fz2.MaxGeschwindigkeit;
        }
        public static bool operator <(Fahrzeug fz1, Fahrzeug fz2)
        {
            return fz1.MaxGeschwindigkeit < fz2.MaxGeschwindigkeit;
        }

        #endregion
    }
}
