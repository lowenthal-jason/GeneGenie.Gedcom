﻿// <copyright file="Program.cs" company="GeneGenie.com">
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
//
// You should have received a copy of the GNU Affero General Public License
// along with this program. If not, see http:www.gnu.org/licenses/ .
//
// </copyright>
// <author> Copyright (C) 2016 Ryan O'Neill r@genegenie.com </author>

namespace GeneGenie.Gedcom.Sample
{
    using System;

    /// <summary>
    /// Sample console app showing how to read, query, change and save a GEDCOM file.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// App entry point.
        /// </summary>
        public static void Main()
        {
            var db = Step1LoadTreeFromFile.LoadPresidentsTree();
            if (db == null)
            {
                return;
            }

            Step2QueryTree.QueryTree(db);

            Console.WriteLine($"Count of people before adding new person - {db.Individuals.Count}.");
            Step3AddAPerson.AddPerson(db);
            Console.WriteLine($"Count of people after adding new person - {db.Individuals.Count}.");

            Step4SaveTree.Save(db);

            Console.WriteLine("Finished, press a key to continue.");
            Console.ReadKey();
        }
    }
}
