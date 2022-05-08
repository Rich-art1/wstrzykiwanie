﻿using Baza_danych.Interfaces;
using FizzBuzzNET.Data;
using FizzBuzzNET.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Baza_danych.Services
{
    public class PersonService : IPersonService
    {
        private readonly FizzbuzzContext _context;
        public PersonService(FizzbuzzContext context)
        {
            _context = context;
        }

        public IList<Fizzbuzz> Fizzbuzzes { get; set; }
        [BindProperty]
        public Fizzbuzz Fizzbuzz { get; set; }
        public Fizzbuzz AddEntry(Fizzbuzz newfizz)
        {
            _context.Fizzbuzz.Add(newfizz);
            _context.SaveChanges();
            return Fizzbuzz;
        }
        public IQueryable<Fizzbuzz> GetAllEntries()
        {
            var wyswietl = (from Fizzbuzz in _context.Fizzbuzz orderby Fizzbuzz.Data descending select Fizzbuzz);
            return wyswietl;
        }
        public IQueryable<Fizzbuzz> GetEntriesFromToday()
        {
            var wyswietl = from Fizzbuzz in _context.Fizzbuzz where DateTime.Compare(Fizzbuzz.Data,DateTime.Today)==1 orderby Fizzbuzz.Data descending select Fizzbuzz;
            return wyswietl;
        }

    }
}
