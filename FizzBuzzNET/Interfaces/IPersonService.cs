using FizzBuzzNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Baza_danych.Interfaces
{
    public interface IPersonService
    {
        public Fizzbuzz AddEntry(Fizzbuzz newfizz);
        public IQueryable<Fizzbuzz> GetAllEntries ();
        public IQueryable<Fizzbuzz> GetEntriesFromToday();
    }
}
