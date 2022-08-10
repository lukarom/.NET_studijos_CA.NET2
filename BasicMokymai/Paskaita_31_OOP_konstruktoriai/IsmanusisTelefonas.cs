﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paskaita_31_OOP_konstruktoriai
{
    internal class IsmanusisTelefonas
    {
        
        public IsmanusisTelefonas()
        {
            Dimensija = "Nenurodyta";
            Stiklas = "Nenurodyta";
            Rezoliucija = "Nenurodyta";
            Modelis = "Nenurodyta";
        }

        public IsmanusisTelefonas(string dimensija, string operacinesistema, string kamera, string gamintojas, string svoris)
        {
            Dimensija = dimensija;
            OperacineSistema = operacinesistema;
            Kamera = kamera;
            Gamintojas = gamintojas;
            Svoris = svoris;
        }

        public IsmanusisTelefonas(IsmanusisTelefonas ismanusis)
        {
            Dimensija = ismanusis.Dimensija;
            OperacineSistema = ismanusis.OperacineSistema;
            Kamera = ismanusis.Kamera;
            Gamintojas = ismanusis.Gamintojas;
            Svoris = ismanusis.Svoris;
        }


        private string dimensija;

        public string Dimensija
        {
            get { return dimensija; }
            set { dimensija = value; }
        }

        private string svoris;

        public string Svoris 
        {
            get { return svoris; }
            set { svoris = value; }
        }

        private string stiklas;

        public string Stiklas
        {
            get { return stiklas; }
            set { stiklas = value; }
        }

        private string rezoliucija;

        public string Rezoliucija
        {
            get { return rezoliucija; }
            set { rezoliucija = value; }
        }

        private double atmintis;

        public double Atmintis
        {
            get { return atmintis; }
            set { atmintis = value; }
        }

        private string modelis;

        public string Modelis
        {
            get { return modelis; }
            set { modelis = value; }
        }

        private string operacineSistema;

        public string OperacineSistema
        {
            get { return operacineSistema; }
            set { operacineSistema = value; }
        }

        private int baterija;

        public int Baterija
        {
            get { return baterija; }
            set { baterija = value; }
        }

        private string kamera;

        public string Kamera
        {
            get { return kamera; }
            set { kamera = value; }
        }

        private string gamintojas;

        public string Gamintojas
        {
            get { return gamintojas; }
            set { gamintojas = value; }
        }

       
    }
}
