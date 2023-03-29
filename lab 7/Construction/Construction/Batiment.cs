using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction
{
    enum qualite
    {
        parfait,
        a_construire,
        a_detruire
    }

    internal class Batiment
    {
        public qualite Etat { get; set; }
        private int priorite;

        public Batiment(qualite etat, int priorite)
        {
            this.Etat = etat;
            this.priorite = priorite;
        }

        public Batiment(qualite etat)
        {
            this.Etat = etat;
        }
    }
}
